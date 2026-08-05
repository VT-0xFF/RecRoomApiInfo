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
		[Cpp2IlInjected.Address(RVA = "0x88D6280", Offset = "0x88D5280", VA = "0x1888D6280", Slot = "4")]
		public override void YTBQRMTMKZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		private int[] LHVPIFQWCCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset EVWCTMNURRO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xACFF90", Offset = "0xACEF90", VA = "0x180ACFF90", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x88DA640", Offset = "0x88D9640", VA = "0x1888DA640", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x88DA420", Offset = "0x88D9420", VA = "0x1888DA420")]
		private void SSAHAHAUBXG(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x88D9CB0", Offset = "0x88D8CB0", VA = "0x1888D9CB0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x88D9D10", Offset = "0x88D8D10", VA = "0x1888D9D10", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x88DA660", Offset = "0x88D9660", VA = "0x1888DA660")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal abstract class QQJHNIFRJHO : NYMTKFKVLPY<Enum>, RMDOCXORKCV, UUIECKTNJMI, QGGRIVBQKBS
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool YXKOOOHGTHY(Type a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x88D5E00", Offset = "0x88D4E00", VA = "0x1888D5E00")]
		protected QQJHNIFRJHO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal abstract class NYMTKFKVLPY<a> : UUIECKTNJMI, QGGRIVBQKBS where a : Enum
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class LCEQAKIHZSA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public ZRRKDDVGJPZ FAQIZUPYBAI;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public LCEQAKIHZSA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x55CD480", Offset = "0x55CC480", VA = "0x1855CD480")]
			internal bool PFMHOHHSWZV()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x41D74A0", Offset = "0x41D64A0", VA = "0x1841D74A0")]
		protected NYMTKFKVLPY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5B86FA0", Offset = "0x5B85FA0", VA = "0x185B86FA0")]
		protected void NNQTHIGZION(BQHCINEMXOQ a, ZRRKDDVGJPZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5B871A0", Offset = "0x5B861A0", VA = "0x185B871A0")]
		protected void SOGAJAGNLWX(JWUWXJGMMHV<a> a, ZRRKDDVGJPZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void ZTUHPUKQKOL(ZRRKDDVGJPZ a, VSZCXHPWLLH b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class VFTBGKFELTN : JAIQIMAFSZL, QGGRIVBQKBS
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public abstract NetworkProperty[] QBWFIUWEAZI
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public abstract NetworkProperty[] XHMBHZFJZVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void ZTUHPUKQKOL(ZRRKDDVGJPZ a, POTYTEUPGWE b, ELKILLTYSGW c, VSZCXHPWLLH d);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3F2AA10", Offset = "0x3F29A10", VA = "0x183F2AA10")]
		protected static b UUBNMEELTAD<b>(NativeObjectLocalIdArray a, NetworkProperty<b> b) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A820", Offset = "0x3F29820", VA = "0x183F2A820")]
		protected static void JACXUVKFVWK<d>(NativeObjectLocalIdArray a, NetworkProperty<d> b, d c) where d : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		protected VFTBGKFELTN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal abstract class ZNIWQDQVHTF<a> : UUIECKTNJMI, QGGRIVBQKBS where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class LCEQAKIHZSA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public ZRRKDDVGJPZ FAQIZUPYBAI;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public LCEQAKIHZSA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x55CD660", Offset = "0x55CC660", VA = "0x1855CD660")]
			internal bool PFMHOHHSWZV()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x41D74A0", Offset = "0x41D64A0", VA = "0x1841D74A0")]
		protected ZNIWQDQVHTF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x41D5470", Offset = "0x41D4470", VA = "0x1841D5470")]
		protected void NNQTHIGZION(BQHCINEMXOQ a, ZRRKDDVGJPZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x41D6CC0", Offset = "0x41D5CC0", VA = "0x1841D6CC0")]
		protected void SOGAJAGNLWX(JWUWXJGMMHV<a> a, ZRRKDDVGJPZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void ZTUHPUKQKOL(ZRRKDDVGJPZ a, VSZCXHPWLLH b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RegisterService(typeof(POTYTEUPGWE), new string[] { })]
	internal class ConfigUIService : POTYTEUPGWE, KTWSMBNSLGS, AXORFOQTGRK, OYGFOCCYTLG, LTOXHYHZXEQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[DependsOn]
		private ELKILLTYSGW CDISNXASLQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[DependsOn]
		private VSZCXHPWLLH MJISWMKOYSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private PropertyDrawerCandidates RKDLFISUKZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private NativeObjectLocalIdArray YUWCVXHWLNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private List<ZRRKDDVGJPZ> JCMDTSLUOZQ;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeObjectLocalIdArray ZFLFKBYJYIN
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x17D25E0", Offset = "0x17D15E0", VA = "0x1817D25E0", Slot = "5")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x88D2A90", Offset = "0x88D1A90", VA = "0x1888D2A90", Slot = "6")]
		public void InitExternal(GQPULEKOHTO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x88D27A0", Offset = "0x88D17A0", VA = "0x1888D27A0", Slot = "7")]
		public void EQRPTIUGSAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x88D2E20", Offset = "0x88D1E20", VA = "0x1888D2E20", Slot = "4")]
		public void USGTMBXFDBD(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x88D2730", Offset = "0x88D1730", VA = "0x1888D2730")]
		private void EQKAFYERVNN(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x88D28A0", Offset = "0x88D18A0", VA = "0x1888D28A0")]
		private void IDSWVUEPEMQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x88D3290", Offset = "0x88D2290", VA = "0x1888D3290")]
		private void ZTUHPUKQKOL(Candidate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x88D2DB0", Offset = "0x88D1DB0", VA = "0x1888D2DB0", Slot = "8")]
		private void SMUSGLXJIVI(GQPULEKOHTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x10EE0F0", Offset = "0x10ED0F0", VA = "0x1810EE0F0", Slot = "9")]
		private void CXZMGJMBDJU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x88D3660", Offset = "0x88D2660", VA = "0x1888D3660")]
		public ConfigUIService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[MatchPropertyDrawer(0)]
	internal class IXVEKQARGUM : QQJHNIFRJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x88D5D50", Offset = "0x88D4D50", VA = "0x1888D5D50", Slot = "5")]
		public override void ZTUHPUKQKOL(ZRRKDDVGJPZ a, VSZCXHPWLLH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x88D5CB0", Offset = "0x88D4CB0", VA = "0x1888D5CB0", Slot = "7")]
		public override bool YXKOOOHGTHY(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x88D5E00", Offset = "0x88D4E00", VA = "0x1888D5E00")]
		public IXVEKQARGUM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[MatchPropertyDrawer(0)]
	internal class ZSCIPWZWNIJ : QQJHNIFRJHO
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x88D9C00", Offset = "0x88D8C00", VA = "0x1888D9C00", Slot = "5")]
		public override void ZTUHPUKQKOL(ZRRKDDVGJPZ a, VSZCXHPWLLH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x88D9B60", Offset = "0x88D8B60", VA = "0x1888D9B60", Slot = "7")]
		public override bool YXKOOOHGTHY(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x88D5E00", Offset = "0x88D4E00", VA = "0x1888D5E00")]
		public ZSCIPWZWNIJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ConfigPropertyDrawer(typeof(RenderableColor), 1)]
	internal class IMHNEFDOFFS : NYMTKFKVLPY<RenderableColor>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x88D5B20", Offset = "0x88D4B20", VA = "0x1888D5B20", Slot = "5")]
		public override void ZTUHPUKQKOL(ZRRKDDVGJPZ a, VSZCXHPWLLH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x88D5C70", Offset = "0x88D4C70", VA = "0x1888D5C70")]
		public IMHNEFDOFFS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[MultiPropertyDrawer(2)]
	internal class VVMTLZLKSJK : VFTBGKFELTN
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class HTMXAPREZJT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public POTYTEUPGWE MUQMQSPZVTG;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public HTMXAPREZJT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x88D58B0", Offset = "0x88D48B0", VA = "0x1888D58B0")]
			internal (int, int) UEJUCLRBLSN()
			{
				return default((int, int));
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x88D5760", Offset = "0x88D4760", VA = "0x1888D5760")]
			internal void UEENFEXECHE((int color, int material) value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override NetworkProperty[] QBWFIUWEAZI
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override NetworkProperty[] XHMBHZFJZVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x88D9450", Offset = "0x88D8450", VA = "0x1888D9450", Slot = "9")]
		public override void ZTUHPUKQKOL(ZRRKDDVGJPZ a, POTYTEUPGWE b, ELKILLTYSGW c, VSZCXHPWLLH d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x88D9800", Offset = "0x88D8800", VA = "0x1888D9800")]
		public VVMTLZLKSJK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ConfigPropertyDrawer(typeof(bool))]
	internal class SZIIQCBIVNT : ZNIWQDQVHTF<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x88D87A0", Offset = "0x88D77A0", VA = "0x1888D87A0", Slot = "5")]
		public override void ZTUHPUKQKOL(ZRRKDDVGJPZ a, VSZCXHPWLLH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x88D8830", Offset = "0x88D7830", VA = "0x1888D8830")]
		public SZIIQCBIVNT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ConfigPropertyDrawer(typeof(FixedString32Bytes))]
	internal class ACCGTVZQKLL : ZNIWQDQVHTF<FixedString32Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class HPYOHBTXMAD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public ZRRKDDVGJPZ FAQIZUPYBAI;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public HPYOHBTXMAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x88D5700", Offset = "0x88D4700", VA = "0x1888D5700")]
			internal string UEJUCLRBLSN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x88D54C0", Offset = "0x88D44C0", VA = "0x1888D54C0")]
			internal void UEENFEXECHE(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x88D2120", Offset = "0x88D1120", VA = "0x1888D2120", Slot = "5")]
		public override void ZTUHPUKQKOL(ZRRKDDVGJPZ a, VSZCXHPWLLH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x88D22B0", Offset = "0x88D12B0", VA = "0x1888D22B0")]
		public ACCGTVZQKLL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ConfigPropertyDrawer(typeof(FixedString64Bytes))]
	internal class RFHMNHACPUK : ZNIWQDQVHTF<FixedString64Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class HPYOHBTXMAD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public ZRRKDDVGJPZ FAQIZUPYBAI;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public HPYOHBTXMAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x88D55C0", Offset = "0x88D45C0", VA = "0x1888D55C0")]
			internal string UEJUCLRBLSN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x88D5530", Offset = "0x88D4530", VA = "0x1888D5530")]
			internal void UEENFEXECHE(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x88D85D0", Offset = "0x88D75D0", VA = "0x1888D85D0", Slot = "5")]
		public override void ZTUHPUKQKOL(ZRRKDDVGJPZ a, VSZCXHPWLLH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x88D8760", Offset = "0x88D7760", VA = "0x1888D8760")]
		public RFHMNHACPUK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[ConfigPropertyDrawer(typeof(float3))]
	internal class LCNYEPAIEIS : ZNIWQDQVHTF<float3>
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class HPYOHBTXMAD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public ZRRKDDVGJPZ FAQIZUPYBAI;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public HPYOHBTXMAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x88D5680", Offset = "0x88D4680", VA = "0x1888D5680")]
			internal float UEJUCLRBLSN()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x88D54B0", Offset = "0x88D44B0", VA = "0x1888D54B0")]
			internal void UEENFEXECHE(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x88D53D0", Offset = "0x88D43D0", VA = "0x1888D53D0")]
			internal float UDZGHYDGSVV()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x88D53B0", Offset = "0x88D43B0", VA = "0x1888D53B0")]
			internal void UDTZKRJJJKM(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x88D5330", Offset = "0x88D4330", VA = "0x1888D5330")]
			internal float UDOSNKPLZZD()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x88D5310", Offset = "0x88D4310", VA = "0x1888D5310")]
			internal void UDJLQDVOQNU(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x88D5140", Offset = "0x88D4140", VA = "0x1888D5140")]
			internal float MHATCHDTAAS(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x88D4E00", Offset = "0x88D3E00", VA = "0x1888D4E00")]
			internal void AVCHULFGWMR(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x88D5E40", Offset = "0x88D4E40", VA = "0x1888D5E40", Slot = "5")]
		public override void ZTUHPUKQKOL(ZRRKDDVGJPZ a, VSZCXHPWLLH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x88D6240", Offset = "0x88D5240", VA = "0x1888D6240")]
		public LCNYEPAIEIS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ConfigPropertyDrawer(typeof(float))]
	internal class AUBSRBQJIPT : ZNIWQDQVHTF<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x88D22F0", Offset = "0x88D12F0", VA = "0x1888D22F0", Slot = "5")]
		public override void ZTUHPUKQKOL(ZRRKDDVGJPZ a, VSZCXHPWLLH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x88D2380", Offset = "0x88D1380", VA = "0x1888D2380")]
		public AUBSRBQJIPT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[ConfigPropertyDrawer(typeof(int))]
	internal class MHEUOGGOKAO : ZNIWQDQVHTF<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x88D6380", Offset = "0x88D5380", VA = "0x1888D6380", Slot = "5")]
		public override void ZTUHPUKQKOL(ZRRKDDVGJPZ a, VSZCXHPWLLH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x88D6410", Offset = "0x88D5410", VA = "0x1888D6410")]
		public MHEUOGGOKAO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[ConfigPropertyDrawer(typeof(quaternion))]
	internal class ETXBIMBBLMV : ZNIWQDQVHTF<quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class HPYOHBTXMAD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public ZRRKDDVGJPZ FAQIZUPYBAI;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public HPYOHBTXMAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x88D56F0", Offset = "0x88D46F0", VA = "0x1888D56F0")]
			internal float UEJUCLRBLSN()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x88D54A0", Offset = "0x88D44A0", VA = "0x1888D54A0")]
			internal void UEENFEXECHE(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x88D5440", Offset = "0x88D4440", VA = "0x1888D5440")]
			internal float UDZGHYDGSVV()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x88D53C0", Offset = "0x88D43C0", VA = "0x1888D53C0")]
			internal void UDTZKRJJJKM(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x88D53A0", Offset = "0x88D43A0", VA = "0x1888D53A0")]
			internal float UDOSNKPLZZD()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x88D5320", Offset = "0x88D4320", VA = "0x1888D5320")]
			internal void UDJLQDVOQNU(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x88D51B0", Offset = "0x88D41B0", VA = "0x1888D51B0")]
			internal float SQSJMRIMDNR(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x88D4EE0", Offset = "0x88D3EE0", VA = "0x1888D4EE0")]
			internal void JUJATHHYBNS(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x88D49C0", Offset = "0x88D39C0", VA = "0x1888D49C0", Slot = "5")]
		public override void ZTUHPUKQKOL(ZRRKDDVGJPZ a, VSZCXHPWLLH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x88D4DC0", Offset = "0x88D3DC0", VA = "0x1888D4DC0")]
		public ETXBIMBBLMV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[ConfigPropertyDrawer(typeof(uint))]
	internal class TAFFJTRKWCR : ZNIWQDQVHTF<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class HPYOHBTXMAD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public ZRRKDDVGJPZ FAQIZUPYBAI;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public HPYOHBTXMAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x88D5640", Offset = "0x88D4640", VA = "0x1888D5640")]
			internal int UEJUCLRBLSN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x88D5450", Offset = "0x88D4450", VA = "0x1888D5450")]
			internal void UEENFEXECHE(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x88D88D0", Offset = "0x88D78D0", VA = "0x1888D88D0", Slot = "5")]
		public override void ZTUHPUKQKOL(ZRRKDDVGJPZ a, VSZCXHPWLLH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x88D8A60", Offset = "0x88D7A60", VA = "0x1888D8A60")]
		public TAFFJTRKWCR()
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
	internal static class OEQPYOUWXLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x88D6450", Offset = "0x88D5450", VA = "0x1888D6450")]
		public static void XGWLXQKEWSC(Type a, Type b)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal struct CommonProperties
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x88D23C0", Offset = "0x88D13C0", VA = "0x1888D23C0")]
		public static NativeList<NetworkProperty> KXSDAQVBERL(NativeObjectLocalIdArray a, ELKILLTYSGW b)
		{
			return default(NativeList<NetworkProperty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x88D2640", Offset = "0x88D1640", VA = "0x1888D2640")]
		private static bool LWMERRDKUEE(NetworkProperty a, NativeObjectLocalIdArray b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class DRVUWIOZJMG : ZRRKDDVGJPZ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly NetworkProperty FAQIZUPYBAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly ELKILLTYSGW QUJOACNNQVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly NativeObjectLocalIdArray YUWCVXHWLNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool DWPOZTULXGS;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string LQPFQGKUSJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x88D3D20", Offset = "0x88D2D20", VA = "0x1888D3D20", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool EJURPCRDWBQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x88D3820", Offset = "0x88D2820", VA = "0x1888D3820", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public RRObject TGPJTOOCJDI
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x88D37D0", Offset = "0x88D27D0", VA = "0x1888D37D0", Slot = "8")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Type OVCFCLRZRCZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x88D36E0", Offset = "0x88D26E0", VA = "0x1888D36E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action IXKFENPOJVZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x88D3730", Offset = "0x88D2730", VA = "0x1888D3730", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x88D3A50", Offset = "0x88D2A50", VA = "0x1888D3A50", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x88D3D80", Offset = "0x88D2D80", VA = "0x1888D3D80")]
		public DRVUWIOZJMG(NativeObjectLocalIdArray a, NetworkProperty b, ELKILLTYSGW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x88D3AF0", Offset = "0x88D2AF0", VA = "0x1888D3AF0")]
		private void QDJXWFQNPOY(BulkPropertyChangeData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x88D3970", Offset = "0x88D2970", VA = "0x1888D3970", Slot = "10")]
		public void Get(MutableRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x88D3C00", Offset = "0x88D2C00", VA = "0x1888D3C00", Slot = "11")]
		public void Set(ReadOnlyRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x88D38A0", Offset = "0x88D28A0", VA = "0x1888D38A0", Slot = "12")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[SpecificPropertyDrawer(1)]
	internal sealed class UVNTSIQEPEL : IWEJYUOPTBO, UUIECKTNJMI, QGGRIVBQKBS
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class XDIBTWVITXT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public ZRRKDDVGJPZ FAQIZUPYBAI;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public XDIBTWVITXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x88D9B10", Offset = "0x88D8B10", VA = "0x1888D9B10")]
			internal bool UEJUCLRBLSN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x88D9A90", Offset = "0x88D8A90", VA = "0x1888D9A90")]
			internal string UEENFEXECHE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x88D9A00", Offset = "0x88D8A00", VA = "0x1888D9A00")]
			internal void UDZGHYDGSVV(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x88D9930", Offset = "0x88D8930", VA = "0x1888D9930")]
			internal string UDTZKRJJJKM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NetworkProperty JFAQWMBNHIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x88D8FB0", Offset = "0x88D7FB0", VA = "0x1888D8FB0", Slot = "4")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x88D9020", Offset = "0x88D8020", VA = "0x1888D9020", Slot = "5")]
		public void ZTUHPUKQKOL(ZRRKDDVGJPZ a, VSZCXHPWLLH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public UVNTSIQEPEL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class DVQOIRWIALZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly ELKILLTYSGW CDISNXASLQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly VSZCXHPWLLH BQNSWYKGTOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Action<Candidate> RACBZKIPTWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HashSet<XYLUYLLIXRZ> GUEMMVOXSIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly Dictionary<XYLUYLLIXRZ, List<Candidate>> FTDVVOAJHOH;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x88D48B0", Offset = "0x88D38B0", VA = "0x1888D48B0")]
		public DVQOIRWIALZ(ELKILLTYSGW a, VSZCXHPWLLH b, Action<Candidate> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x88D3E70", Offset = "0x88D2E70", VA = "0x1888D3E70")]
		public void MEFZFDBDXMN(NativeList<Candidate> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x88D42B0", Offset = "0x88D32B0", VA = "0x1888D42B0")]
		private void XVOSFHBKKLB(XYLUYLLIXRZ a, Candidate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x88D41B0", Offset = "0x88D31B0", VA = "0x1888D41B0")]
		public void QCHXRWQYDEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x88D4430", Offset = "0x88D3430", VA = "0x1888D4430")]
		private void YVVMTLLJEYT(XYLUYLLIXRZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x88D4210", Offset = "0x88D3210", VA = "0x1888D4210")]
		private void UZLZAEBYWHU(XYLUYLLIXRZ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class TFEDZEGGVDM : IEnumerable<NetworkProperty>, IEnumerable, IEnumerator<NetworkProperty>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private int WDQRLRKBTGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NetworkProperty IGHQXRUYHSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private int FMHFHEECSRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public PropertiesByType FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private Type DCVVHWLTKKV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Type VEKPHOEROVM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private NativeParallelMultiHashMap<long, int>.Enumerator WEJFWHVNYIV;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private NetworkProperty JMPREQZFKSJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xC5B060", Offset = "0xC5A060", VA = "0x180C5B060", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(NetworkProperty);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private object UQAIKHVHSEP
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x88D8F10", Offset = "0x88D7F10", VA = "0x1888D8F10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x16507C0", Offset = "0x164F7C0", VA = "0x1816507C0")]
			[DebuggerHidden]
			public TFEDZEGGVDM(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x88D8E80", Offset = "0x88D7E80", VA = "0x1888D8E80", Slot = "7")]
			[DebuggerHidden]
			private void PRJHWGPKORK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x88D8B90", Offset = "0x88D7B90", VA = "0x1888D8B90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x88D8F60", Offset = "0x88D7F60", VA = "0x1888D8F60")]
			private void ZLAPFDWYPLY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x88D8AA0", Offset = "0x88D7AA0", VA = "0x1888D8AA0", Slot = "10")]
			[DebuggerHidden]
			private void HJPFLPVTXYN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x88D8AE0", Offset = "0x88D7AE0", VA = "0x1888D8AE0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NetworkProperty> ZZPBUQIPVAO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x88D8AE0", Offset = "0x88D7AE0", VA = "0x1888D8AE0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator JZJZEHYLQOE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private NativeParallelMultiHashMap<long, int> WNKGUQAUTXL;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x88D6730", Offset = "0x88D5730", VA = "0x1888D6730")]
		public PropertiesByType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x88D6610", Offset = "0x88D5610", VA = "0x1888D6610")]
		[IteratorStateMachine(typeof(TFEDZEGGVDM))]
		public IEnumerable<NetworkProperty> TJUTROJYQZJ(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x88D6510", Offset = "0x88D5510", VA = "0x1888D6510", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x88D6590", Offset = "0x88D5590", VA = "0x1888D6590")]
		private long EUIRIDTPPQG(NetworkProperty a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x88D6550", Offset = "0x88D5550", VA = "0x1888D6550")]
		private long EUIRIDTPPQG(Type a)
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
		[Cpp2IlInjected.Address(RVA = "0x88D6C40", Offset = "0x88D5C40", VA = "0x1888D6C40")]
		public PropertyBitmap(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x88D6AA0", Offset = "0x88D5AA0", VA = "0x1888D6AA0")]
		public static PropertyBitmap LVRVWKZCTYV(int a, NativeArray<NetworkProperty> b)
		{
			return default(PropertyBitmap);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x88D6920", Offset = "0x88D5920", VA = "0x1888D6920")]
		public bool ATWZDUCDKPR(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x88D6C30", Offset = "0x88D5C30", VA = "0x1888D6C30")]
		public void Set(int index, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x88D6930", Offset = "0x88D5930", VA = "0x1888D6930")]
		public bool All(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x88D69E0", Offset = "0x88D59E0", VA = "0x1888D69E0")]
		public bool Any(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x88D6A90", Offset = "0x88D5A90", VA = "0x1888D6A90", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal class PropertyDrawerCandidates
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly ELKILLTYSGW CDISNXASLQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly List<QGGRIVBQKBS> MLYOZQVPEOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly PropertiesByType WNKGUQAUTXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private NativeParallelMultiHashMap<int, int> DNKDXHVNLQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private NativeList<int> APPKCQXABIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private bool DWPOZTULXGS;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public List<QGGRIVBQKBS> FKADMISZQZD
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x88D7E60", Offset = "0x88D6E60", VA = "0x1888D7E60")]
		public PropertyDrawerCandidates(ELKILLTYSGW configPropertyService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x88D6C90", Offset = "0x88D5C90", VA = "0x1888D6C90")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x88D7860", Offset = "0x88D6860", VA = "0x1888D7860")]
		public void VNVGDGEGUSA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x88D7390", Offset = "0x88D6390", VA = "0x1888D7390")]
		public NativeList<Candidate> VBVJYVTPGXP(NativeArray<NetworkProperty> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x88D7C80", Offset = "0x88D6C80", VA = "0x1888D7C80")]
		private bool ZFCBYORTEQH(QGGRIVBQKBS a, PropertyBitmap b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3C6CCC0", Offset = "0x3C6BCC0", VA = "0x183C6CCC0")]
		private void FFHXTEOJZDQ<b, a>(Action<b, a> a) where b : QGGRIVBQKBS where a : Attribute
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x88D7290", Offset = "0x88D6290", VA = "0x1888D7290")]
		private void SAUBXGJSOYQ(Type a, Type b, Type c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3C6CFD0", Offset = "0x3C6BFD0", VA = "0x183C6CFD0")]
		private c WXOLMDVMKDT<c>(Type a)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x88D6D70", Offset = "0x88D5D70", VA = "0x1888D6D70")]
		private int OEIWDVPHQPW(QGGRIVBQKBS a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x88D7A00", Offset = "0x88D6A00", VA = "0x1888D7A00")]
		private void YVEZDCKKZOA(UUIECKTNJMI a, ConfigPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x88D6E60", Offset = "0x88D5E60", VA = "0x1888D6E60")]
		private void QCBCZZPHEOR(RMDOCXORKCV a, MatchPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x88D7180", Offset = "0x88D6180", VA = "0x1888D7180")]
		private void QKCJXNKZCYB(JAIQIMAFSZL a, MultiPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x88D72C0", Offset = "0x88D62C0", VA = "0x1888D72C0")]
		private void SYLQFFXXEMA(IWEJYUOPTBO a, SpecificPropertyDrawer b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct PropertyShadowing : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<QGGRIVBQKBS> drawers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private NativeList<Candidate> unshadowed;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeList<Candidate> SNPWGRUUMNV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xC10060", Offset = "0xC0F060", VA = "0x180C10060")]
			get
			{
				return default(NativeList<Candidate>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x88D8580", Offset = "0x88D7580", VA = "0x1888D8580")]
		public PropertyShadowing(List<QGGRIVBQKBS> drawers, NativeArray<Candidate> candidates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x88D7FA0", Offset = "0x88D6FA0", VA = "0x1888D7FA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x88D8280", Offset = "0x88D7280", VA = "0x1888D8280")]
		private NativeList<Candidate> YJSJESBWVIL(NativeArray<Candidate> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x88D7FE0", Offset = "0x88D6FE0", VA = "0x1888D7FE0")]
		private bool KPNEAJMVSRS(QGGRIVBQKBS a, PropertyBitmap b, NetworkProperty c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x88D8150", Offset = "0x88D7150", VA = "0x1888D8150")]
		private void QSEXLUQFGXZ(QGGRIVBQKBS a, PropertyBitmap b, NetworkProperty c)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal struct SortCandidatesByPriority : IComparer<Candidate>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x88D8870", Offset = "0x88D7870", VA = "0x1888D8870", Slot = "4")]
		public int Compare(Candidate a, Candidate b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x88D8880", Offset = "0x88D7880", VA = "0x1888D8880")]
		public static void Sort(NativeList<Candidate> candidates)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SpecificPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x88D88C0", Offset = "0x88D78C0", VA = "0x1888D88C0")]
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
