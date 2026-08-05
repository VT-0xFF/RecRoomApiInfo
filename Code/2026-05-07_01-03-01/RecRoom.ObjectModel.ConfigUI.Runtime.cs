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
		[Cpp2IlInjected.Address(RVA = "0x99EF960", Offset = "0x99EE360", VA = "0x1899EF960", Slot = "4")]
		public override void QCIVJGOFOSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x99F45D0", Offset = "0x99F2FD0", VA = "0x1899F45D0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x99F3C60", Offset = "0x99F2660", VA = "0x1899F3C60")]
		private void QLHWPSDGGQL(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x99F3E80", Offset = "0x99F2880", VA = "0x1899F3E80", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x99F3EE0", Offset = "0x99F28E0", VA = "0x1899F3EE0", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x99F45F0", Offset = "0x99F2FF0", VA = "0x1899F45F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x99EFC80", Offset = "0x99EE680", VA = "0x1899EFC80")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public EYKCAZOIXTX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x5BFC920", Offset = "0x5BFB320", VA = "0x185BFC920")]
			internal bool XWQRLHYZJQM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6439E80", Offset = "0x6438880", VA = "0x186439E80")]
		protected IYWWBIRLMNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6604A70", Offset = "0x6603470", VA = "0x186604A70")]
		protected void DPPTTRXESQG(DHEITMHBHVH a, MKAVATDBMEI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6604E50", Offset = "0x6603850", VA = "0x186604E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C02FB0", Offset = "0x3C019B0", VA = "0x183C02FB0")]
		protected static b YGSMKOYAUWC<b>(NativeObjectLocalIdArray a, NetworkProperty<b> b) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3C02DC0", Offset = "0x3C017C0", VA = "0x183C02DC0")]
		protected static void TCTZGUDLZLN<d>(NativeObjectLocalIdArray a, NetworkProperty<d> b, d c) where d : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public EYKCAZOIXTX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5BFC970", Offset = "0x5BFB370", VA = "0x185BFC970")]
			internal bool XWQRLHYZJQM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6439E80", Offset = "0x6438880", VA = "0x186439E80")]
		protected GGKFXDLBLWK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6438720", Offset = "0x6437120", VA = "0x186438720")]
		protected void DPPTTRXESQG(DHEITMHBHVH a, MKAVATDBMEI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6438CF0", Offset = "0x64376F0", VA = "0x186438CF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1707EC0", Offset = "0x17068C0", VA = "0x181707EC0", Slot = "5")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x99EC6C0", Offset = "0x99EB0C0", VA = "0x1899EC6C0", Slot = "6")]
		public void InitExternal(GZOGVDISCYD services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x99ECC40", Offset = "0x99EB640", VA = "0x1899ECC40", Slot = "7")]
		public void RLHTICJYTWL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x99ECD40", Offset = "0x99EB740", VA = "0x1899ECD40", Slot = "4")]
		public void WSVXZOZFHLW(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x99ECBD0", Offset = "0x99EB5D0", VA = "0x1899ECBD0")]
		private void LZPBVXUWSRA(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x99EC9E0", Offset = "0x99EB3E0", VA = "0x1899EC9E0")]
		private void KQXACDKXXBT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x99ED1B0", Offset = "0x99EBBB0", VA = "0x1899ED1B0")]
		private void ZNQOELICMYS(Candidate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x99EC650", Offset = "0x99EB050", VA = "0x1899EC650", Slot = "8")]
		private void EZUYJSDOFYP(GZOGVDISCYD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1013D00", Offset = "0x1012700", VA = "0x181013D00", Slot = "9")]
		private void YIQUJNZVLKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x99ED570", Offset = "0x99EBF70", VA = "0x1899ED570")]
		public ConfigUIService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[MatchPropertyDrawer(0)]
	internal class WNIPPGTYVMV : RZHEUQPUKMT
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x99F3180", Offset = "0x99F1B80", VA = "0x1899F3180", Slot = "5")]
		public override void ZNQOELICMYS(MKAVATDBMEI a, SHVULJFCHRU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x99F30E0", Offset = "0x99F1AE0", VA = "0x1899F30E0", Slot = "7")]
		public override bool QOGKOANVKBP(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x99EFC80", Offset = "0x99EE680", VA = "0x1899EFC80")]
		public WNIPPGTYVMV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[MatchPropertyDrawer(0)]
	internal class MIDBILEZNQC : RZHEUQPUKMT
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x99EFBD0", Offset = "0x99EE5D0", VA = "0x1899EFBD0", Slot = "5")]
		public override void ZNQOELICMYS(MKAVATDBMEI a, SHVULJFCHRU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x99EFB30", Offset = "0x99EE530", VA = "0x1899EFB30", Slot = "7")]
		public override bool QOGKOANVKBP(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x99EFC80", Offset = "0x99EE680", VA = "0x1899EFC80")]
		public MIDBILEZNQC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ConfigPropertyDrawer(typeof(RenderableColor), 1)]
	internal class LMCSWMYFQOP : IYWWBIRLMNN<RenderableColor>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x99EF7D0", Offset = "0x99EE1D0", VA = "0x1899EF7D0", Slot = "5")]
		public override void ZNQOELICMYS(MKAVATDBMEI a, SHVULJFCHRU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x99EF920", Offset = "0x99EE320", VA = "0x1899EF920")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public ZYQXQYTPHNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x99F38A0", Offset = "0x99F22A0", VA = "0x1899F38A0")]
			internal (int, int) SORFJSPDOHW()
			{
				return default((int, int));
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x99F3B10", Offset = "0x99F2510", VA = "0x1899F3B10")]
			internal void SOWMGZJAXTF((int color, int material) value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override NetworkProperty[] UIDRWONQQXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x99EFCC0", Offset = "0x99EE6C0", VA = "0x1899EFCC0", Slot = "9")]
		public override void ZNQOELICMYS(MKAVATDBMEI a, KYEMSYGVNZF b, EOZHHJLHPOL c, SHVULJFCHRU d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x99F0070", Offset = "0x99EEA70", VA = "0x1899F0070")]
		public OZQZWLGQFNZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ConfigPropertyDrawer(typeof(bool))]
	internal class RZPQTEXNJGA : GGKFXDLBLWK<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x99F29F0", Offset = "0x99F13F0", VA = "0x1899F29F0", Slot = "5")]
		public override void ZNQOELICMYS(MKAVATDBMEI a, SHVULJFCHRU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x99F2A80", Offset = "0x99F1480", VA = "0x1899F2A80")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public JLJLQVTDNTM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x99EF0A0", Offset = "0x99EDAA0", VA = "0x1899EF0A0")]
			internal string SORFJSPDOHW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x99EF340", Offset = "0x99EDD40", VA = "0x1899EF340")]
			internal void SOWMGZJAXTF(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x99ED5F0", Offset = "0x99EBFF0", VA = "0x1899ED5F0", Slot = "5")]
		public override void ZNQOELICMYS(MKAVATDBMEI a, SHVULJFCHRU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x99ED780", Offset = "0x99EC180", VA = "0x1899ED780")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public JLJLQVTDNTM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x99EF150", Offset = "0x99EDB50", VA = "0x1899EF150")]
			internal string SORFJSPDOHW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x99EF2B0", Offset = "0x99EDCB0", VA = "0x1899EF2B0")]
			internal void SOWMGZJAXTF(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x99EC110", Offset = "0x99EAB10", VA = "0x1899EC110", Slot = "5")]
		public override void ZNQOELICMYS(MKAVATDBMEI a, SHVULJFCHRU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x99EC2A0", Offset = "0x99EACA0", VA = "0x1899EC2A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public JLJLQVTDNTM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x99EF1D0", Offset = "0x99EDBD0", VA = "0x1899EF1D0")]
			internal float SORFJSPDOHW()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x99EF2A0", Offset = "0x99EDCA0", VA = "0x1899EF2A0")]
			internal void SOWMGZJAXTF(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x99EF3C0", Offset = "0x99EDDC0", VA = "0x1899EF3C0")]
			internal float SPBTEGCYHEO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x99EF440", Offset = "0x99EDE40", VA = "0x1899EF440")]
			internal void SPHABMWVQPX(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x99EF010", Offset = "0x99EDA10", VA = "0x1899EF010")]
			internal float SNWDURNOCOM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x99EF090", Offset = "0x99EDA90", VA = "0x1899EF090")]
			internal void SOBKRYHLLZV(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x99EF450", Offset = "0x99EDE50", VA = "0x1899EF450")]
			internal float UTMZCQRTYJF(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x99EF4C0", Offset = "0x99EDEC0", VA = "0x1899EF4C0")]
			internal void ZFBLFACCWOE(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x99EE800", Offset = "0x99ED200", VA = "0x1899EE800", Slot = "5")]
		public override void ZNQOELICMYS(MKAVATDBMEI a, SHVULJFCHRU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x99EEC00", Offset = "0x99ED600", VA = "0x1899EEC00")]
		public HJOSLDKTSRV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ConfigPropertyDrawer(typeof(float))]
	internal class EGUGHEDUJDI : GGKFXDLBLWK<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x99ED7C0", Offset = "0x99EC1C0", VA = "0x1899ED7C0", Slot = "5")]
		public override void ZNQOELICMYS(MKAVATDBMEI a, SHVULJFCHRU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x99ED850", Offset = "0x99EC250", VA = "0x1899ED850")]
		public EGUGHEDUJDI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[ConfigPropertyDrawer(typeof(int))]
	internal class MBRSVWBLJSV : GGKFXDLBLWK<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x99EFA60", Offset = "0x99EE460", VA = "0x1899EFA60", Slot = "5")]
		public override void ZNQOELICMYS(MKAVATDBMEI a, SHVULJFCHRU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x99EFAF0", Offset = "0x99EE4F0", VA = "0x1899EFAF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public JLJLQVTDNTM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x99EF140", Offset = "0x99EDB40", VA = "0x1899EF140")]
			internal float SORFJSPDOHW()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x99EF290", Offset = "0x99EDC90", VA = "0x1899EF290")]
			internal void SOWMGZJAXTF(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x99EF3B0", Offset = "0x99EDDB0", VA = "0x1899EF3B0")]
			internal float SPBTEGCYHEO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x99EF430", Offset = "0x99EDE30", VA = "0x1899EF430")]
			internal void SPHABMWVQPX(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x99EF000", Offset = "0x99EDA00", VA = "0x1899EF000")]
			internal float SNWDURNOCOM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x99EF080", Offset = "0x99EDA80", VA = "0x1899EF080")]
			internal void SOBKRYHLLZV(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x99EEEA0", Offset = "0x99ED8A0", VA = "0x1899EEEA0")]
			internal float OVFFMNDDGDG(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x99EEC40", Offset = "0x99ED640", VA = "0x1899EEC40")]
			internal void CBNTQGVFCWH(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x99EE3C0", Offset = "0x99ECDC0", VA = "0x1899EE3C0", Slot = "5")]
		public override void ZNQOELICMYS(MKAVATDBMEI a, SHVULJFCHRU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x99EE7C0", Offset = "0x99ED1C0", VA = "0x1899EE7C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public JLJLQVTDNTM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x99EF100", Offset = "0x99EDB00", VA = "0x1899EF100")]
			internal int SORFJSPDOHW()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x99EF240", Offset = "0x99EDC40", VA = "0x1899EF240")]
			internal void SOWMGZJAXTF(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x99F3230", Offset = "0x99F1C30", VA = "0x1899F3230", Slot = "5")]
		public override void ZNQOELICMYS(MKAVATDBMEI a, SHVULJFCHRU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x99F33C0", Offset = "0x99F1DC0", VA = "0x1899F33C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x99F3020", Offset = "0x99F1A20", VA = "0x1899F3020")]
		public static void YEVLRVSPAPF(Type a, Type b)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal struct CommonProperties
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x99EC3D0", Offset = "0x99EADD0", VA = "0x1899EC3D0")]
		public static NativeList<NetworkProperty> SQLHJMOTWSO(NativeObjectLocalIdArray a, EOZHHJLHPOL b)
		{
			return default(NativeList<NetworkProperty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x99EC2E0", Offset = "0x99EACE0", VA = "0x1899EC2E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x99F25C0", Offset = "0x99F0FC0", VA = "0x1899F25C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DPQVXPCEHFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x99F2880", Offset = "0x99F1280", VA = "0x1899F2880", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public RRObject RJLVWUHNMUB
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x99F2330", Offset = "0x99F0D30", VA = "0x1899F2330", Slot = "8")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Type MERZPCICCKQ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x99F2570", Offset = "0x99F0F70", VA = "0x1899F2570", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action CDOPCVYJTKY
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x99F27E0", Offset = "0x99F11E0", VA = "0x1899F27E0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x99F2620", Offset = "0x99F1020", VA = "0x1899F2620", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x99F2900", Offset = "0x99F1300", VA = "0x1899F2900")]
		public QBGAHIPJYZV(NativeObjectLocalIdArray a, NetworkProperty b, EOZHHJLHPOL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x99F2460", Offset = "0x99F0E60", VA = "0x1899F2460")]
		private void IDOSWYOTFIX(BulkPropertyChangeData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x99F2380", Offset = "0x99F0D80", VA = "0x1899F2380", Slot = "10")]
		public void Get(MutableRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x99F26C0", Offset = "0x99F10C0", VA = "0x1899F26C0", Slot = "11")]
		public void Set(ReadOnlyRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x99F2260", Offset = "0x99F0C60", VA = "0x1899F2260", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public JOXUKJQLBDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x99EF5A0", Offset = "0x99EDFA0", VA = "0x1899EF5A0")]
			internal bool SORFJSPDOHW()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x99EF5F0", Offset = "0x99EDFF0", VA = "0x1899EF5F0")]
			internal string SOWMGZJAXTF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x99EF670", Offset = "0x99EE070", VA = "0x1899EF670")]
			internal void SPBTEGCYHEO(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x99EF700", Offset = "0x99EE100", VA = "0x1899EF700")]
			internal string SPHABMWVQPX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NetworkProperty ZKCBLCFMUPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x99F3400", Offset = "0x99F1E00", VA = "0x1899F3400", Slot = "4")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x99F3470", Offset = "0x99F1E70", VA = "0x1899F3470", Slot = "5")]
		public void ZNQOELICMYS(MKAVATDBMEI a, SHVULJFCHRU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
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
		[Cpp2IlInjected.Address(RVA = "0x99EE2B0", Offset = "0x99ECCB0", VA = "0x1899EE2B0")]
		public ENLCFRPQECY(EOZHHJLHPOL a, SHVULJFCHRU b, Action<Candidate> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x99EDF70", Offset = "0x99EC970", VA = "0x1899EDF70")]
		public void ZYCKMDQZJWE(NativeList<Candidate> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x99EDE00", Offset = "0x99EC800", VA = "0x1899EDE00")]
		private void UWFGFSRUHFC(SHZEQMCKDZQ a, Candidate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x99ED890", Offset = "0x99EC290", VA = "0x1899ED890")]
		public void HWWGKGUMVFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x99ED8F0", Offset = "0x99EC2F0", VA = "0x1899ED8F0")]
		private void RIFXXBGIZFS(SHZEQMCKDZQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x99EDD60", Offset = "0x99EC760", VA = "0x1899EDD60")]
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
				[Cpp2IlInjected.Address(RVA = "0xDF0AD0", Offset = "0xDEF4D0", VA = "0x180DF0AD0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x99F2F40", Offset = "0x99F1940", VA = "0x1899F2F40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x15A0090", Offset = "0x159EA90", VA = "0x1815A0090")]
			[DebuggerHidden]
			public TQRQEUERSHP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x99F2BD0", Offset = "0x99F15D0", VA = "0x1899F2BD0", Slot = "7")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x99F2C60", Offset = "0x99F1660", VA = "0x1899F2C60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x99F2F90", Offset = "0x99F1990", VA = "0x1899F2F90")]
			private void SMVYKFBVGYB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x99F2FE0", Offset = "0x99F19E0", VA = "0x1899F2FE0", Slot = "10")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x99F2B20", Offset = "0x99F1520", VA = "0x1899F2B20", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NetworkProperty> BDUILHKOBAB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x99F2B20", Offset = "0x99F1520", VA = "0x1899F2B20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x99F03C0", Offset = "0x99EEDC0", VA = "0x1899F03C0")]
		public PropertiesByType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x99F02A0", Offset = "0x99EECA0", VA = "0x1899F02A0")]
		[IteratorStateMachine(typeof(TQRQEUERSHP))]
		public IEnumerable<NetworkProperty> ZXFRDMEKAQQ(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x99F01A0", Offset = "0x99EEBA0", VA = "0x1899F01A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x99F0220", Offset = "0x99EEC20", VA = "0x1899F0220")]
		private long MUXCFLLPBGX(NetworkProperty a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x99F01E0", Offset = "0x99EEBE0", VA = "0x1899F01E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x99F08D0", Offset = "0x99EF2D0", VA = "0x1899F08D0")]
		public PropertyBitmap(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x99F0740", Offset = "0x99EF140", VA = "0x1899F0740")]
		public static PropertyBitmap YGJVYGGCFCC(int a, NativeArray<NetworkProperty> b)
		{
			return default(PropertyBitmap);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x99F0720", Offset = "0x99EF120", VA = "0x1899F0720")]
		public bool IMNZGJHXCEM(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x99F0730", Offset = "0x99EF130", VA = "0x1899F0730")]
		public void Set(int index, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x99F05B0", Offset = "0x99EEFB0", VA = "0x1899F05B0")]
		public bool All(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x99F0660", Offset = "0x99EF060", VA = "0x1899F0660")]
		public bool Any(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x99F0710", Offset = "0x99EF110", VA = "0x1899F0710", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x99F1AF0", Offset = "0x99F04F0", VA = "0x1899F1AF0")]
		public PropertyDrawerCandidates(EOZHHJLHPOL configPropertyService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x99F0C40", Offset = "0x99EF640", VA = "0x1899F0C40")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x99F0FA0", Offset = "0x99EF9A0", VA = "0x1899F0FA0")]
		public void HGASXURPQOX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x99F1140", Offset = "0x99EFB40", VA = "0x1899F1140")]
		public NativeList<Candidate> LLRXWPKBAYC(NativeArray<NetworkProperty> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x99F1610", Offset = "0x99F0010", VA = "0x1899F1610")]
		private bool LXDSSVIWLYY(WVLQVSGKUXR a, PropertyBitmap b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3DF0680", Offset = "0x3DEF080", VA = "0x183DF0680")]
		private void JRMPCPIYGBH<b, a>(Action<b, a> a) where b : WVLQVSGKUXR where a : Attribute
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x99F1A30", Offset = "0x99F0430", VA = "0x1899F1A30")]
		private void YEHLWFFEPFT(Type a, Type b, Type c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3DF0310", Offset = "0x3DEED10", VA = "0x183DF0310")]
		private c FKYKXZTJROU<c>(Type a)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x99F1940", Offset = "0x99F0340", VA = "0x1899F1940")]
		private int QVSLPFNBDED(WVLQVSGKUXR a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x99F0D20", Offset = "0x99EF720", VA = "0x1899F0D20")]
		private void EVFKQUYTLNH(RPHTWOKRDAL a, ConfigPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x99F0920", Offset = "0x99EF320", VA = "0x1899F0920")]
		private void DMZCUWFUFWK(XPGWPJMKHOM a, MatchPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x99F1830", Offset = "0x99F0230", VA = "0x1899F1830")]
		private void PJAYMBJDLSW(VUANTBNNNPK a, MultiPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x99F1760", Offset = "0x99F0160", VA = "0x1899F1760")]
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
			[Cpp2IlInjected.Address(RVA = "0xF22E20", Offset = "0xF21820", VA = "0x180F22E20")]
			get
			{
				return default(NativeList<Candidate>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x99F2210", Offset = "0x99F0C10", VA = "0x1899F2210")]
		public PropertyShadowing(List<WVLQVSGKUXR> drawers, NativeArray<Candidate> candidates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x99F1F30", Offset = "0x99F0930", VA = "0x1899F1F30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x99F1C30", Offset = "0x99F0630", VA = "0x1899F1C30")]
		private NativeList<Candidate> AZUNSZTJAMQ(NativeArray<Candidate> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x99F1F70", Offset = "0x99F0970", VA = "0x1899F1F70")]
		private bool HZXYGDALIGV(WVLQVSGKUXR a, PropertyBitmap b, NetworkProperty c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x99F20E0", Offset = "0x99F0AE0", VA = "0x1899F20E0")]
		private void KITEEFIMJPC(WVLQVSGKUXR a, PropertyBitmap b, NetworkProperty c)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal struct SortCandidatesByPriority : IComparer<Candidate>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x99F2AC0", Offset = "0x99F14C0", VA = "0x1899F2AC0", Slot = "4")]
		public int Compare(Candidate a, Candidate b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x99F2AD0", Offset = "0x99F14D0", VA = "0x1899F2AD0")]
		public static void Sort(NativeList<Candidate> candidates)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SpecificPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x99F2B10", Offset = "0x99F1510", VA = "0x1899F2B10")]
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
