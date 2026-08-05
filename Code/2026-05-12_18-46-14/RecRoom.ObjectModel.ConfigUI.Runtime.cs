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
		[Cpp2IlInjected.Address(RVA = "0x9B50120", Offset = "0x9B4EB20", VA = "0x189B50120", Slot = "4")]
		public override void QCIVJGOFOSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD341B0", Offset = "0xD32BB0", VA = "0x180D341B0")]
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
		private int[] QBWAEFIMHOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset GKXUUHBMTQD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xD11E20", Offset = "0xD10820", VA = "0x180D11E20", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9B54D50", Offset = "0x9B53750", VA = "0x189B54D50", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9B543E0", Offset = "0x9B52DE0", VA = "0x189B543E0")]
		private void QLHWPSDGGQL(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9B54600", Offset = "0x9B53000", VA = "0x189B54600", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9B54660", Offset = "0x9B53060", VA = "0x189B54660", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9B54D70", Offset = "0x9B53770", VA = "0x189B54D70")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal abstract class RZHEUQPUKMT : IYWWBIRLMNN<Enum>, XPGWPJMKHOM, RPHTWOKRDAL, WVLQVSGKUXR
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool QOGKOANVKBP(Type a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9B50440", Offset = "0x9B4EE40", VA = "0x189B50440")]
		protected RZHEUQPUKMT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal abstract class IYWWBIRLMNN<a> : RPHTWOKRDAL, WVLQVSGKUXR where a : Enum
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class EYKCAZOIXTX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public MKAVATDBMEI PNKDAAXNQCJ;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public EYKCAZOIXTX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x5C705B0", Offset = "0x5C6EFB0", VA = "0x185C705B0")]
			internal bool XWQRLHYZJQM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x64CA4E0", Offset = "0x64C8EE0", VA = "0x1864CA4E0")]
		protected IYWWBIRLMNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x66C6E70", Offset = "0x66C5870", VA = "0x1866C6E70")]
		protected void DPPTTRXESQG(DHEITMHBHVH a, MKAVATDBMEI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x66C7270", Offset = "0x66C5C70", VA = "0x1866C7270")]
		protected void JEQAEJAWQVS(YJDIMINQNDQ<a> a, MKAVATDBMEI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void ZNQOELICMYS(MKAVATDBMEI a, SHVULJFCHRU b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class KZMKSALNNPS : VUANTBNNNPK, WVLQVSGKUXR
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public abstract NetworkProperty[] UIDRWONQQXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public abstract NetworkProperty[] CDMAVSCHQMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void ZNQOELICMYS(MKAVATDBMEI a, KYEMSYGVNZF b, EOZHHJLHPOL c, SHVULJFCHRU d);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3C16B60", Offset = "0x3C15560", VA = "0x183C16B60")]
		protected static b YGSMKOYAUWC<b>(NativeObjectLocalIdArray a, NetworkProperty<b> b) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3C16970", Offset = "0x3C15370", VA = "0x183C16970")]
		protected static void TCTZGUDLZLN<d>(NativeObjectLocalIdArray a, NetworkProperty<d> b, d c) where d : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		protected KZMKSALNNPS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal abstract class GGKFXDLBLWK<a> : RPHTWOKRDAL, WVLQVSGKUXR where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class EYKCAZOIXTX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public MKAVATDBMEI PNKDAAXNQCJ;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public EYKCAZOIXTX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5C70600", Offset = "0x5C6F000", VA = "0x185C70600")]
			internal bool XWQRLHYZJQM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x64CA4E0", Offset = "0x64C8EE0", VA = "0x1864CA4E0")]
		protected GGKFXDLBLWK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x64C8CB0", Offset = "0x64C76B0", VA = "0x1864C8CB0")]
		protected void DPPTTRXESQG(DHEITMHBHVH a, MKAVATDBMEI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x64C92B0", Offset = "0x64C7CB0", VA = "0x1864C92B0")]
		protected void JEQAEJAWQVS(YJDIMINQNDQ<a> a, MKAVATDBMEI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void ZNQOELICMYS(MKAVATDBMEI a, SHVULJFCHRU b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RegisterService(typeof(KYEMSYGVNZF), new string[] { })]
	internal class ConfigUIService : KYEMSYGVNZF, IFXZZWGYZFR, VGWOSQHBTSN, DWYARZFXYRJ, MJCONUSWWSL
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log OMWAZFACTUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[DependsOn]
		private EOZHHJLHPOL ARVROHSZZAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[DependsOn]
		private SHVULJFCHRU VUPMQWXARIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private PropertyDrawerCandidates IGRAESXIGVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private NativeObjectLocalIdArray ZABRFIPUMXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private List<MKAVATDBMEI> YMXFXMABUEZ;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeObjectLocalIdArray JWVRYPWHURY
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x175A870", Offset = "0x1759270", VA = "0x18175A870", Slot = "5")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9B4CE60", Offset = "0x9B4B860", VA = "0x189B4CE60", Slot = "6")]
		public void InitExternal(GZOGVDISCYD services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9B4D3E0", Offset = "0x9B4BDE0", VA = "0x189B4D3E0", Slot = "7")]
		public void RLHTICJYTWL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9B4D4E0", Offset = "0x9B4BEE0", VA = "0x189B4D4E0", Slot = "4")]
		public void WSVXZOZFHLW(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9B4D370", Offset = "0x9B4BD70", VA = "0x189B4D370")]
		private void LZPBVXUWSRA(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9B4D180", Offset = "0x9B4BB80", VA = "0x189B4D180")]
		private void KQXACDKXXBT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9B4D950", Offset = "0x9B4C350", VA = "0x189B4D950")]
		private void ZNQOELICMYS(Candidate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9B4CDF0", Offset = "0x9B4B7F0", VA = "0x189B4CDF0", Slot = "8")]
		private void EZUYJSDOFYP(GZOGVDISCYD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1057720", Offset = "0x1056120", VA = "0x181057720", Slot = "9")]
		private void YIQUJNZVLKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9B4DD10", Offset = "0x9B4C710", VA = "0x189B4DD10")]
		public ConfigUIService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[MatchPropertyDrawer(0)]
	internal class WNIPPGTYVMV : RZHEUQPUKMT
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9B53920", Offset = "0x9B52320", VA = "0x189B53920", Slot = "5")]
		public override void ZNQOELICMYS(MKAVATDBMEI a, SHVULJFCHRU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9B53880", Offset = "0x9B52280", VA = "0x189B53880", Slot = "7")]
		public override bool QOGKOANVKBP(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9B50440", Offset = "0x9B4EE40", VA = "0x189B50440")]
		public WNIPPGTYVMV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[MatchPropertyDrawer(0)]
	internal class MIDBILEZNQC : RZHEUQPUKMT
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9B50390", Offset = "0x9B4ED90", VA = "0x189B50390", Slot = "5")]
		public override void ZNQOELICMYS(MKAVATDBMEI a, SHVULJFCHRU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9B502F0", Offset = "0x9B4ECF0", VA = "0x189B502F0", Slot = "7")]
		public override bool QOGKOANVKBP(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9B50440", Offset = "0x9B4EE40", VA = "0x189B50440")]
		public MIDBILEZNQC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ConfigPropertyDrawer(typeof(RenderableColor), 1)]
	internal class LMCSWMYFQOP : IYWWBIRLMNN<RenderableColor>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9B4FF90", Offset = "0x9B4E990", VA = "0x189B4FF90", Slot = "5")]
		public override void ZNQOELICMYS(MKAVATDBMEI a, SHVULJFCHRU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9B500E0", Offset = "0x9B4EAE0", VA = "0x189B500E0")]
		public LMCSWMYFQOP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[MultiPropertyDrawer(2)]
	internal class OZQZWLGQFNZ : KZMKSALNNPS
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class ZYQXQYTPHNK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public KYEMSYGVNZF KDBHTYUQFBZ;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public ZYQXQYTPHNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9B54040", Offset = "0x9B52A40", VA = "0x189B54040")]
			internal (int, int) SORFJSPDOHW()
			{
				return default((int, int));
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9B542A0", Offset = "0x9B52CA0", VA = "0x189B542A0")]
			internal void SOWMGZJAXTF((int color, int material) value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override NetworkProperty[] UIDRWONQQXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCC0", Offset = "0xD0B6C0", VA = "0x180D0CCC0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override NetworkProperty[] CDMAVSCHQMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9B50480", Offset = "0x9B4EE80", VA = "0x189B50480", Slot = "9")]
		public override void ZNQOELICMYS(MKAVATDBMEI a, KYEMSYGVNZF b, EOZHHJLHPOL c, SHVULJFCHRU d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9B50830", Offset = "0x9B4F230", VA = "0x189B50830")]
		public OZQZWLGQFNZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ConfigPropertyDrawer(typeof(bool))]
	internal class RZPQTEXNJGA : GGKFXDLBLWK<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9B53180", Offset = "0x9B51B80", VA = "0x189B53180", Slot = "5")]
		public override void ZNQOELICMYS(MKAVATDBMEI a, SHVULJFCHRU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9B53210", Offset = "0x9B51C10", VA = "0x189B53210")]
		public RZPQTEXNJGA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ConfigPropertyDrawer(typeof(FixedString32Bytes))]
	internal class DKKTMLHKNNQ : GGKFXDLBLWK<FixedString32Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class JLJLQVTDNTM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public MKAVATDBMEI PNKDAAXNQCJ;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public JLJLQVTDNTM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9B4F860", Offset = "0x9B4E260", VA = "0x189B4F860")]
			internal string SORFJSPDOHW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9B4FB00", Offset = "0x9B4E500", VA = "0x189B4FB00")]
			internal void SOWMGZJAXTF(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9B4DD90", Offset = "0x9B4C790", VA = "0x189B4DD90", Slot = "5")]
		public override void ZNQOELICMYS(MKAVATDBMEI a, SHVULJFCHRU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9B4DF20", Offset = "0x9B4C920", VA = "0x189B4DF20")]
		public DKKTMLHKNNQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ConfigPropertyDrawer(typeof(FixedString64Bytes))]
	internal class CPXHTMCGXHT : GGKFXDLBLWK<FixedString64Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class JLJLQVTDNTM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public MKAVATDBMEI PNKDAAXNQCJ;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public JLJLQVTDNTM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x9B4F910", Offset = "0x9B4E310", VA = "0x189B4F910")]
			internal string SORFJSPDOHW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x9B4FA70", Offset = "0x9B4E470", VA = "0x189B4FA70")]
			internal void SOWMGZJAXTF(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9B4C8B0", Offset = "0x9B4B2B0", VA = "0x189B4C8B0", Slot = "5")]
		public override void ZNQOELICMYS(MKAVATDBMEI a, SHVULJFCHRU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9B4CA40", Offset = "0x9B4B440", VA = "0x189B4CA40")]
		public CPXHTMCGXHT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[ConfigPropertyDrawer(typeof(float3))]
	internal class HJOSLDKTSRV : GGKFXDLBLWK<float3>
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class JLJLQVTDNTM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public MKAVATDBMEI PNKDAAXNQCJ;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public JLJLQVTDNTM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9B4F990", Offset = "0x9B4E390", VA = "0x189B4F990")]
			internal float SORFJSPDOHW()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9B4FA60", Offset = "0x9B4E460", VA = "0x189B4FA60")]
			internal void SOWMGZJAXTF(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9B4FB80", Offset = "0x9B4E580", VA = "0x189B4FB80")]
			internal float SPBTEGCYHEO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9B4FC00", Offset = "0x9B4E600", VA = "0x189B4FC00")]
			internal void SPHABMWVQPX(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9B4F7D0", Offset = "0x9B4E1D0", VA = "0x189B4F7D0")]
			internal float SNWDURNOCOM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x9B4F850", Offset = "0x9B4E250", VA = "0x189B4F850")]
			internal void SOBKRYHLLZV(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9B4FC10", Offset = "0x9B4E610", VA = "0x189B4FC10")]
			internal float UTMZCQRTYJF(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9B4FC80", Offset = "0x9B4E680", VA = "0x189B4FC80")]
			internal void ZFBLFACCWOE(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9B4EFC0", Offset = "0x9B4D9C0", VA = "0x189B4EFC0", Slot = "5")]
		public override void ZNQOELICMYS(MKAVATDBMEI a, SHVULJFCHRU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9B4F3C0", Offset = "0x9B4DDC0", VA = "0x189B4F3C0")]
		public HJOSLDKTSRV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ConfigPropertyDrawer(typeof(float))]
	internal class EGUGHEDUJDI : GGKFXDLBLWK<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9B4DF60", Offset = "0x9B4C960", VA = "0x189B4DF60", Slot = "5")]
		public override void ZNQOELICMYS(MKAVATDBMEI a, SHVULJFCHRU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9B4DFF0", Offset = "0x9B4C9F0", VA = "0x189B4DFF0")]
		public EGUGHEDUJDI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[ConfigPropertyDrawer(typeof(int))]
	internal class MBRSVWBLJSV : GGKFXDLBLWK<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9B50220", Offset = "0x9B4EC20", VA = "0x189B50220", Slot = "5")]
		public override void ZNQOELICMYS(MKAVATDBMEI a, SHVULJFCHRU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9B502B0", Offset = "0x9B4ECB0", VA = "0x189B502B0")]
		public MBRSVWBLJSV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[ConfigPropertyDrawer(typeof(quaternion))]
	internal class EXPYRODVRVK : GGKFXDLBLWK<quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class JLJLQVTDNTM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public MKAVATDBMEI PNKDAAXNQCJ;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public JLJLQVTDNTM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9B4F900", Offset = "0x9B4E300", VA = "0x189B4F900")]
			internal float SORFJSPDOHW()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9B4FA50", Offset = "0x9B4E450", VA = "0x189B4FA50")]
			internal void SOWMGZJAXTF(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9B4FB70", Offset = "0x9B4E570", VA = "0x189B4FB70")]
			internal float SPBTEGCYHEO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9B4FBF0", Offset = "0x9B4E5F0", VA = "0x189B4FBF0")]
			internal void SPHABMWVQPX(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9B4F7C0", Offset = "0x9B4E1C0", VA = "0x189B4F7C0")]
			internal float SNWDURNOCOM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9B4F840", Offset = "0x9B4E240", VA = "0x189B4F840")]
			internal void SOBKRYHLLZV(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9B4F660", Offset = "0x9B4E060", VA = "0x189B4F660")]
			internal float OVFFMNDDGDG(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9B4F400", Offset = "0x9B4DE00", VA = "0x189B4F400")]
			internal void CBNTQGVFCWH(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9B4EB80", Offset = "0x9B4D580", VA = "0x189B4EB80", Slot = "5")]
		public override void ZNQOELICMYS(MKAVATDBMEI a, SHVULJFCHRU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9B4EF80", Offset = "0x9B4D980", VA = "0x189B4EF80")]
		public EXPYRODVRVK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[ConfigPropertyDrawer(typeof(uint))]
	internal class YCHDFTSVLNC : GGKFXDLBLWK<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class JLJLQVTDNTM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public MKAVATDBMEI PNKDAAXNQCJ;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public JLJLQVTDNTM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9B4F8C0", Offset = "0x9B4E2C0", VA = "0x189B4F8C0")]
			internal int SORFJSPDOHW()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9B4FA00", Offset = "0x9B4E400", VA = "0x189B4FA00")]
			internal void SOWMGZJAXTF(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9B539D0", Offset = "0x9B523D0", VA = "0x189B539D0", Slot = "5")]
		public override void ZNQOELICMYS(MKAVATDBMEI a, SHVULJFCHRU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9B53B60", Offset = "0x9B52560", VA = "0x189B53B60")]
		public YCHDFTSVLNC()
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
	internal static class VUZRCERASJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9B537C0", Offset = "0x9B521C0", VA = "0x189B537C0")]
		public static void YEVLRVSPAPF(Type a, Type b)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal struct CommonProperties
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9B4CB70", Offset = "0x9B4B570", VA = "0x189B4CB70")]
		public static NativeList<NetworkProperty> SQLHJMOTWSO(NativeObjectLocalIdArray a, EOZHHJLHPOL b)
		{
			return default(NativeList<NetworkProperty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9B4CA80", Offset = "0x9B4B480", VA = "0x189B4CA80")]
		private static bool REIXFRBFPFB(NetworkProperty a, NativeObjectLocalIdArray b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class QBGAHIPJYZV : MKAVATDBMEI, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly NetworkProperty PNKDAAXNQCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly EOZHHJLHPOL UTQOKMEHZNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly NativeObjectLocalIdArray ZABRFIPUMXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool MLELKNOQAUT;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string KPIDBUYRLLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x9B52D50", Offset = "0x9B51750", VA = "0x189B52D50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DPQVXPCEHFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9B53010", Offset = "0x9B51A10", VA = "0x189B53010", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public RRObject RJLVWUHNMUB
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x9B52AC0", Offset = "0x9B514C0", VA = "0x189B52AC0", Slot = "8")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Type MERZPCICCKQ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x9B52D00", Offset = "0x9B51700", VA = "0x189B52D00", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action CDOPCVYJTKY
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9B52F70", Offset = "0x9B51970", VA = "0x189B52F70", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x9B52DB0", Offset = "0x9B517B0", VA = "0x189B52DB0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9B53090", Offset = "0x9B51A90", VA = "0x189B53090")]
		public QBGAHIPJYZV(NativeObjectLocalIdArray a, NetworkProperty b, EOZHHJLHPOL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9B52BF0", Offset = "0x9B515F0", VA = "0x189B52BF0")]
		private void IDOSWYOTFIX(BulkPropertyChangeData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9B52B10", Offset = "0x9B51510", VA = "0x189B52B10", Slot = "10")]
		public void Get(MutableRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9B52E50", Offset = "0x9B51850", VA = "0x189B52E50", Slot = "11")]
		public void Set(ReadOnlyRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9B529F0", Offset = "0x9B513F0", VA = "0x189B529F0", Slot = "12")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[SpecificPropertyDrawer(1)]
	internal sealed class YIPTTCPLNWE : TKLISGLSBJN, RPHTWOKRDAL, WVLQVSGKUXR
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class JOXUKJQLBDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public MKAVATDBMEI PNKDAAXNQCJ;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public JOXUKJQLBDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9B4FD60", Offset = "0x9B4E760", VA = "0x189B4FD60")]
			internal bool SORFJSPDOHW()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9B4FDB0", Offset = "0x9B4E7B0", VA = "0x189B4FDB0")]
			internal string SOWMGZJAXTF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9B4FE30", Offset = "0x9B4E830", VA = "0x189B4FE30")]
			internal void SPBTEGCYHEO(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x9B4FEC0", Offset = "0x9B4E8C0", VA = "0x189B4FEC0")]
			internal string SPHABMWVQPX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NetworkProperty ZKCBLCFMUPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9B53BA0", Offset = "0x9B525A0", VA = "0x189B53BA0", Slot = "4")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9B53C10", Offset = "0x9B52610", VA = "0x189B53C10", Slot = "5")]
		public void ZNQOELICMYS(MKAVATDBMEI a, SHVULJFCHRU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public YIPTTCPLNWE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class ENLCFRPQECY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly EOZHHJLHPOL ARVROHSZZAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly SHVULJFCHRU WWPVCWPYTFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Action<Candidate> ZMUYJJMURWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HashSet<SHZEQMCKDZQ> JLIUXXVSJPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly Dictionary<SHZEQMCKDZQ, List<Candidate>> IOPCYHDEPJW;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9B4EA70", Offset = "0x9B4D470", VA = "0x189B4EA70")]
		public ENLCFRPQECY(EOZHHJLHPOL a, SHVULJFCHRU b, Action<Candidate> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9B4E730", Offset = "0x9B4D130", VA = "0x189B4E730")]
		public void ZYCKMDQZJWE(NativeList<Candidate> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9B4E5B0", Offset = "0x9B4CFB0", VA = "0x189B4E5B0")]
		private void UWFGFSRUHFC(SHZEQMCKDZQ a, Candidate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9B4E030", Offset = "0x9B4CA30", VA = "0x189B4E030")]
		public void HWWGKGUMVFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9B4E090", Offset = "0x9B4CA90", VA = "0x189B4E090")]
		private void RIFXXBGIZFS(SHZEQMCKDZQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9B4E510", Offset = "0x9B4CF10", VA = "0x189B4E510")]
		private void STZRRTKQXDV(SHZEQMCKDZQ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class TQRQEUERSHP : IEnumerable<NetworkProperty>, IEnumerable, IEnumerator<NetworkProperty>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NetworkProperty AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private int TCMGCAWGCHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public PropertiesByType AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private Type XWYJJROIJCU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Type AYQMMQQBFDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private NativeParallelMultiHashMap<long, int>.Enumerator ONPYAFUWWYM;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private NetworkProperty JYGAMKKYXXM
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xE26DB0", Offset = "0xE257B0", VA = "0x180E26DB0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(NetworkProperty);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x9B536E0", Offset = "0x9B520E0", VA = "0x189B536E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x15F05D0", Offset = "0x15EEFD0", VA = "0x1815F05D0")]
			[DebuggerHidden]
			public TQRQEUERSHP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x9B53360", Offset = "0x9B51D60", VA = "0x189B53360", Slot = "7")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x9B533F0", Offset = "0x9B51DF0", VA = "0x189B533F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x9B53730", Offset = "0x9B52130", VA = "0x189B53730")]
			private void SMVYKFBVGYB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x9B53780", Offset = "0x9B52180", VA = "0x189B53780", Slot = "10")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x9B532B0", Offset = "0x9B51CB0", VA = "0x189B532B0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NetworkProperty> BDUILHKOBAB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x9B532B0", Offset = "0x9B51CB0", VA = "0x189B532B0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator DKFMUHWUXGJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly Log OMWAZFACTUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private NativeParallelMultiHashMap<long, int> PSBSWIJYGFG;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9B50B60", Offset = "0x9B4F560", VA = "0x189B50B60")]
		public PropertiesByType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9B50A50", Offset = "0x9B4F450", VA = "0x189B50A50")]
		[IteratorStateMachine(typeof(TQRQEUERSHP))]
		public IEnumerable<NetworkProperty> ZXFRDMEKAQQ(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9B50950", Offset = "0x9B4F350", VA = "0x189B50950", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9B509D0", Offset = "0x9B4F3D0", VA = "0x189B509D0")]
		private long MUXCFLLPBGX(NetworkProperty a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9B50990", Offset = "0x9B4F390", VA = "0x189B50990")]
		private long MUXCFLLPBGX(Type a)
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
		[Cpp2IlInjected.Address(RVA = "0x9B51070", Offset = "0x9B4FA70", VA = "0x189B51070")]
		public PropertyBitmap(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9B50EE0", Offset = "0x9B4F8E0", VA = "0x189B50EE0")]
		public static PropertyBitmap YGJVYGGCFCC(int a, NativeArray<NetworkProperty> b)
		{
			return default(PropertyBitmap);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9B50EC0", Offset = "0x9B4F8C0", VA = "0x189B50EC0")]
		public bool IMNZGJHXCEM(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9B50ED0", Offset = "0x9B4F8D0", VA = "0x189B50ED0")]
		public void Set(int index, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9B50D50", Offset = "0x9B4F750", VA = "0x189B50D50")]
		public bool All(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9B50E00", Offset = "0x9B4F800", VA = "0x189B50E00")]
		public bool Any(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9B50EB0", Offset = "0x9B4F8B0", VA = "0x189B50EB0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal class PropertyDrawerCandidates
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Log OMWAZFACTUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly EOZHHJLHPOL ARVROHSZZAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly List<WVLQVSGKUXR> TPVGCRIXBJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly PropertiesByType PSBSWIJYGFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private NativeParallelMultiHashMap<int, int> GNBMTQAUQTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private NativeList<int> ZZOGGOCIIQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private bool MLELKNOQAUT;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public List<WVLQVSGKUXR> WUENBWIZHJY
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9B52280", Offset = "0x9B50C80", VA = "0x189B52280")]
		public PropertyDrawerCandidates(EOZHHJLHPOL configPropertyService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9B513E0", Offset = "0x9B4FDE0", VA = "0x189B513E0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9B51740", Offset = "0x9B50140", VA = "0x189B51740")]
		public void HGASXURPQOX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9B518E0", Offset = "0x9B502E0", VA = "0x189B518E0")]
		public NativeList<Candidate> LLRXWPKBAYC(NativeArray<NetworkProperty> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9B51DB0", Offset = "0x9B507B0", VA = "0x189B51DB0")]
		private bool LXDSSVIWLYY(WVLQVSGKUXR a, PropertyBitmap b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3E13E20", Offset = "0x3E12820", VA = "0x183E13E20")]
		private void JRMPCPIYGBH<b, a>(Action<b, a> a) where b : WVLQVSGKUXR where a : Attribute
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9B521D0", Offset = "0x9B50BD0", VA = "0x189B521D0")]
		private void YEHLWFFEPFT(Type a, Type b, Type c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3E13AB0", Offset = "0x3E124B0", VA = "0x183E13AB0")]
		private c FKYKXZTJROU<c>(Type a)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9B520E0", Offset = "0x9B50AE0", VA = "0x189B520E0")]
		private int QVSLPFNBDED(WVLQVSGKUXR a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9B514C0", Offset = "0x9B4FEC0", VA = "0x189B514C0")]
		private void EVFKQUYTLNH(RPHTWOKRDAL a, ConfigPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9B510C0", Offset = "0x9B4FAC0", VA = "0x189B510C0")]
		private void DMZCUWFUFWK(XPGWPJMKHOM a, MatchPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9B51FD0", Offset = "0x9B509D0", VA = "0x189B51FD0")]
		private void PJAYMBJDLSW(VUANTBNNNPK a, MultiPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9B51F00", Offset = "0x9B50900", VA = "0x189B51F00")]
		private void MYGOEUVIAPT(TKLISGLSBJN a, SpecificPropertyDrawer b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct PropertyShadowing : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<WVLQVSGKUXR> drawers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private NativeList<Candidate> unshadowed;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeList<Candidate> ESHYEHXUXJI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xF50610", Offset = "0xF4F010", VA = "0x180F50610")]
			get
			{
				return default(NativeList<Candidate>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9B529A0", Offset = "0x9B513A0", VA = "0x189B529A0")]
		public PropertyShadowing(List<WVLQVSGKUXR> drawers, NativeArray<Candidate> candidates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9B526C0", Offset = "0x9B510C0", VA = "0x189B526C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9B523C0", Offset = "0x9B50DC0", VA = "0x189B523C0")]
		private NativeList<Candidate> AZUNSZTJAMQ(NativeArray<Candidate> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x9B52700", Offset = "0x9B51100", VA = "0x189B52700")]
		private bool HZXYGDALIGV(WVLQVSGKUXR a, PropertyBitmap b, NetworkProperty c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9B52870", Offset = "0x9B51270", VA = "0x189B52870")]
		private void KITEEFIMJPC(WVLQVSGKUXR a, PropertyBitmap b, NetworkProperty c)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal struct SortCandidatesByPriority : IComparer<Candidate>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9B53250", Offset = "0x9B51C50", VA = "0x189B53250", Slot = "4")]
		public int Compare(Candidate a, Candidate b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9B53260", Offset = "0x9B51C60", VA = "0x189B53260")]
		public static void Sort(NativeList<Candidate> candidates)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SpecificPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9B532A0", Offset = "0x9B51CA0", VA = "0x189B532A0")]
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
