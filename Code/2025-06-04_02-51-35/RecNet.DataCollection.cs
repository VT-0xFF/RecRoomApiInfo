using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x74BC0E0", Offset = "0x74BA8E0", VA = "0x1874BC0E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA536D0", Offset = "0xA51ED0", VA = "0x180A536D0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA53710", Offset = "0xA51F10", VA = "0x180A53710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecNet_DataCollection
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.Logging.Attributes.Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : HJMIPPBHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x74BA1D0", Offset = "0x74B89D0", VA = "0x1874BA1D0", Slot = "4")]
		public override void KELFLPPCOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecNet_DataCollection
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x74BC450", Offset = "0x74BAC50", VA = "0x1874BC450", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2731690", Offset = "0x272FE90", VA = "0x182731690")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface PFPLOJKJDFM
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> IKKHIGDOBNB();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LIJHDEIHDPM
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x74B9AB0", Offset = "0x74B82B0", VA = "0x1874B9AB0")]
	public static void ABLOCGBPNMA(this LNIJEOMEBOK.LFGHOPIMKAN MNHEAKBJHIL, string JJCBMHJMGKJ, string CELEJAMOJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x74B9C20", Offset = "0x74B8420", VA = "0x1874B9C20")]
	public static void ABLOCGBPNMA(this LNIJEOMEBOK.LFGHOPIMKAN MNHEAKBJHIL, string JJCBMHJMGKJ, bool CELEJAMOJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x74B9B20", Offset = "0x74B8320", VA = "0x1874B9B20")]
	public static void ABLOCGBPNMA(this LNIJEOMEBOK.LFGHOPIMKAN MNHEAKBJHIL, string JJCBMHJMGKJ, float MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x74B9760", Offset = "0x74B7F60", VA = "0x1874B9760")]
	public static void ABLOCGBPNMA(this LNIJEOMEBOK.LFGHOPIMKAN MNHEAKBJHIL, string JJCBMHJMGKJ, OCEBHKNJPBK CELEJAMOJIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LNIJEOMEBOK
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface AIDJMMKFBGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		LFGHOPIMKAN BBJDEGNMMAD(Guid IKOFEBOFHLE, string PNMLNPLMDKO, [Optional] string KFKLKBKKJIK, [Optional] long? KMODKOIGNHF, [Optional] string FBJHAGEDEEC, [Optional] string LBIJJDDDOBL);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class AAEELOCPOCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x74B24E0", Offset = "0x74B0CE0", VA = "0x1874B24E0")]
		public static LFGHOPIMKAN DMANAKPJFLJ(Guid IKOFEBOFHLE, string PNMLNPLMDKO, string KFKLKBKKJIK, [Optional] long? KMODKOIGNHF, [Optional] string FBJHAGEDEEC, [Optional] string LBIJJDDDOBL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class LFGHOPIMKAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected FPECCHFMCHH NPLHFNMEMBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly IDictionary<string, IDictionary<string, object>> MPJDBLNJNIF;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool BJLJAEGGPDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x74B8BB0", Offset = "0x74B73B0", VA = "0x1874B8BB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string OGLJJBBNDJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x115AC40", Offset = "0x1159440", VA = "0x18115AC40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x74B94E0", Offset = "0x74B7CE0", VA = "0x1874B94E0")]
		public LFGHOPIMKAN(FPECCHFMCHH NPLHFNMEMBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x74B9130", Offset = "0x74B7930", VA = "0x1874B9130")]
		public LFGHOPIMKAN JAJKIBAGLDP(string JMHMMNHPIAF, string MGONBEDEDON)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x74B8BF0", Offset = "0x74B73F0", VA = "0x1874B8BF0")]
		public LFGHOPIMKAN DBDNAOJIFGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x41293A0", Offset = "0x4127BA0", VA = "0x1841293A0")]
		public LFGHOPIMKAN JAJKIBAGLDP<T>(string JMHMMNHPIAF, T MGONBEDEDON) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x74B93D0", Offset = "0x74B7BD0", VA = "0x1874B93D0")]
		public LFGHOPIMKAN LHIHGBJFNII(string JMHMMNHPIAF, object MGONBEDEDON)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x41297D0", Offset = "0x4127FD0", VA = "0x1841297D0")]
		public LFGHOPIMKAN MKJLPDDBPBG<T>(string JMHMMNHPIAF, T? MGONBEDEDON) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x74B9450", Offset = "0x74B7C50", VA = "0x1874B9450")]
		public LFGHOPIMKAN MKJLPDDBPBG(string JMHMMNHPIAF, string MGONBEDEDON)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x74B9290", Offset = "0x74B7A90", VA = "0x1874B9290")]
		public LFGHOPIMKAN KNFJMAPGGEP(string HDMHKODPOEN, string MNMCNOJCKAF, object IMINNNCPCJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x74B91B0", Offset = "0x74B79B0", VA = "0x1874B91B0")]
		public LFGHOPIMKAN KNFJMAPGGEP(string HDMHKODPOEN, IDictionary<string, object> IDAPMLPCJOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x74B8B50", Offset = "0x74B7350", VA = "0x1874B8B50")]
		private static IDictionary<string, object> BMIEEJOPJLE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x74B8D80", Offset = "0x74B7580", VA = "0x1874B8D80")]
		public void EJMPLIHONII(bool JBONLPDNGJG, string OGMBKMPFCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x74B9030", Offset = "0x74B7830", VA = "0x1874B9030")]
		public Task HKDNODECKFI([Optional] CancellationToken GMEAHOBHMAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2866F70", Offset = "0x2865770", VA = "0x182866F70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class FPECCHFMCHH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct MAAICMNLAAD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public FPECCHFMCHH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x74BA260", Offset = "0x74B8A60", VA = "0x1874BA260", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x74BA6D0", Offset = "0x74B8ED0", VA = "0x1874BA6D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static Action<FPECCHFMCHH> KPBPOEHOGHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly string NPMOFMALGKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<string, object> OLGGGIFMLEJ;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string OGLJJBBNDJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x74B5F80", Offset = "0x74B4780", VA = "0x1874B5F80")]
		private FPECCHFMCHH(string NPMOFMALGKG, int DJKBOHPOLAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x74B5DA0", Offset = "0x74B45A0", VA = "0x1874B5DA0")]
		public static LFGHOPIMKAN INHDMBAMCNE(string NPMOFMALGKG, int DJKBOHPOLAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x74B5CB0", Offset = "0x74B44B0", VA = "0x1874B5CB0")]
		[AsyncStateMachine(typeof(MAAICMNLAAD))]
		public Task HKDNODECKFI([Optional] CancellationToken GMEAHOBHMAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x74B5F10", Offset = "0x74B4710", VA = "0x1874B5F10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x37F6CB0", Offset = "0x37F54B0", VA = "0x1837F6CB0")]
		internal void MNEJLPLOOCN<T>(string JMHMMNHPIAF, T MGONBEDEDON) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x74B5C50", Offset = "0x74B4450", VA = "0x1874B5C50")]
		internal void HIJDKFDJGKF(string JMHMMNHPIAF, object MGONBEDEDON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x74B5EB0", Offset = "0x74B46B0", VA = "0x1874B5EB0")]
		internal void MNEJLPLOOCN(string JMHMMNHPIAF, string MGONBEDEDON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4125540", Offset = "0x4123D40", VA = "0x184125540")]
		private void LEIFIDKIDIO<T>(string JMHMMNHPIAF, T MGONBEDEDON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct BMHLGCLOJJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string NFPEMBKAKFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly long? OKEIHPDKJML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly short? LKFFNDGKEDI;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x74B41E0", Offset = "0x74B29E0", VA = "0x1874B41E0")]
		public BMHLGCLOJJA(string NKELFEBGOAD, [Optional] long? GFHIJAKOMMI, [Optional] short? MHEKHDBLOOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct KIEEGIANJML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly int NBJINJLFNAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly string EOBCJOLMGON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly short PGABEMNHPLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly string JPNFLCKPEFP;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x74B7DF0", Offset = "0x74B65F0", VA = "0x1874B7DF0")]
		public KIEEGIANJML(int ECMDDHHCHGE, string DOFGDBNJCGO, short CNBMAPNLADC, string FDBNLFPILEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class NPPMHHLFMIB : PIGCKPFCLBM<HFMOHHMFEIE, KIEEGIANJML, BMHLGCLOJJA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string DOFGDBNJCGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private short CNBMAPNLADC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private string FDBNLFPILEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Dictionary<short, int> HKOFKGHCPOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int JKGMLJCFNPM;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x74BC060", Offset = "0x74BA860", VA = "0x1874BC060")]
		public NPPMHHLFMIB(string NLIBKHEBHGC, Guid PFFPGNDFPCC, long FDPEGNNFILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x74BBD70", Offset = "0x74BA570", VA = "0x1874BBD70", Slot = "4")]
		public override void PFKMELAMIJD(KIEEGIANJML KONIGDCHDJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x74BBC90", Offset = "0x74BA490", VA = "0x1874BBC90")]
		public void LKCKHDNGPLE(short CNBMAPNLADC, bool MPNOGGGOLJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4B91970", Offset = "0x4B90170", VA = "0x184B91970")]
		public void NLBDPINKOAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA274A0", Offset = "0xA25CA0", VA = "0x180A274A0")]
		public void NJFMOMJLGLH(string EINELFOPHDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x74BAEB0", Offset = "0x74B96B0", VA = "0x1874BAEB0", Slot = "5")]
		public override void DCLEACIILGD(bool EEAPPKPBLLH, BMHLGCLOJJA MHDLFFNBMPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x74BAC00", Offset = "0x74B9400", VA = "0x1874BAC00", Slot = "6")]
		public override HGPEILDNCGK ADBHBCHNGDO(HFMOHHMFEIE MFPBNNKDHLH, int PNJCJGEIDHG, string EGIBFICHIPJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class DDEDCLGGLLN : HGPEILDNCGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private string DOFGDBNJCGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly short CNBMAPNLADC;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x74B4920", Offset = "0x74B3120", VA = "0x1874B4920")]
		public DDEDCLGGLLN(long OLOLBHBJOCA, int ECMDDHHCHGE, string KFKLKBKKJIK, long FDPEGNNFILM, int HACNGBCKPBL, string FBJHAGEDEEC, short CNBMAPNLADC, string DOFGDBNJCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x74B48A0", Offset = "0x74B30A0", VA = "0x1874B48A0")]
		public void FDHLIHKPAEA(int ECMDDHHCHGE, string DOFGDBNJCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x74B4770", Offset = "0x74B2F70", VA = "0x1874B4770", Slot = "5")]
		public override LFGHOPIMKAN BBJDEGNMMAD(Guid IKOFEBOFHLE, string PNMLNPLMDKO, [Optional] string KFKLKBKKJIK, [Optional] long? KMODKOIGNHF, [Optional] string FBJHAGEDEEC, [Optional] string LBIJJDDDOBL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class DNBHMHHAOBG
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class GBCJMKAFOGM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float nextEventSendTime;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public GBCJMKAFOGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x74B62C0", Offset = "0x74B4AC0", VA = "0x1874B62C0")]
			internal bool HBDLLIJNELN()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct KODMMGCPHAJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private GBCJMKAFOGM <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TimeSpan <delayPollingInterval>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x74B7E40", Offset = "0x74B6640", VA = "0x1874B7E40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x74B8AF0", Offset = "0x74B72F0", VA = "0x1874B8AF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct IPBLKPOBKGL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public bool isForcedEvent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x74B6B10", Offset = "0x74B5310", VA = "0x1874B6B10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x74B7090", Offset = "0x74B5890", VA = "0x1874B7090", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly float EHLLLFGPMBA;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static OPHBELKNMNO NJNLAMHGMGI;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static CancellationTokenSource GLGIDONAOHL;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static bool HADCKHAOKNO;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static int DEDMOGBLIHH;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly EGCONEOAIAE<LFGHOPIMKAN, bool> BIGEFLJBEGB;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static JPPPCFILKBD<LFGHOPIMKAN, bool> FFEBDKMHHGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x74B4A10", Offset = "0x74B3210", VA = "0x1874B4A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static bool HBNCGCOKHIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x74B4DD0", Offset = "0x74B35D0", VA = "0x1874B4DD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x74B4E20", Offset = "0x74B3620", VA = "0x1874B4E20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private static bool CDNMNIHFGON
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x74B4C40", Offset = "0x74B3440", VA = "0x1874B4C40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x74B4BE0", Offset = "0x74B33E0", VA = "0x1874B4BE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private static float LOPJGAFKJPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x74B5B10", Offset = "0x74B4310", VA = "0x1874B5B10")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x74B4C90", Offset = "0x74B3490", VA = "0x1874B4C90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x74B4A60", Offset = "0x74B3260", VA = "0x1874B4A60")]
		[BDPIALLOKEK.JMECHJEFJFC]
		internal static void BIMBGMEACEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x74B4E80", Offset = "0x74B3680", VA = "0x1874B4E80")]
		internal static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x74B5890", Offset = "0x74B4090", VA = "0x1874B5890")]
		internal static void PBPOAHLKNMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x74B4B80", Offset = "0x74B3380", VA = "0x1874B4B80")]
		internal static void BJGCJIMJEAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x74B5490", Offset = "0x74B3C90", VA = "0x1874B5490")]
		public static void KGGGBKNNMHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x74B5060", Offset = "0x74B3860", VA = "0x1874B5060")]
		private static void JBGDBEFFIIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x74B54E0", Offset = "0x74B3CE0", VA = "0x1874B54E0")]
		private static void MDAMGBIIDDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x74B5A40", Offset = "0x74B4240", VA = "0x1874B5A40")]
		[AsyncStateMachine(typeof(KODMMGCPHAJ))]
		private static Task PFPEJGGJEMN(CancellationToken GMEAHOBHMAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x74B57C0", Offset = "0x74B3FC0", VA = "0x1874B57C0")]
		private static void OKPAHJNOHCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x74B4CF0", Offset = "0x74B34F0", VA = "0x1874B4CF0")]
		[AsyncStateMachine(typeof(IPBLKPOBKGL))]
		private static Task ENJGJEHOHOP(bool GJPMNBBBGGF, [Optional] CancellationToken GMEAHOBHMAD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class LAMMJAKMCLB<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class JBHMGAALHBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public LAMMJAKMCLB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public JBHMGAALHBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x50872C0", Offset = "0x5085AC0", VA = "0x1850872C0")]
			internal object DBKBHFOHHAN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class KOIHJBEAOFH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public LAMMJAKMCLB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public KOIHJBEAOFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x51CAD80", Offset = "0x51C9580", VA = "0x1851CAD80")]
			internal object GPIFDBIDDKP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class FIHDKHKEMGF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public LAMMJAKMCLB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public FIHDKHKEMGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x4BAD980", Offset = "0x4BAC180", VA = "0x184BAD980")]
			internal object BEEODACDIEA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class DKOFMFFCNFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public LAMMJAKMCLB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public DKOFMFFCNFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6D53C30", Offset = "0x6D52430", VA = "0x186D53C30")]
			internal object GEONACDHIJM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class ILCBLJCMNLJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public LAMMJAKMCLB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public ILCBLJCMNLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x4E8AF50", Offset = "0x4E89750", VA = "0x184E8AF50")]
			internal object EEHGGBBPIMD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class KGKMOFHBNJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public LAMMJAKMCLB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public KGKMOFHBNJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x51AEDE0", Offset = "0x51AD5E0", VA = "0x1851AEDE0")]
			internal object DMEJGLIGCHP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class EAHJBGFFNBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public LAMMJAKMCLB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public EAHJBGFFNBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x4698550", Offset = "0x4696D50", VA = "0x184698550")]
			internal object CDKLAMPKCKE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const float IJIEHOPNFGB = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Guid IKOFEBOFHLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly Guid PCFPKKHNGJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly string FBJHAGEDEEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string NAHOGPMIEMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private string NNKBDNOHCBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private string LBIJJDDDOBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private string HAALNCPKLIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private string MKIDEGAGFJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private string NEPOKFOBFMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private string FLBLNGIHPEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private string GJDJHDAOFHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private string BPMGKPFJEGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private string GGGKDEIJHFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Guid? MMKIGEELPHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private (int, int)? GGNLGAJCNHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly HashSet<T> DBNOJNHHFAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Dictionary<(T, int), string> AEKNFFECFPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Dictionary<(T, int), float> DKGHHDFALKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Dictionary<T, string> ELALFJHEKHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly Dictionary<T, string> PKHFPBAIFAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<T, string> KLOLMBBFJHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly Dictionary<T, string[]> GEBONGGPHCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private string FGCNJPEFIPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool KNOFLGDEGHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private Task HDEIEOGMCJA;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x525C7E0", Offset = "0x525AFE0", VA = "0x18525C7E0")]
		public LAMMJAKMCLB(Guid IKOFEBOFHLE, Guid PCFPKKHNGJG, string NAHOGPMIEMO, string FBJHAGEDEEC, string NNKBDNOHCBH, [Optional] string LBIJJDDDOBL, [Optional] string HAALNCPKLIG, [Optional] string MKIDEGAGFJJ, [Optional] string GJDJHDAOFHM, [Optional] string FGCNJPEFIPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA2D480", Offset = "0xA2BC80", VA = "0x180A2D480")]
		public void EHNKFLHLFFH(string LBIJJDDDOBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4F0", Offset = "0xA2BCF0", VA = "0x180A2D4F0")]
		public void HCHBGNHJJJD(string NNKBDNOHCBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xAA6F40", Offset = "0xAA5740", VA = "0x180AA6F40")]
		public void BGNLJAKHIFF(string FGCNJPEFIPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA274E0", Offset = "0xA25CE0", VA = "0x180A274E0")]
		public void GEKOGGKFJFC(string NEPOKFOBFMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA35000", Offset = "0xA33800", VA = "0x180A35000")]
		public void NCFIMPBLJNB(string BPMGKPFJEGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA35060", Offset = "0xA33860", VA = "0x180A35060")]
		public void BILHGKMLPCN(string GGGKDEIJHFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x525C0E0", Offset = "0x525A8E0", VA = "0x18525C0E0")]
		public void NDMLHDNOCKN(Guid? IKOFEBOFHLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x17BDC70", Offset = "0x17BC470", VA = "0x1817BDC70")]
		public void EMOIHIFOLOI((int, int)? GGNLGAJCNHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA274A0", Offset = "0xA25CA0", VA = "0x180A274A0")]
		public void IMBCCJKANDH(string FLBLNGIHPEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x52540C0", Offset = "0x52528C0", VA = "0x1852540C0")]
		public void BLONIAKEFOO(T KMODKOIGNHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x525BD90", Offset = "0x525A590", VA = "0x18525BD90")]
		public void KBICLCLEOLB(T KMODKOIGNHF, int JMPOCCMFCDD, float EMFFCDLDJIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5255720", Offset = "0x5253F20", VA = "0x185255720")]
		public void DOGNNHFDDBE(T KMODKOIGNHF, int JMPOCCMFCDD, string IBIMJKBEIAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5257570", Offset = "0x5255D70", VA = "0x185257570")]
		public void FINJJKOIEIN(T KMODKOIGNHF, string LKMLCPCAOND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x52551F0", Offset = "0x52539F0", VA = "0x1852551F0")]
		public void DHPCPGJPNGH(T KMODKOIGNHF, string JNOBCKGJHDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5257C60", Offset = "0x5256460", VA = "0x185257C60")]
		public void HANHFHELGMI(T KMODKOIGNHF, bool OFEBOMIDNJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x525C620", Offset = "0x525AE20", VA = "0x18525C620")]
		public void OCNKLDDNKLF(T KMODKOIGNHF, string[] JBOGMCOFFEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x525A550", Offset = "0x5258D50", VA = "0x18525A550")]
		public Task HKDNODECKFI(bool IBCIAMDAPFE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x52560D0", Offset = "0x52548D0", VA = "0x1852560D0")]
		private (IEnumerable<T>, string) ENEJNEDJIFM()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5254400", Offset = "0x5252C00", VA = "0x185254400")]
		public static LFGHOPIMKAN CJNKMEEBFLA(Guid IKOFEBOFHLE, Guid PCFPKKHNGJG, string NAHOGPMIEMO, T KMODKOIGNHF, string FBJHAGEDEEC, string FCBMJIBBHCI, string LBIJJDDDOBL, int? PNJCJGEIDHG, [Optional] string FNINOJBGFAD, [Optional] string LKMLCPCAOND, [Optional] int? PJLLOOMENOH, [Optional] Guid? MMKIGEELPHK, [Optional] string FGCNJPEFIPP, [Optional] string KFKLKBKKJIK, [Optional] (int, int)? GGNLGAJCNHO, [Optional] string CKPBFDBENDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x525C100", Offset = "0x525A900", VA = "0x18525C100")]
		[CompilerGenerated]
		private string NGLPKKPGMLP(T EBHOIBHGECB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5256040", Offset = "0x5254840", VA = "0x185256040")]
		[CompilerGenerated]
		private string EKOHMFKDDMF(T EBHOIBHGECB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5258020", Offset = "0x5256820", VA = "0x185258020")]
		[CompilerGenerated]
		private string HHNOPPNJAKD(T EBHOIBHGECB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5257A00", Offset = "0x5256200", VA = "0x185257A00")]
		[CompilerGenerated]
		private string GNPDFAPMAEG(T EBHOIBHGECB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public abstract class PIGCKPFCLBM<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		protected readonly string NLIBKHEBHGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		protected readonly Guid PFFPGNDFPCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		protected readonly long FDPEGNNFILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		protected int ECMDDHHCHGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		protected int JEOPANFDCPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		protected DateTime HOGKEGBLADC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		protected bool HCDACDNIHAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		protected Dictionary<long, HGPEILDNCGK> HFEMLJAFPDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		protected bool DBOICFJMPPB;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool ALIOKCOAJKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xC9B990", Offset = "0xC9A190", VA = "0x180C9B990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HIAJFCOJKOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xCDDF70", Offset = "0xCDC770", VA = "0x180CDDF70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x58ACE80", Offset = "0x58AB680", VA = "0x1858ACE80")]
		public PIGCKPFCLBM(string NLIBKHEBHGC, Guid PFFPGNDFPCC, long FDPEGNNFILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void PFKMELAMIJD(TListSessionStartParams KONIGDCHDJE);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5551EB0", Offset = "0x55506B0", VA = "0x185551EB0")]
		public void GMEINFKHLKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void DCLEACIILGD(bool EEAPPKPBLLH, TListSessionLogParams MHDLFFNBMPM);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x58ACD60", Offset = "0x58AB560", VA = "0x1858ACD60")]
		public void PHALLHLENAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x58ACC40", Offset = "0x58AB440", VA = "0x1858ACC40")]
		public void JGDNFNFBEGP(long OLOLBHBJOCA, int PNJCJGEIDHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x58ACA50", Offset = "0x58AB250", VA = "0x1858ACA50")]
		public void IKHOMCDCLDI(long OLOLBHBJOCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract HGPEILDNCGK ADBHBCHNGDO(TItem NAGJHHJDFPB, int PNJCJGEIDHG, string EGIBFICHIPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class HGPEILDNCGK : AIDJMMKFBGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private int ECMDDHHCHGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private long OLOLBHBJOCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private long FDPEGNNFILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly string JGOBMBOKGOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly string OOINPJECPGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly int HACNGBCKPBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private DateTime GKKOJBNMEAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private double OGEGMPPFIEJ;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool OLOLMNINDDG
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xECB7B0", Offset = "0xEC9FB0", VA = "0x180ECB7B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xECB110", Offset = "0xEC9910", VA = "0x180ECB110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x74B6A40", Offset = "0x74B5240", VA = "0x1874B6A40")]
		public HGPEILDNCGK(long OLOLBHBJOCA, int ECMDDHHCHGE, string KFKLKBKKJIK, long FDPEGNNFILM, int HACNGBCKPBL, [Optional] string FBJHAGEDEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x74B6980", Offset = "0x74B5180", VA = "0x1874B6980")]
		public void ONACMPOIANJ(int ECMDDHHCHGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x74B69F0", Offset = "0x74B51F0", VA = "0x1874B69F0")]
		public void OOIEBKGFBPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x74B6870", Offset = "0x74B5070", VA = "0x1874B6870")]
		public void JCJGHLMJIGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x74B6810", Offset = "0x74B5010", VA = "0x1874B6810")]
		private void FPDKEHOHGPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x74B6360", Offset = "0x74B4B60", VA = "0x1874B6360", Slot = "5")]
		public virtual LFGHOPIMKAN BBJDEGNMMAD(Guid IKOFEBOFHLE, string PNMLNPLMDKO, [Optional] string KFKLKBKKJIK, [Optional] long? KMODKOIGNHF, [Optional] string FBJHAGEDEEC, [Optional] string LBIJJDDDOBL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class APBEOFONIBO
	{
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static Dictionary<string, Dictionary<string, object>> PFDKMDJNEMJ;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static string KKMJKKDALJN;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static int NLBLNIHGPNK;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly Dictionary<string, PFPLOJKJDFM> PJEOHGMKECL;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static string DNNDKPHADKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x74B39E0", Offset = "0x74B21E0", VA = "0x1874B39E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x74B2F10", Offset = "0x74B1710", VA = "0x1874B2F10")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool GKIKDJGFLFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x74B2970", Offset = "0x74B1170", VA = "0x1874B2970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static Dictionary<string, Dictionary<string, object>> KABHDLMPLMD
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x74B34F0", Offset = "0x74B1CF0", VA = "0x1874B34F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static Guid? FNPNCDGMCCL
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x74B3650", Offset = "0x74B1E50", VA = "0x1874B3650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x74B2A00", Offset = "0x74B1200", VA = "0x1874B2A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static Guid? DKJKLDHJMGM
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x74B3490", Offset = "0x74B1C90", VA = "0x1874B3490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x74B2A60", Offset = "0x74B1260", VA = "0x1874B2A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x74B36B0", Offset = "0x74B1EB0", VA = "0x1874B36B0")]
		public static void MIGPELJINMG(string DOELNINFNCA, PFPLOJKJDFM EDNDOIGIIBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x74B2FC0", Offset = "0x74B17C0", VA = "0x1874B2FC0")]
		internal static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x74B3900", Offset = "0x74B2100", VA = "0x1874B3900")]
		internal static void PBPOAHLKNMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x74B28F0", Offset = "0x74B10F0", VA = "0x1874B28F0")]
		internal static void BJGCJIMJEAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x74B3A30", Offset = "0x74B2230", VA = "0x1874B3A30")]
		public static Guid PFKMELAMIJD(string DOELNINFNCA, [Optional] string? BIAPJGIFNAF, [Optional] Dictionary<string, object>? IKIFBMGKPKI)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x74B4000", Offset = "0x74B2800", VA = "0x1874B4000")]
		public static Guid PFKMELAMIJD(string DOELNINFNCA, long BIAPJGIFNAF, [Optional] Dictionary<string, object>? IKIFBMGKPKI)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x74B2CB0", Offset = "0x74B14B0", VA = "0x1874B2CB0")]
		public static void GMEINFKHLKK(string DOELNINFNCA, [Optional] Guid? JMHOEKKPCPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x74B26F0", Offset = "0x74B0EF0", VA = "0x1874B26F0")]
		public static void BHKKMHCNKOI(string DOELNINFNCA, string HDMHKODPOEN, object BKJEDGDKHEM, bool HADCKHAOKNO = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x74B2AC0", Offset = "0x74B12C0", VA = "0x1874B2AC0")]
		public static bool FPGCMBPILMM(string DOELNINFNCA, [Optional] string? BIAPJGIFNAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x74B3790", Offset = "0x74B1F90", VA = "0x1874B3790")]
		private static void PAFGIGJBIGE(bool FCDGPFNCPEP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x74B3740", Offset = "0x74B1F40", VA = "0x1874B3740")]
		public static void NMJPGONHAOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x74B3540", Offset = "0x74B1D40", VA = "0x1874B3540")]
		private static void MDAMGBIIDDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x74B30A0", Offset = "0x74B18A0", VA = "0x1874B30A0")]
		private static void INDNJAELPLO(string DOELNINFNCA, Guid IKOFEBOFHLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class MOOBJLAFNPN
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public struct MKMNDIBIFAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public bool PEFHAHJOKNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public string NCIJEBLFGJP;

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xC9CE00", Offset = "0xC9B600", VA = "0x180C9CE00")]
			public MKMNDIBIFAK(bool PEFHAHJOKNH, string NCIJEBLFGJP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x74BA730", Offset = "0x74B8F30", VA = "0x1874BA730")]
		public static MKMNDIBIFAK MIHGFEDHECA(LFGHOPIMKAN MNHEAKBJHIL)
		{
			return default(MKMNDIBIFAK);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x74BAA40", Offset = "0x74B9240", VA = "0x1874BAA40")]
		private static void NOJFJDFKOML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x74BAB40", Offset = "0x74B9340", VA = "0x1874BAB40")]
		private static void ODJLHMOEJAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class JGGEIHGLPHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x74B70F0", Offset = "0x74B58F0", VA = "0x1874B70F0")]
		public static LFGHOPIMKAN FBODDCFECJG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class JLBGKOLHBMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x74B7390", Offset = "0x74B5B90", VA = "0x1874B7390")]
		public static LFGHOPIMKAN JOCAELJNJCH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x74B7630", Offset = "0x74B5E30", VA = "0x1874B7630")]
		public static LFGHOPIMKAN PKONAKGCPBI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x74B7210", Offset = "0x74B5A10", VA = "0x1874B7210")]
		public static LFGHOPIMKAN COGFHFOKFDC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x74B72D0", Offset = "0x74B5AD0", VA = "0x1874B72D0")]
		public static LFGHOPIMKAN HHDCFMGPFOF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x74B7150", Offset = "0x74B5950", VA = "0x1874B7150")]
		public static LFGHOPIMKAN AEALLBOKEOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x74B7330", Offset = "0x74B5B30", VA = "0x1874B7330")]
		public static LFGHOPIMKAN HIGONLAGAMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x74B71B0", Offset = "0x74B59B0", VA = "0x1874B71B0")]
		public static LFGHOPIMKAN BKNIAGBBLCG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x74B7510", Offset = "0x74B5D10", VA = "0x1874B7510")]
		public static LFGHOPIMKAN KKBNGOHPPHJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x74B7570", Offset = "0x74B5D70", VA = "0x1874B7570")]
		public static LFGHOPIMKAN LPEIMILDFCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x74B75D0", Offset = "0x74B5DD0", VA = "0x1874B75D0")]
		public static LFGHOPIMKAN NMLEIKBCKHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x74B7270", Offset = "0x74B5A70", VA = "0x1874B7270")]
		public static LFGHOPIMKAN EBOGGNOOPEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x74B7690", Offset = "0x74B5E90", VA = "0x1874B7690")]
		public static LFGHOPIMKAN PLKDPDODHAI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x74B73F0", Offset = "0x74B5BF0", VA = "0x1874B73F0")]
		public static LFGHOPIMKAN KFAPFPJENMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x74B74B0", Offset = "0x74B5CB0", VA = "0x1874B74B0")]
		public static LFGHOPIMKAN KGEBNMHJCGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x74B7450", Offset = "0x74B5C50", VA = "0x1874B7450")]
		public static LFGHOPIMKAN KFJAAFHEIFD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class LGBIGAIDLDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x74B9580", Offset = "0x74B7D80", VA = "0x1874B9580")]
		public static LFGHOPIMKAN JIBHEAACFBK(long GFHIJAKOMMI, long PALELGDJJCI, bool LKIKIGDBCCA, string CLFJCMKAJHA, string CJJKADGELDN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class BOOLKKDLJKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x74B44D0", Offset = "0x74B2CD0", VA = "0x1874B44D0")]
		public static LFGHOPIMKAN JOOCDGLJKBF(string ECONFHHJHPD, string IPOCKHOEENL, bool LLJLOGIKFDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x74B4220", Offset = "0x74B2A20", VA = "0x1874B4220")]
		public static LFGHOPIMKAN FEOBOPHGBON(Guid PCFPKKHNGJG, string MJAGIMDGJBK, string ANEMALBCADB, string CBPECEFHPHA, [Optional] int? EDHCNPCAHOA, [Optional] double[] DAJCLHMFLEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x74B4640", Offset = "0x74B2E40", VA = "0x1874B4640")]
		public static LFGHOPIMKAN PHLGPMFEBJI(Guid PCFPKKHNGJG, Guid JLLBIPCACGB, bool FILCILBNHNE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class JLDIJODNOCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x74B76F0", Offset = "0x74B5EF0", VA = "0x1874B76F0")]
		public static LFGHOPIMKAN BEICBJJDHIP(string BJBFBHHPFEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x74B7C50", Offset = "0x74B6450", VA = "0x1874B7C50")]
		public static LFGHOPIMKAN KABHPOEJNLP(string EEKMBPCOBHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x74B7D30", Offset = "0x74B6530", VA = "0x1874B7D30")]
		public static LFGHOPIMKAN NBANCPINCOO(int DJKBOHPOLAF, string HPANEBBHGAC, string EBHOIBHGECB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x74B7D90", Offset = "0x74B6590", VA = "0x1874B7D90")]
		public static LFGHOPIMKAN PEIJCHGNLKN(int DJKBOHPOLAF, string HPANEBBHGAC, string EBHOIBHGECB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x74B77D0", Offset = "0x74B5FD0", VA = "0x1874B77D0")]
		public static LFGHOPIMKAN CDNJKFDJOIL(int DJKBOHPOLAF, string HPANEBBHGAC, string EBHOIBHGECB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x74B7980", Offset = "0x74B6180", VA = "0x1874B7980")]
		public static LFGHOPIMKAN FGPIIGOIDCL(int DJKBOHPOLAF, string HPANEBBHGAC, string EBHOIBHGECB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x74B7830", Offset = "0x74B6030", VA = "0x1874B7830")]
		public static LFGHOPIMKAN CIPNJECAKKA(string HPANEBBHGAC, string EBHOIBHGECB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x74B7B10", Offset = "0x74B6310", VA = "0x1874B7B10")]
		private static LFGHOPIMKAN IEBMNBAFGAD(string NLIBKHEBHGC, int DJKBOHPOLAF, string EGNNKOLBIMI, string EILJHPEODGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x74B79E0", Offset = "0x74B61E0", VA = "0x1874B79E0")]
		private static LFGHOPIMKAN IEBMNBAFGAD(string NLIBKHEBHGC, string EGNNKOLBIMI, string EILJHPEODGI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly BMELPJIFPCL MIHGFEDHECA;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static FKEACPHKBJP DHJDPACKPOC;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static KEPFCCDBCHI MCOIDBPJNJI;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<LFGHOPIMKAN> FNAIFIABNHO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long COMNPDMJLGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x74B9CB0", Offset = "0x74B84B0", VA = "0x1874B9CB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x74B9E10", Offset = "0x74B8610", VA = "0x1874B9E10")]
	[BDPIALLOKEK.JMECHJEFJFC]
	internal static void ENNDEGPPFMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x74B9F80", Offset = "0x74B8780", VA = "0x1874B9F80")]
	private static void GLBGFBBFBIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x74B9F00", Offset = "0x74B8700", VA = "0x1874B9F00")]
	public static LFGHOPIMKAN FONCLNFDKML(string NPMOFMALGKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x74B5DA0", Offset = "0x74B45A0", VA = "0x1874B5DA0")]
	public static LFGHOPIMKAN FONCLNFDKML(string NPMOFMALGKG, int DJKBOHPOLAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x74B9DA0", Offset = "0x74B85A0", VA = "0x1874B9DA0")]
	public static bool DGFHBIKOHPJ(this OPHBELKNMNO KKIFCHHDPJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x74BA040", Offset = "0x74B8840", VA = "0x1874BA040")]
	[BDPIALLOKEK.JMECHJEFJFC]
	internal static void HDCJGHFPMJA()
	{
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
