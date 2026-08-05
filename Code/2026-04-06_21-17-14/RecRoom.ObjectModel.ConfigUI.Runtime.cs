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
		[Cpp2IlInjected.Address(RVA = "0x9B66620", Offset = "0x9B65620", VA = "0x189B66620", Slot = "4")]
		public override void OTSRDIPIITJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		private int[] DFSWPDPJVFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset QBNLPBWZQQF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9B6C850", Offset = "0x9B6B850", VA = "0x189B6C850", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9B6BEC0", Offset = "0x9B6AEC0", VA = "0x189B6BEC0")]
		private void ROXZSJHBEXH(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9B6C0E0", Offset = "0x9B6B0E0", VA = "0x189B6C0E0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9B6C140", Offset = "0x9B6B140", VA = "0x189B6C140", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9B6C870", Offset = "0x9B6B870", VA = "0x189B6C870")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal abstract class RJTGZYNFQPD : HTZWXHJXVBP<Enum>, DPCWGAXPFLI, WITVSAGWPSF, YBPCFOIOZBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool JDUEEPCCYST(Type a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9B663B0", Offset = "0x9B653B0", VA = "0x189B663B0")]
		protected RJTGZYNFQPD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal abstract class HTZWXHJXVBP<a> : WITVSAGWPSF, YBPCFOIOZBP where a : Enum
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class GZTFKPJKAMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public VZGVYUCXNGO SHYGHTSSVDJ;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public GZTFKPJKAMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x64785C0", Offset = "0x64775C0", VA = "0x1864785C0")]
			internal bool AFGQEWAUQFM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6525AB0", Offset = "0x6524AB0", VA = "0x186525AB0")]
		protected HTZWXHJXVBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x65254B0", Offset = "0x65244B0", VA = "0x1865254B0")]
		protected void DZFDGEXTSVK(IUVGKNWKIHZ a, VZGVYUCXNGO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6524E80", Offset = "0x6523E80", VA = "0x186524E80")]
		protected void DXNHNXUDOYS(ZDIOBSEEXTK<a> a, VZGVYUCXNGO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void SJISYTZKKTW(VZGVYUCXNGO a, PANYWPDESLO b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class AOLIDUVLPQG : MPYGONIZCTY, YBPCFOIOZBP
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public abstract NetworkProperty[] ZNXBMMSLQUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public abstract NetworkProperty[] ANDJDWHYTGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void SJISYTZKKTW(VZGVYUCXNGO a, POUCYHWJJWF b, UONKHDVKEDX c, PANYWPDESLO d);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3368BE0", Offset = "0x3367BE0", VA = "0x183368BE0")]
		protected static b XRVOUVUVITK<b>(NativeObjectLocalIdArray a, NetworkProperty<b> b) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x33689F0", Offset = "0x33679F0", VA = "0x1833689F0")]
		protected static void WZLOGIEXHAB<d>(NativeObjectLocalIdArray a, NetworkProperty<d> b, d c) where d : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		protected AOLIDUVLPQG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal abstract class RASMXWAVCGI<a> : WITVSAGWPSF, YBPCFOIOZBP where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class GZTFKPJKAMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public VZGVYUCXNGO SHYGHTSSVDJ;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public GZTFKPJKAMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6478390", Offset = "0x6477390", VA = "0x186478390")]
			internal bool AFGQEWAUQFM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6525AB0", Offset = "0x6524AB0", VA = "0x186525AB0")]
		protected RASMXWAVCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x77FFC30", Offset = "0x77FEC30", VA = "0x1877FFC30")]
		protected void DZFDGEXTSVK(IUVGKNWKIHZ a, VZGVYUCXNGO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x77FE610", Offset = "0x77FD610", VA = "0x1877FE610")]
		protected void DXNHNXUDOYS(ZDIOBSEEXTK<a> a, VZGVYUCXNGO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void SJISYTZKKTW(VZGVYUCXNGO a, PANYWPDESLO b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RegisterService(typeof(POUCYHWJJWF), new string[] { })]
	internal class ConfigUIService : POUCYHWJJWF, LTQFALLCSKZ, KBDWOSKHASX, QTEVQCUAZCJ, PLNLFWQKVZL
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[DependsOn]
		private UONKHDVKEDX JFLGJFYPPEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[DependsOn]
		private PANYWPDESLO KLHURHNCXWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private PropertyDrawerCandidates VDYNOWEURWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private NativeObjectLocalIdArray EDHJHSCVLDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private List<VZGVYUCXNGO> LXFXTWDUGLJ;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeObjectLocalIdArray PABKAZJISXW
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1719DB0", Offset = "0x1718DB0", VA = "0x181719DB0", Slot = "5")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9B64FE0", Offset = "0x9B63FE0", VA = "0x189B64FE0", Slot = "6")]
		public void InitExternal(GLSTNWKFOLX services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9B64A70", Offset = "0x9B63A70", VA = "0x189B64A70", Slot = "7")]
		public void IPPIPTCNVCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9B64B70", Offset = "0x9B63B70", VA = "0x189B64B70", Slot = "4")]
		public void IWWQWVNRUDI(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9B654F0", Offset = "0x9B644F0", VA = "0x189B654F0")]
		private void OQAAJWNTXZO(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9B65300", Offset = "0x9B64300", VA = "0x189B65300")]
		private void ONFUEBBMAPV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9B655D0", Offset = "0x9B645D0", VA = "0x189B655D0")]
		private void SJISYTZKKTW(Candidate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9B65560", Offset = "0x9B64560", VA = "0x189B65560", Slot = "8")]
		private void RYSBYWLQLAZ(GLSTNWKFOLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x10360F0", Offset = "0x10350F0", VA = "0x1810360F0", Slot = "9")]
		private void KCNBXUAVHWV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9B659A0", Offset = "0x9B649A0", VA = "0x189B659A0")]
		public ConfigUIService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[MatchPropertyDrawer(0)]
	internal class KQZGDYDLTXF : RJTGZYNFQPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9B66300", Offset = "0x9B65300", VA = "0x189B66300", Slot = "5")]
		public override void SJISYTZKKTW(VZGVYUCXNGO a, PANYWPDESLO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9B66260", Offset = "0x9B65260", VA = "0x189B66260", Slot = "7")]
		public override bool JDUEEPCCYST(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9B663B0", Offset = "0x9B653B0", VA = "0x189B663B0")]
		public KQZGDYDLTXF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[MatchPropertyDrawer(0)]
	internal class SKVIVLPRKUM : RJTGZYNFQPD
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9B69EB0", Offset = "0x9B68EB0", VA = "0x189B69EB0", Slot = "5")]
		public override void SJISYTZKKTW(VZGVYUCXNGO a, PANYWPDESLO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9B69E10", Offset = "0x9B68E10", VA = "0x189B69E10", Slot = "7")]
		public override bool JDUEEPCCYST(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9B663B0", Offset = "0x9B653B0", VA = "0x189B663B0")]
		public SKVIVLPRKUM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ConfigPropertyDrawer(typeof(RenderableColor), 1)]
	internal class ICKYVXRDPCJ : HTZWXHJXVBP<RenderableColor>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9B65BC0", Offset = "0x9B64BC0", VA = "0x189B65BC0", Slot = "5")]
		public override void SJISYTZKKTW(VZGVYUCXNGO a, PANYWPDESLO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9B65D10", Offset = "0x9B64D10", VA = "0x189B65D10")]
		public ICKYVXRDPCJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[MultiPropertyDrawer(2)]
	internal class NWVWQYYQEBP : AOLIDUVLPQG
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class BZJWDVGUZLQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public POUCYHWJJWF VNAPTNZGQJX;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public BZJWDVGUZLQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9B64340", Offset = "0x9B63340", VA = "0x189B64340")]
			internal (int, int) LKZFCTWKMJU()
			{
				return default((int, int));
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9B645B0", Offset = "0x9B635B0", VA = "0x189B645B0")]
			internal void LLEMAAQHVVD((int color, int material) value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override NetworkProperty[] ZNXBMMSLQUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override NetworkProperty[] ANDJDWHYTGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9B66720", Offset = "0x9B65720", VA = "0x189B66720", Slot = "9")]
		public override void SJISYTZKKTW(VZGVYUCXNGO a, POUCYHWJJWF b, UONKHDVKEDX c, PANYWPDESLO d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9B66AD0", Offset = "0x9B65AD0", VA = "0x189B66AD0")]
		public NWVWQYYQEBP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ConfigPropertyDrawer(typeof(bool))]
	internal class GMKJPQSMULY : RASMXWAVCGI<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9B65AF0", Offset = "0x9B64AF0", VA = "0x189B65AF0", Slot = "5")]
		public override void SJISYTZKKTW(VZGVYUCXNGO a, PANYWPDESLO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9B65B80", Offset = "0x9B64B80", VA = "0x189B65B80")]
		public GMKJPQSMULY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ConfigPropertyDrawer(typeof(FixedString32Bytes))]
	internal class OAXOPIRNBKI : RASMXWAVCGI<FixedString32Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class VBNXNXLVIWA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public VZGVYUCXNGO SHYGHTSSVDJ;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public VBNXNXLVIWA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9B6A410", Offset = "0x9B69410", VA = "0x189B6A410")]
			internal string LKZFCTWKMJU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9B6A560", Offset = "0x9B69560", VA = "0x189B6A560")]
			internal void LLEMAAQHVVD(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9B66C00", Offset = "0x9B65C00", VA = "0x189B66C00", Slot = "5")]
		public override void SJISYTZKKTW(VZGVYUCXNGO a, PANYWPDESLO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9B66D90", Offset = "0x9B65D90", VA = "0x189B66D90")]
		public OAXOPIRNBKI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ConfigPropertyDrawer(typeof(FixedString64Bytes))]
	internal class YRVMNBVCPZN : RASMXWAVCGI<FixedString64Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class VBNXNXLVIWA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public VZGVYUCXNGO SHYGHTSSVDJ;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public VBNXNXLVIWA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x9B6A350", Offset = "0x9B69350", VA = "0x189B6A350")]
			internal string LKZFCTWKMJU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x9B6A470", Offset = "0x9B69470", VA = "0x189B6A470")]
			internal void LLEMAAQHVVD(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9B6B850", Offset = "0x9B6A850", VA = "0x189B6B850", Slot = "5")]
		public override void SJISYTZKKTW(VZGVYUCXNGO a, PANYWPDESLO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9B6B9E0", Offset = "0x9B6A9E0", VA = "0x189B6B9E0")]
		public YRVMNBVCPZN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[ConfigPropertyDrawer(typeof(float3))]
	internal class QQRCJTAIIUF : RASMXWAVCGI<float3>
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class VBNXNXLVIWA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public VZGVYUCXNGO SHYGHTSSVDJ;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public VBNXNXLVIWA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9B6A2D0", Offset = "0x9B692D0", VA = "0x189B6A2D0")]
			internal float LKZFCTWKMJU()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9B6A5D0", Offset = "0x9B695D0", VA = "0x189B6A5D0")]
			internal void LLEMAAQHVVD(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9B6A230", Offset = "0x9B69230", VA = "0x189B6A230")]
			internal float LKORIGIPTNC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9B6A2B0", Offset = "0x9B692B0", VA = "0x189B6A2B0")]
			internal void LKTYFNCNCYL(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9B6A5E0", Offset = "0x9B695E0", VA = "0x189B6A5E0")]
			internal float LLUGRUXZYDE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x9B6A670", Offset = "0x9B69670", VA = "0x189B6A670")]
			internal void LLZNPBRXHON(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9B6A680", Offset = "0x9B69680", VA = "0x189B6A680")]
			internal float OZKLNIZNSBP(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9B6A150", Offset = "0x9B69150", VA = "0x189B6A150")]
			internal void CRWRFNQOBSS(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9B699D0", Offset = "0x9B689D0", VA = "0x189B699D0", Slot = "5")]
		public override void SJISYTZKKTW(VZGVYUCXNGO a, PANYWPDESLO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9B69DD0", Offset = "0x9B68DD0", VA = "0x189B69DD0")]
		public QQRCJTAIIUF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ConfigPropertyDrawer(typeof(float))]
	internal class EALUTFCQQAA : RASMXWAVCGI<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9B65A20", Offset = "0x9B64A20", VA = "0x189B65A20", Slot = "5")]
		public override void SJISYTZKKTW(VZGVYUCXNGO a, PANYWPDESLO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9B65AB0", Offset = "0x9B64AB0", VA = "0x189B65AB0")]
		public EALUTFCQQAA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[ConfigPropertyDrawer(typeof(int))]
	internal class USSWYUAKGAH : RASMXWAVCGI<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9B69FC0", Offset = "0x9B68FC0", VA = "0x189B69FC0", Slot = "5")]
		public override void SJISYTZKKTW(VZGVYUCXNGO a, PANYWPDESLO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9B6A050", Offset = "0x9B69050", VA = "0x189B6A050")]
		public USSWYUAKGAH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[ConfigPropertyDrawer(typeof(quaternion))]
	internal class WRFSPDQEXMW : RASMXWAVCGI<quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class VBNXNXLVIWA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public VZGVYUCXNGO SHYGHTSSVDJ;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public VBNXNXLVIWA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9B6A340", Offset = "0x9B69340", VA = "0x189B6A340")]
			internal float LKZFCTWKMJU()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9B6A550", Offset = "0x9B69550", VA = "0x189B6A550")]
			internal void LLEMAAQHVVD(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9B6A2A0", Offset = "0x9B692A0", VA = "0x189B6A2A0")]
			internal float LKORIGIPTNC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9B6A2C0", Offset = "0x9B692C0", VA = "0x189B6A2C0")]
			internal void LKTYFNCNCYL(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9B6A650", Offset = "0x9B69650", VA = "0x189B6A650")]
			internal float LLUGRUXZYDE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9B6A660", Offset = "0x9B69660", VA = "0x189B6A660")]
			internal void LLZNPBRXHON(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9B6A950", Offset = "0x9B69950", VA = "0x189B6A950")]
			internal float TSBCSGKZVRQ(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9B6A6F0", Offset = "0x9B696F0", VA = "0x189B6A6F0")]
			internal void PXGDRRKILVH(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9B6B410", Offset = "0x9B6A410", VA = "0x189B6B410", Slot = "5")]
		public override void SJISYTZKKTW(VZGVYUCXNGO a, PANYWPDESLO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9B6B810", Offset = "0x9B6A810", VA = "0x189B6B810")]
		public WRFSPDQEXMW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[ConfigPropertyDrawer(typeof(uint))]
	internal class VIVTIXLFYWS : RASMXWAVCGI<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class VBNXNXLVIWA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public VZGVYUCXNGO SHYGHTSSVDJ;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public VBNXNXLVIWA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9B6A3D0", Offset = "0x9B693D0", VA = "0x189B6A3D0")]
			internal int LKZFCTWKMJU()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9B6A500", Offset = "0x9B69500", VA = "0x189B6A500")]
			internal void LLEMAAQHVVD(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9B6AAB0", Offset = "0x9B69AB0", VA = "0x189B6AAB0", Slot = "5")]
		public override void SJISYTZKKTW(VZGVYUCXNGO a, PANYWPDESLO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9B6AC40", Offset = "0x9B69C40", VA = "0x189B6AC40")]
		public VIVTIXLFYWS()
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
	internal static class UYJUCYDHANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9B6A090", Offset = "0x9B69090", VA = "0x189B6A090")]
		public static void ENLVJUPNELT(Type a, Type b)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal struct CommonProperties
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9B64700", Offset = "0x9B63700", VA = "0x189B64700")]
		public static NativeList<NetworkProperty> JIGOKNQTYUI(NativeObjectLocalIdArray a, UONKHDVKEDX b)
		{
			return default(NativeList<NetworkProperty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9B64980", Offset = "0x9B63980", VA = "0x189B64980")]
		private static bool ZSRRJWXOROZ(NetworkProperty a, NativeObjectLocalIdArray b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class WQAQEUNIREF : VZGVYUCXNGO, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly NetworkProperty SHYGHTSSVDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly UONKHDVKEDX UCIOIYVISSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly NativeObjectLocalIdArray EDHJHSCVLDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool UKKZBUKEAXX;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string PAVMQALYVSV
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x9B6AC80", Offset = "0x9B69C80", VA = "0x189B6AC80", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool YVSLCTTADPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9B6B070", Offset = "0x9B6A070", VA = "0x189B6B070", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public RRObject ZWRRUFWTXCT
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x9B6B020", Offset = "0x9B6A020", VA = "0x189B6B020", Slot = "8")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Type AHRPWOVSMCK
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x9B6AFD0", Offset = "0x9B69FD0", VA = "0x189B6AFD0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action FMABRBNLYNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9B6ADB0", Offset = "0x9B69DB0", VA = "0x189B6ADB0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x9B6AF30", Offset = "0x9B69F30", VA = "0x189B6AF30", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9B6B320", Offset = "0x9B6A320", VA = "0x189B6B320")]
		public WQAQEUNIREF(NativeObjectLocalIdArray a, NetworkProperty b, UONKHDVKEDX c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9B6B210", Offset = "0x9B6A210", VA = "0x189B6B210")]
		private void XKCSYYXMRQR(BulkPropertyChangeData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9B6AE50", Offset = "0x9B69E50", VA = "0x189B6AE50", Slot = "10")]
		public void Get(MutableRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9B6B0F0", Offset = "0x9B6A0F0", VA = "0x189B6B0F0", Slot = "11")]
		public void Set(ReadOnlyRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9B6ACE0", Offset = "0x9B69CE0", VA = "0x189B6ACE0", Slot = "12")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[SpecificPropertyDrawer(1)]
	internal sealed class ZDVWKKDXJVE : VYECAXAZLLP, WITVSAGWPSF, YBPCFOIOZBP
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class LPQSXGDQTBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public VZGVYUCXNGO SHYGHTSSVDJ;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public LPQSXGDQTBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9B66550", Offset = "0x9B65550", VA = "0x189B66550")]
			internal bool LKZFCTWKMJU()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9B665A0", Offset = "0x9B655A0", VA = "0x189B665A0")]
			internal string LLEMAAQHVVD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9B663F0", Offset = "0x9B653F0", VA = "0x189B663F0")]
			internal void LKORIGIPTNC(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x9B66480", Offset = "0x9B65480", VA = "0x189B66480")]
			internal string LKTYFNCNCYL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NetworkProperty MDSBKMJCRCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9B6BE50", Offset = "0x9B6AE50", VA = "0x189B6BE50", Slot = "4")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9B6BA20", Offset = "0x9B6AA20", VA = "0x189B6BA20", Slot = "5")]
		public void SJISYTZKKTW(VZGVYUCXNGO a, PANYWPDESLO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public ZDVWKKDXJVE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class PWPEKUVJDEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly UONKHDVKEDX JFLGJFYPPEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly PANYWPDESLO DRGXEDKNZQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Action<Candidate> QYJDSSMOFNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HashSet<KHHRHPNTPPC> UZXKLMKILMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly Dictionary<KHHRHPNTPPC, List<Candidate>> PXWJDKZFNFE;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9B67800", Offset = "0x9B66800", VA = "0x189B67800")]
		public PWPEKUVJDEG(UONKHDVKEDX a, PANYWPDESLO b, Action<Candidate> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9B66ED0", Offset = "0x9B65ED0", VA = "0x189B66ED0")]
		public void VGNRDYWCLOW(NativeList<Candidate> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9B67210", Offset = "0x9B66210", VA = "0x189B67210")]
		private void WKYBPONHXJA(KHHRHPNTPPC a, Candidate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9B66DD0", Offset = "0x9B65DD0", VA = "0x189B66DD0")]
		public void FHWBQIQLLBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9B67390", Offset = "0x9B66390", VA = "0x189B67390")]
		private void ZJBQVUPFDMO(KHHRHPNTPPC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9B66E30", Offset = "0x9B65E30", VA = "0x189B66E30")]
		private void MAXRXXOGOKN(KHHRHPNTPPC a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class ILGXUGNAHLV : IEnumerable<NetworkProperty>, IEnumerable, IEnumerator<NetworkProperty>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private int KVXTPCCUFNU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NetworkProperty NNNUNWANACF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private int LNNEGLEATET;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public PropertiesByType NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private Type RHTSDVZKJJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Type PGZKPDNKDVJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private NativeParallelMultiHashMap<long, int>.Enumerator PQBFSTXQTPM;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private NetworkProperty HDJZNCKCIPC
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xE01B10", Offset = "0xE00B10", VA = "0x180E01B10", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(NetworkProperty);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x9B65E00", Offset = "0x9B64E00", VA = "0x189B65E00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x15B89F0", Offset = "0x15B79F0", VA = "0x1815B89F0")]
			[DebuggerHidden]
			public ILGXUGNAHLV(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x9B66190", Offset = "0x9B65190", VA = "0x189B66190", Slot = "7")]
			[DebuggerHidden]
			private void OHWWSGWCEEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x9B65EA0", Offset = "0x9B64EA0", VA = "0x189B65EA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x9B65E50", Offset = "0x9B64E50", VA = "0x189B65E50")]
			private void LZWZIAQZAET()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x9B66220", Offset = "0x9B65220", VA = "0x189B66220", Slot = "10")]
			[DebuggerHidden]
			private void UCVOSCIFQDQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x9B65D50", Offset = "0x9B64D50", VA = "0x189B65D50", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NetworkProperty> DGKBOHZSZQT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x9B65D50", Offset = "0x9B64D50", VA = "0x189B65D50", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator YIRXJWVWWXR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private NativeParallelMultiHashMap<long, int> CNRZPTGUKTA;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9B67B30", Offset = "0x9B66B30", VA = "0x189B67B30")]
		public PropertiesByType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9B67A10", Offset = "0x9B66A10", VA = "0x189B67A10")]
		[IteratorStateMachine(typeof(ILGXUGNAHLV))]
		public IEnumerable<NetworkProperty> XIZPTABQSNQ(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9B67910", Offset = "0x9B66910", VA = "0x189B67910", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9B67990", Offset = "0x9B66990", VA = "0x189B67990")]
		private long UUNZKGBVDWR(NetworkProperty a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9B67950", Offset = "0x9B66950", VA = "0x189B67950")]
		private long UUNZKGBVDWR(Type a)
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
		[Cpp2IlInjected.Address(RVA = "0x9B68040", Offset = "0x9B67040", VA = "0x189B68040")]
		public PropertyBitmap(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9B67E90", Offset = "0x9B66E90", VA = "0x189B67E90")]
		public static PropertyBitmap DEIARRDFBFW(int a, NativeArray<NetworkProperty> b)
		{
			return default(PropertyBitmap);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9B67E80", Offset = "0x9B66E80", VA = "0x189B67E80")]
		public bool BKZNYUXOVYO(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9B68030", Offset = "0x9B67030", VA = "0x189B68030")]
		public void Set(int index, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9B67D20", Offset = "0x9B66D20", VA = "0x189B67D20")]
		public bool All(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9B67DD0", Offset = "0x9B66DD0", VA = "0x189B67DD0")]
		public bool Any(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9B68020", Offset = "0x9B67020", VA = "0x189B68020", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal class PropertyDrawerCandidates
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly UONKHDVKEDX JFLGJFYPPEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly List<YBPCFOIOZBP> VANSPOKCDUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly PropertiesByType CNRZPTGUKTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private NativeParallelMultiHashMap<int, int> KZHXASDCBVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private NativeList<int> WSCQEVIXPAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private bool UKKZBUKEAXX;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public List<YBPCFOIOZBP> FXHTIVQPLPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9B69260", Offset = "0x9B68260", VA = "0x189B69260")]
		public PropertyDrawerCandidates(UONKHDVKEDX configPropertyService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9B681E0", Offset = "0x9B671E0", VA = "0x189B681E0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9B68A20", Offset = "0x9B67A20", VA = "0x189B68A20")]
		public void SMZVIVVSXWB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9B68BC0", Offset = "0x9B67BC0", VA = "0x189B68BC0")]
		public NativeList<Candidate> SWDPPYZRTLW(NativeArray<NetworkProperty> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9B68090", Offset = "0x9B67090", VA = "0x189B68090")]
		private bool BEZRPACQEAO(YBPCFOIOZBP a, PropertyBitmap b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3DF04C0", Offset = "0x3DEF4C0", VA = "0x183DF04C0")]
		private void ABILGGRXDXZ<b, a>(Action<b, a> a) where b : YBPCFOIOZBP where a : Attribute
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9B69090", Offset = "0x9B68090", VA = "0x189B69090")]
		private void UESPLRPZUWD(Type a, Type b, Type c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3DF07D0", Offset = "0x3DEF7D0", VA = "0x183DF07D0")]
		private c FTTZXZGSJSG<c>(Type a)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9B68930", Offset = "0x9B67930", VA = "0x189B68930")]
		private int MTMEGQENDJH(YBPCFOIOZBP a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9B686B0", Offset = "0x9B676B0", VA = "0x189B686B0")]
		private void LFALGXXFUPB(WITVSAGWPSF a, ConfigPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9B682C0", Offset = "0x9B672C0", VA = "0x189B682C0")]
		private void ETTJQYQUWZS(DPCWGAXPFLI a, MatchPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9B690C0", Offset = "0x9B680C0", VA = "0x189B690C0")]
		private void WAHEQHMMBGM(MPYGONIZCTY a, MultiPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9B685E0", Offset = "0x9B675E0", VA = "0x189B685E0")]
		private void KIGTEMKQNLZ(VYECAXAZLLP a, SpecificPropertyDrawer b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct PropertyShadowing : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<YBPCFOIOZBP> drawers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private NativeList<Candidate> unshadowed;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeList<Candidate> JRXEQVRPLDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xF2D660", Offset = "0xF2C660", VA = "0x180F2D660")]
			get
			{
				return default(NativeList<Candidate>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9B69980", Offset = "0x9B68980", VA = "0x189B69980")]
		public PropertyShadowing(List<YBPCFOIOZBP> drawers, NativeArray<Candidate> candidates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9B693A0", Offset = "0x9B683A0", VA = "0x189B693A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9B69680", Offset = "0x9B68680", VA = "0x189B69680")]
		private NativeList<Candidate> XBCXYWWQKRU(NativeArray<Candidate> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x9B69510", Offset = "0x9B68510", VA = "0x189B69510")]
		private bool SGKAVMUAUMD(YBPCFOIOZBP a, PropertyBitmap b, NetworkProperty c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9B693E0", Offset = "0x9B683E0", VA = "0x189B693E0")]
		private void IWMRSTULCOK(YBPCFOIOZBP a, PropertyBitmap b, NetworkProperty c)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal struct SortCandidatesByPriority : IComparer<Candidate>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9B69F60", Offset = "0x9B68F60", VA = "0x189B69F60", Slot = "4")]
		public int Compare(Candidate a, Candidate b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9B69F70", Offset = "0x9B68F70", VA = "0x189B69F70")]
		public static void Sort(NativeList<Candidate> candidates)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SpecificPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9B69FB0", Offset = "0x9B68FB0", VA = "0x189B69FB0")]
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
