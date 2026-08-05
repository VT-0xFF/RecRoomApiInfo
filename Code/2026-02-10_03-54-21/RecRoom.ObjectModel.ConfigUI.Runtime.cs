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
		[Cpp2IlInjected.Address(RVA = "0x85D6AC0", Offset = "0x85D5CC0", VA = "0x1885D6AC0", Slot = "4")]
		public override void JUFURAKXVZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		private int[] ECEPPZWRAMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset ROOEZRYFVRR;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xABA480", Offset = "0xAB9680", VA = "0x180ABA480", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x85DD550", Offset = "0x85DC750", VA = "0x1885DD550", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85DD330", Offset = "0x85DC530", VA = "0x1885DD330")]
		private void SZMWSWNXWRR(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85DCBE0", Offset = "0x85DBDE0", VA = "0x1885DCBE0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85DCC40", Offset = "0x85DBE40", VA = "0x1885DCC40", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85DD570", Offset = "0x85DC770", VA = "0x1885DD570")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal abstract class PHRZPPUXQIT : YLDSYJMQXWH<Enum>, BSUYLTNSJIY, WBBEBKMOYBN, IJLEUBTCYZF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool ZNAREOXKVUV(Type a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x85D7630", Offset = "0x85D6830", VA = "0x1885D7630")]
		protected PHRZPPUXQIT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal abstract class YLDSYJMQXWH<a> : WBBEBKMOYBN, IJLEUBTCYZF where a : Enum
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class UITEPKMAORH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public AJSYTWDRATK OUUYYJJVDKV;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public UITEPKMAORH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x626F590", Offset = "0x626E790", VA = "0x18626F590")]
			internal bool ZVOPEQQLOAA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3E788B0", Offset = "0x3E77AB0", VA = "0x183E788B0")]
		protected YLDSYJMQXWH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3E78080", Offset = "0x3E77280", VA = "0x183E78080")]
		protected void BGWPUGUOPLM(ISEGNNAZCVT a, AJSYTWDRATK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3E78280", Offset = "0x3E77480", VA = "0x183E78280")]
		protected void MUBPOVUHZIA(UPIOWGNEDHY<a> a, AJSYTWDRATK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void XWSBHXUUOBI(AJSYTWDRATK a, TZKTYJNNBQG b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class FWYVQWTDVYA : DGENJTYIQYU, IJLEUBTCYZF
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public abstract NetworkProperty[] UGTQAZVRLET
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public abstract NetworkProperty[] VYYZLLZLQOS
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void XWSBHXUUOBI(AJSYTWDRATK a, CTXJEYKNPDB b, TLMLQDDKVLR c, TZKTYJNNBQG d);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3714660", Offset = "0x3713860", VA = "0x183714660")]
		protected static b NVSRZZYAIRM<b>(NativeObjectLocalIdArray a, NetworkProperty<b> b) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3714840", Offset = "0x3713A40", VA = "0x183714840")]
		protected static void RXUVCULOLID<d>(NativeObjectLocalIdArray a, NetworkProperty<d> b, d c) where d : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		protected FWYVQWTDVYA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal abstract class QUAZVRQKAYS<a> : WBBEBKMOYBN, IJLEUBTCYZF where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class UITEPKMAORH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public AJSYTWDRATK OUUYYJJVDKV;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public UITEPKMAORH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x626F360", Offset = "0x626E560", VA = "0x18626F360")]
			internal bool ZVOPEQQLOAA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3E788B0", Offset = "0x3E77AB0", VA = "0x183E788B0")]
		protected QUAZVRQKAYS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5CC8D10", Offset = "0x5CC7F10", VA = "0x185CC8D10")]
		protected void BGWPUGUOPLM(ISEGNNAZCVT a, AJSYTWDRATK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5CCA370", Offset = "0x5CC9570", VA = "0x185CCA370")]
		protected void MUBPOVUHZIA(UPIOWGNEDHY<a> a, AJSYTWDRATK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void XWSBHXUUOBI(AJSYTWDRATK a, TZKTYJNNBQG b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RegisterService(typeof(CTXJEYKNPDB), new string[] { })]
	internal class ConfigUIService : CTXJEYKNPDB, ASCPANIQGGL, AUDRUYSDRCN, QJSYQBVQVWT, FCSNFFOEHRZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log JXFMMOBINLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[DependsOn]
		private TLMLQDDKVLR RTFTQDQCGLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[DependsOn]
		private TZKTYJNNBQG BFOVIUMFVTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private PropertyDrawerCandidates GDJFIMKJEZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private NativeObjectLocalIdArray UBLOGSOETPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private List<AJSYTWDRATK> UXVGJOQJYNH;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeObjectLocalIdArray RPOSMOJQAFA
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x14C0B00", Offset = "0x14BFD00", VA = "0x1814C0B00", Slot = "5")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x85D5580", Offset = "0x85D4780", VA = "0x1885D5580", Slot = "6")]
		public void InitExternal(ANJPMPPNKBJ services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x85D5F70", Offset = "0x85D5170", VA = "0x1885D5F70", Slot = "7")]
		public void WZNPUCKKCSP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x85D5B00", Offset = "0x85D4D00", VA = "0x1885D5B00", Slot = "4")]
		public void TIEYKCUXXDO(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x85D5510", Offset = "0x85D4710", VA = "0x1885D5510")]
		private void GIQNFYSNTYW(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x85D58A0", Offset = "0x85D4AA0", VA = "0x1885D58A0")]
		private void MUYDBTTDEZH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x85D6070", Offset = "0x85D5270", VA = "0x1885D6070")]
		private void XWSBHXUUOBI(Candidate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x85D5A90", Offset = "0x85D4C90", VA = "0x1885D5A90", Slot = "8")]
		private void SZIMTXAXYAT(ANJPMPPNKBJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xDD1810", Offset = "0xDD0A10", VA = "0x180DD1810", Slot = "9")]
		private void BZXKCYDOFXZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x85D6430", Offset = "0x85D5630", VA = "0x1885D6430")]
		public ConfigUIService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[MatchPropertyDrawer(0)]
	internal class PJYWFONXYDT : PHRZPPUXQIT
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x85D7670", Offset = "0x85D6870", VA = "0x1885D7670", Slot = "5")]
		public override void XWSBHXUUOBI(AJSYTWDRATK a, TZKTYJNNBQG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x85D7720", Offset = "0x85D6920", VA = "0x1885D7720", Slot = "7")]
		public override bool ZNAREOXKVUV(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x85D7630", Offset = "0x85D6830", VA = "0x1885D7630")]
		public PJYWFONXYDT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[MatchPropertyDrawer(0)]
	internal class QEONCLBNXSO : PHRZPPUXQIT
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x85D9C60", Offset = "0x85D8E60", VA = "0x1885D9C60", Slot = "5")]
		public override void XWSBHXUUOBI(AJSYTWDRATK a, TZKTYJNNBQG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x85D9D10", Offset = "0x85D8F10", VA = "0x1885D9D10", Slot = "7")]
		public override bool ZNAREOXKVUV(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x85D7630", Offset = "0x85D6830", VA = "0x1885D7630")]
		public QEONCLBNXSO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ConfigPropertyDrawer(typeof(RenderableColor), 1)]
	internal class NGRUCXDDBDR : YLDSYJMQXWH<RenderableColor>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x85D6BC0", Offset = "0x85D5DC0", VA = "0x1885D6BC0", Slot = "5")]
		public override void XWSBHXUUOBI(AJSYTWDRATK a, TZKTYJNNBQG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x85D6D10", Offset = "0x85D5F10", VA = "0x1885D6D10")]
		public NGRUCXDDBDR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[MultiPropertyDrawer(2)]
	internal class WTMSNOGVFVZ : FWYVQWTDVYA
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class YYQSCBGHHGI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public CTXJEYKNPDB DNJILYYDUMP;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public YYQSCBGHHGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x85DB680", Offset = "0x85DA880", VA = "0x1885DB680")]
			internal (int, int) JTPBPXYUDYI()
			{
				return default((int, int));
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x85DB8E0", Offset = "0x85DAAE0", VA = "0x1885DB8E0")]
			internal void JTUINESRNJR((int color, int material) value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override NetworkProperty[] UGTQAZVRLET
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override NetworkProperty[] VYYZLLZLQOS
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x85DB020", Offset = "0x85DA220", VA = "0x1885DB020", Slot = "9")]
		public override void XWSBHXUUOBI(AJSYTWDRATK a, CTXJEYKNPDB b, TLMLQDDKVLR c, TZKTYJNNBQG d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x85DB3D0", Offset = "0x85DA5D0", VA = "0x1885DB3D0")]
		public WTMSNOGVFVZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ConfigPropertyDrawer(typeof(bool))]
	internal class APBBRYHIRGA : QUAZVRQKAYS<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85D50D0", Offset = "0x85D42D0", VA = "0x1885D50D0", Slot = "5")]
		public override void XWSBHXUUOBI(AJSYTWDRATK a, TZKTYJNNBQG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x85D5160", Offset = "0x85D4360", VA = "0x1885D5160")]
		public APBBRYHIRGA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ConfigPropertyDrawer(typeof(FixedString32Bytes))]
	internal class DNOUEIFFXBA : QUAZVRQKAYS<FixedString32Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class ZCFAVPDOUPY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public AJSYTWDRATK OUUYYJJVDKV;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public ZCFAVPDOUPY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x85DC380", Offset = "0x85DB580", VA = "0x1885DC380")]
			internal string JTPBPXYUDYI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x85DC4F0", Offset = "0x85DB6F0", VA = "0x1885DC4F0")]
			internal void JTUINESRNJR(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x85D64B0", Offset = "0x85D56B0", VA = "0x1885D64B0", Slot = "5")]
		public override void XWSBHXUUOBI(AJSYTWDRATK a, TZKTYJNNBQG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x85D6640", Offset = "0x85D5840", VA = "0x1885D6640")]
		public DNOUEIFFXBA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ConfigPropertyDrawer(typeof(FixedString64Bytes))]
	internal class UOIZATZJRTD : QUAZVRQKAYS<FixedString64Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class ZCFAVPDOUPY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public AJSYTWDRATK OUUYYJJVDKV;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public ZCFAVPDOUPY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x85DC250", Offset = "0x85DB450", VA = "0x1885DC250")]
			internal string JTPBPXYUDYI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x85DC410", Offset = "0x85DB610", VA = "0x1885DC410")]
			internal void JTUINESRNJR(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x85DAE50", Offset = "0x85DA050", VA = "0x1885DAE50", Slot = "5")]
		public override void XWSBHXUUOBI(AJSYTWDRATK a, TZKTYJNNBQG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x85DAFE0", Offset = "0x85DA1E0", VA = "0x1885DAFE0")]
		public UOIZATZJRTD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[ConfigPropertyDrawer(typeof(float3))]
	internal class NONKSZSOEHB : QUAZVRQKAYS<float3>
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class ZCFAVPDOUPY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public AJSYTWDRATK OUUYYJJVDKV;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public ZCFAVPDOUPY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x85DC310", Offset = "0x85DB510", VA = "0x1885DC310")]
			internal float JTPBPXYUDYI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x85DC400", Offset = "0x85DB600", VA = "0x1885DC400")]
			internal void JTUINESRNJR(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x85DC560", Offset = "0x85DB760", VA = "0x1885DC560")]
			internal float JTZPKLMOWVA()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x85DC5E0", Offset = "0x85DB7E0", VA = "0x1885DC5E0")]
			internal void JUEWHSGMGGJ(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x85DC1B0", Offset = "0x85DB3B0", VA = "0x1885DC1B0")]
			internal float JSUAAWXESEY()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x85DC230", Offset = "0x85DB430", VA = "0x1885DC230")]
			internal void JSZGYDRCBQH(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x85DCAA0", Offset = "0x85DBCA0", VA = "0x1885DCAA0")]
			internal float SVRAPMIOYHZ(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x85DC860", Offset = "0x85DBA60", VA = "0x1885DC860")]
			internal void KYTGLGIWAJG(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x85D6D50", Offset = "0x85D5F50", VA = "0x1885D6D50", Slot = "5")]
		public override void XWSBHXUUOBI(AJSYTWDRATK a, TZKTYJNNBQG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x85D7150", Offset = "0x85D6350", VA = "0x1885D7150")]
		public NONKSZSOEHB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ConfigPropertyDrawer(typeof(float))]
	internal class ZRRRYJZHVYW : QUAZVRQKAYS<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x85DCB10", Offset = "0x85DBD10", VA = "0x1885DCB10", Slot = "5")]
		public override void XWSBHXUUOBI(AJSYTWDRATK a, TZKTYJNNBQG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x85DCBA0", Offset = "0x85DBDA0", VA = "0x1885DCBA0")]
		public ZRRRYJZHVYW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[ConfigPropertyDrawer(typeof(int))]
	internal class XSHORKWCVSV : QUAZVRQKAYS<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x85DB4F0", Offset = "0x85DA6F0", VA = "0x1885DB4F0", Slot = "5")]
		public override void XWSBHXUUOBI(AJSYTWDRATK a, TZKTYJNNBQG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x85DB580", Offset = "0x85DA780", VA = "0x1885DB580")]
		public XSHORKWCVSV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[ConfigPropertyDrawer(typeof(quaternion))]
	internal class LGLOFGPHCWE : QUAZVRQKAYS<quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class ZCFAVPDOUPY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public AJSYTWDRATK OUUYYJJVDKV;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public ZCFAVPDOUPY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x85DC3E0", Offset = "0x85DB5E0", VA = "0x1885DC3E0")]
			internal float JTPBPXYUDYI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x85DC3F0", Offset = "0x85DB5F0", VA = "0x1885DC3F0")]
			internal void JTUINESRNJR(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x85DC5D0", Offset = "0x85DB7D0", VA = "0x1885DC5D0")]
			internal float JTZPKLMOWVA()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x85DC5F0", Offset = "0x85DB7F0", VA = "0x1885DC5F0")]
			internal void JUEWHSGMGGJ(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x85DC220", Offset = "0x85DB420", VA = "0x1885DC220")]
			internal float JSUAAWXESEY()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x85DC240", Offset = "0x85DB440", VA = "0x1885DC240")]
			internal void JSZGYDRCBQH(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x85DC940", Offset = "0x85DBB40", VA = "0x1885DC940")]
			internal float NACVUZBKXXK(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x85DC600", Offset = "0x85DB800", VA = "0x1885DC600")]
			internal void KCQQKZQRFUH(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x85D6680", Offset = "0x85D5880", VA = "0x1885D6680", Slot = "5")]
		public override void XWSBHXUUOBI(AJSYTWDRATK a, TZKTYJNNBQG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x85D6A80", Offset = "0x85D5C80", VA = "0x1885D6A80")]
		public LGLOFGPHCWE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[ConfigPropertyDrawer(typeof(uint))]
	internal class QCTGMHJTMII : QUAZVRQKAYS<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class ZCFAVPDOUPY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public AJSYTWDRATK OUUYYJJVDKV;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public ZCFAVPDOUPY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x85DC2D0", Offset = "0x85DB4D0", VA = "0x1885DC2D0")]
			internal int JTPBPXYUDYI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x85DC4A0", Offset = "0x85DB6A0", VA = "0x1885DC4A0")]
			internal void JTUINESRNJR(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x85D9A90", Offset = "0x85D8C90", VA = "0x1885D9A90", Slot = "5")]
		public override void XWSBHXUUOBI(AJSYTWDRATK a, TZKTYJNNBQG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x85D9C20", Offset = "0x85D8E20", VA = "0x1885D9C20")]
		public QCTGMHJTMII()
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
	internal static class YODPSERZHHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x85DB5C0", Offset = "0x85DA7C0", VA = "0x1885DB5C0")]
		public static void PUGUULRACFR(Type a, Type b)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal struct CommonProperties
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x85D5290", Offset = "0x85D4490", VA = "0x1885D5290")]
		public static NativeList<NetworkProperty> VUNSSMBJPHA(NativeObjectLocalIdArray a, TLMLQDDKVLR b)
		{
			return default(NativeList<NetworkProperty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x85D51A0", Offset = "0x85D43A0", VA = "0x1885D51A0")]
		private static bool NREOGMHHJAT(NetworkProperty a, NativeObjectLocalIdArray b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class YZLQFKTFUWL : AJSYTWDRATK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly NetworkProperty OUUYYJJVDKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly TLMLQDDKVLR CWFVVCHHCZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly NativeObjectLocalIdArray UBLOGSOETPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool WCTMPOAJLBF;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string TEJXEWDXJRB
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x85DBA20", Offset = "0x85DAC20", VA = "0x1885DBA20", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool UOPIMDBEPYB
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x85DBC60", Offset = "0x85DAE60", VA = "0x1885DBC60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public RRObject PTESSLGPGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x85DBEB0", Offset = "0x85DB0B0", VA = "0x1885DBEB0", Slot = "8")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Type OZSVPNIKROE
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x85DBE60", Offset = "0x85DB060", VA = "0x1885DBE60", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action EKPCLVWTNKY
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x85DC020", Offset = "0x85DB220", VA = "0x1885DC020", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x85DBDC0", Offset = "0x85DAFC0", VA = "0x1885DBDC0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x85DC0C0", Offset = "0x85DB2C0", VA = "0x1885DC0C0")]
		public YZLQFKTFUWL(NativeObjectLocalIdArray a, NetworkProperty b, TLMLQDDKVLR c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x85DBA80", Offset = "0x85DAC80", VA = "0x1885DBA80")]
		private void DNXLDEMZCMD(BulkPropertyChangeData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x85DBCE0", Offset = "0x85DAEE0", VA = "0x1885DBCE0", Slot = "10")]
		public void Get(MutableRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x85DBF00", Offset = "0x85DB100", VA = "0x1885DBF00", Slot = "11")]
		public void Set(ReadOnlyRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x85DBB90", Offset = "0x85DAD90", VA = "0x1885DBB90", Slot = "12")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[SpecificPropertyDrawer(1)]
	internal sealed class NUGNISOQAVS : SUFRIGBXGSP, WBBEBKMOYBN, IJLEUBTCYZF
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class PWPEITYPPDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public AJSYTWDRATK OUUYYJJVDKV;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public PWPEITYPPDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x85D77C0", Offset = "0x85D69C0", VA = "0x1885D77C0")]
			internal bool JTPBPXYUDYI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x85D7810", Offset = "0x85D6A10", VA = "0x1885D7810")]
			internal string JTUINESRNJR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x85D7890", Offset = "0x85D6A90", VA = "0x1885D7890")]
			internal void JTZPKLMOWVA(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x85D7920", Offset = "0x85D6B20", VA = "0x1885D7920")]
			internal string JUEWHSGMGGJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NetworkProperty TQTXFWEVEHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x85D7190", Offset = "0x85D6390", VA = "0x1885D7190", Slot = "4")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x85D7200", Offset = "0x85D6400", VA = "0x1885D7200", Slot = "5")]
		public void XWSBHXUUOBI(AJSYTWDRATK a, TZKTYJNNBQG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public NUGNISOQAVS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class UICZWRUVRRO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly TLMLQDDKVLR RTFTQDQCGLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly TZKTYJNNBQG ICALNJTFBSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Action<Candidate> BESOGHXBJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HashSet<OFQTNFBPPFY> HLSAVJNPWLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly Dictionary<OFQTNFBPPFY, List<Candidate>> RQRJRKVBGIU;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x85DAD40", Offset = "0x85D9F40", VA = "0x1885DAD40")]
		public UICZWRUVRRO(TLMLQDDKVLR a, TZKTYJNNBQG b, Action<Candidate> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x85DA590", Offset = "0x85D9790", VA = "0x1885DA590")]
		public void RKOPWGQLFKU(NativeList<Candidate> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x85DA410", Offset = "0x85D9610", VA = "0x1885DA410")]
		private void QUBDTNQGQSE(OFQTNFBPPFY a, Candidate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x85DA3B0", Offset = "0x85D95B0", VA = "0x1885DA3B0")]
		public void NKEPGZRMTDW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x85DA8D0", Offset = "0x85D9AD0", VA = "0x1885DA8D0")]
		private void ZWHVNUVRWZW(OFQTNFBPPFY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x85DA310", Offset = "0x85D9510", VA = "0x1885DA310")]
		private void HRGRCSQCHNJ(OFQTNFBPPFY a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class SUTQHMSCEEF : IEnumerable<NetworkProperty>, IEnumerable, IEnumerator<NetworkProperty>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private int HDIOWKWRMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NetworkProperty HVLGGEUBMPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private int SQEAAJZHTMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public PropertiesByType LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private Type DXWBJUFYHAY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Type NUWGRRZSTTH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private NativeParallelMultiHashMap<long, int>.Enumerator XORIMGFAPUY;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private NetworkProperty ZQQWLZXENYS
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xB82A80", Offset = "0xB81C80", VA = "0x180B82A80", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(NetworkProperty);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x85D9E60", Offset = "0x85D9060", VA = "0x1885D9E60", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x135A0D0", Offset = "0x13592D0", VA = "0x18135A0D0")]
			[DebuggerHidden]
			public SUTQHMSCEEF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x85D9EB0", Offset = "0x85D90B0", VA = "0x1885D9EB0", Slot = "7")]
			[DebuggerHidden]
			private void JZSTYLGWFSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x85D9F40", Offset = "0x85D9140", VA = "0x1885D9F40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x85DA220", Offset = "0x85D9420", VA = "0x1885DA220")]
			private void RKOKQQOFJWR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x85DA270", Offset = "0x85D9470", VA = "0x1885DA270", Slot = "10")]
			[DebuggerHidden]
			private void ZJSIHLTIANO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x85D9DB0", Offset = "0x85D8FB0", VA = "0x1885D9DB0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NetworkProperty> GCTUTSBVDVX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x85D9DB0", Offset = "0x85D8FB0", VA = "0x1885D9DB0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator KRQKAOMZCCF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly Log JXFMMOBINLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private NativeParallelMultiHashMap<long, int> NIAXLNFWJKQ;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x85D7C00", Offset = "0x85D6E00", VA = "0x1885D7C00")]
		public PropertiesByType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x85D7AF0", Offset = "0x85D6CF0", VA = "0x1885D7AF0")]
		[IteratorStateMachine(typeof(SUTQHMSCEEF))]
		public IEnumerable<NetworkProperty> JZXQNYOTCSE(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x85D7AB0", Offset = "0x85D6CB0", VA = "0x1885D7AB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x85D7A30", Offset = "0x85D6C30", VA = "0x1885D7A30")]
		private long BHTDSJLMTBR(NetworkProperty a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x85D79F0", Offset = "0x85D6BF0", VA = "0x1885D79F0")]
		private long BHTDSJLMTBR(Type a)
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
		[Cpp2IlInjected.Address(RVA = "0x85D8110", Offset = "0x85D7310", VA = "0x1885D8110")]
		public PropertyBitmap(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x85D7F50", Offset = "0x85D7150", VA = "0x1885D7F50")]
		public static PropertyBitmap BUCDUCMCXCS(int a, NativeArray<NetworkProperty> b)
		{
			return default(PropertyBitmap);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x85D80F0", Offset = "0x85D72F0", VA = "0x1885D80F0")]
		public bool NLUXJIZXQWI(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x85D8100", Offset = "0x85D7300", VA = "0x1885D8100")]
		public void Set(int index, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x85D7DF0", Offset = "0x85D6FF0", VA = "0x1885D7DF0")]
		public bool All(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x85D7EA0", Offset = "0x85D70A0", VA = "0x1885D7EA0")]
		public bool Any(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x85D80E0", Offset = "0x85D72E0", VA = "0x1885D80E0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal class PropertyDrawerCandidates
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Log JXFMMOBINLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly TLMLQDDKVLR RTFTQDQCGLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly List<IJLEUBTCYZF> TAUWWGNBDBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly PropertiesByType NIAXLNFWJKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private NativeParallelMultiHashMap<int, int> DTTYBAWQGHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private NativeList<int> JBRLWNNJMXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private bool WCTMPOAJLBF;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public List<IJLEUBTCYZF> FCEKMNHRVTE
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x85D9320", Offset = "0x85D8520", VA = "0x1885D9320")]
		public PropertyDrawerCandidates(TLMLQDDKVLR configPropertyService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x85D8160", Offset = "0x85D7360", VA = "0x1885D8160")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x85D8EA0", Offset = "0x85D80A0", VA = "0x1885D8EA0")]
		public void NTRYOQDRBIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x85D8240", Offset = "0x85D7440", VA = "0x1885D8240")]
		public NativeList<Candidate> HQVCQRLINBU(NativeArray<NetworkProperty> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x85D9040", Offset = "0x85D8240", VA = "0x1885D9040")]
		private bool TKINHUEGNQY(IJLEUBTCYZF a, PropertyBitmap b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x39A8010", Offset = "0x39A7210", VA = "0x1839A8010")]
		private void PULUSKNKEWV<b, a>(Action<b, a> a) where b : IJLEUBTCYZF where a : Attribute
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x85D8E70", Offset = "0x85D8070", VA = "0x1885D8E70")]
		private void MRSLOYXOWEJ(Type a, Type b, Type c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x39A7CA0", Offset = "0x39A6EA0", VA = "0x1839A7CA0")]
		private c KLSHTVXTBPS<c>(Type a)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x85D8710", Offset = "0x85D7910", VA = "0x1885D8710")]
		private int HSKQWJHWLYL(IJLEUBTCYZF a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x85D8BF0", Offset = "0x85D7DF0", VA = "0x1885D8BF0")]
		private void KVEDHLXLLPL(WBBEBKMOYBN a, ConfigPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x85D8800", Offset = "0x85D7A00", VA = "0x1885D8800")]
		private void JOFACCFGJHI(BSUYLTNSJIY a, MatchPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x85D9190", Offset = "0x85D8390", VA = "0x1885D9190")]
		private void YNDMBOKXNJA(DGENJTYIQYU a, MultiPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x85D8B20", Offset = "0x85D7D20", VA = "0x1885D8B20")]
		private void KPUQZMWWGQZ(SUFRIGBXGSP a, SpecificPropertyDrawer b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct PropertyShadowing : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<IJLEUBTCYZF> drawers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private NativeList<Candidate> unshadowed;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeList<Candidate> SFFMDSYZIOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xCCFB50", Offset = "0xCCED50", VA = "0x180CCFB50")]
			get
			{
				return default(NativeList<Candidate>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x85D9A40", Offset = "0x85D8C40", VA = "0x1885D9A40")]
		public PropertyShadowing(List<IJLEUBTCYZF> drawers, NativeArray<Candidate> candidates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x85D9460", Offset = "0x85D8660", VA = "0x1885D9460", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x85D94A0", Offset = "0x85D86A0", VA = "0x1885D94A0")]
		private NativeList<Candidate> LMYCWUBNSGM(NativeArray<Candidate> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x85D98D0", Offset = "0x85D8AD0", VA = "0x1885D98D0")]
		private bool PMWYTBQGFPX(IJLEUBTCYZF a, PropertyBitmap b, NetworkProperty c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x85D97A0", Offset = "0x85D89A0", VA = "0x1885D97A0")]
		private void MKNZKOEIQNS(IJLEUBTCYZF a, PropertyBitmap b, NetworkProperty c)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal struct SortCandidatesByPriority : IComparer<Candidate>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x85DA2B0", Offset = "0x85D94B0", VA = "0x1885DA2B0", Slot = "4")]
		public int Compare(Candidate a, Candidate b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x85DA2C0", Offset = "0x85D94C0", VA = "0x1885DA2C0")]
		public static void Sort(NativeList<Candidate> candidates)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SpecificPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x85DA300", Offset = "0x85D9500", VA = "0x1885DA300")]
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
