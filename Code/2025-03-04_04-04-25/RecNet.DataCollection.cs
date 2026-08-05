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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6D40", Offset = "0x6AD5340", VA = "0x186AD6D40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x97C6E0", Offset = "0x97ACE0", VA = "0x18097C6E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x97C720", Offset = "0x97AD20", VA = "0x18097C720")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecNet_DataCollection
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : EIAOKFHFGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4920", Offset = "0x6AD2F20", VA = "0x186AD4920", Slot = "4")]
		public override void OCICFIBHEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecNet_DataCollection
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6AD74B0", Offset = "0x6AD5AB0", VA = "0x186AD74B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x245DCB0", Offset = "0x245C2B0", VA = "0x18245DCB0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JEBCDHLLNLI
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> ODFENMFHBPM();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FOACGCJANCF
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1DE0", Offset = "0x6AD03E0", VA = "0x186AD1DE0")]
	public static void CHKGLMHHBMF(this EPFDINNLAOJ.GMCIPLKCNGP BGJAJNGKGGN, string HLEODLKDBHE, string NOGKIPDCPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1E50", Offset = "0x6AD0450", VA = "0x186AD1E50")]
	public static void CHKGLMHHBMF(this EPFDINNLAOJ.GMCIPLKCNGP BGJAJNGKGGN, string HLEODLKDBHE, bool NOGKIPDCPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1EE0", Offset = "0x6AD04E0", VA = "0x186AD1EE0")]
	public static void CHKGLMHHBMF(this EPFDINNLAOJ.GMCIPLKCNGP BGJAJNGKGGN, string HLEODLKDBHE, float KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1A80", Offset = "0x6AD0080", VA = "0x186AD1A80")]
	public static void CHKGLMHHBMF(this EPFDINNLAOJ.GMCIPLKCNGP BGJAJNGKGGN, string HLEODLKDBHE, BCBMKOENAEA NOGKIPDCPHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class EPFDINNLAOJ
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface FDKCHFEMFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GMCIPLKCNGP BPICIMGKBJC(Guid JKHDHJCLOPL, string LMCHMNCGABJ, [Optional] string NHAJGGCEPLN, [Optional] long? PGBFDPMMEBI, [Optional] string HHGJFFFBELN, [Optional] string EMFOOALOJPO);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class JBPBBOCEFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2F90", Offset = "0x6AD1590", VA = "0x186AD2F90")]
		public static GMCIPLKCNGP KDMFJGAFGMG(Guid JKHDHJCLOPL, string LMCHMNCGABJ, string NHAJGGCEPLN, [Optional] long? PGBFDPMMEBI, [Optional] string HHGJFFFBELN, [Optional] string EMFOOALOJPO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class GMCIPLKCNGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected NGKNGCBAEGI NBGBHBICCPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly IDictionary<string, IDictionary<string, object>> KAJOLMACPHA;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool NLHCGOGDOAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6AD25C0", Offset = "0x6AD0BC0", VA = "0x186AD25C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string FNFNOFHJOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xF17660", Offset = "0xF15C60", VA = "0x180F17660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6AD27F0", Offset = "0x6AD0DF0", VA = "0x186AD27F0")]
		public GMCIPLKCNGP(NGKNGCBAEGI NBGBHBICCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2540", Offset = "0x6AD0B40", VA = "0x186AD2540")]
		public GMCIPLKCNGP HHDHNPBMKNK(string KKCCAKAEMAH, string KBGCCIOIGBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3B1E400", Offset = "0x3B1CA00", VA = "0x183B1E400")]
		public GMCIPLKCNGP HHDHNPBMKNK<T>(string KKCCAKAEMAH, T KBGCCIOIGBD) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6AD24C0", Offset = "0x6AD0AC0", VA = "0x186AD24C0")]
		public GMCIPLKCNGP FLJNPKFNELD(string KKCCAKAEMAH, object KBGCCIOIGBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3B1E790", Offset = "0x3B1CD90", VA = "0x183B1E790")]
		public GMCIPLKCNGP NLDMCDIANLJ<T>(string KKCCAKAEMAH, T? KBGCCIOIGBD) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2760", Offset = "0x6AD0D60", VA = "0x186AD2760")]
		public GMCIPLKCNGP NLDMCDIANLJ(string KKCCAKAEMAH, string KBGCCIOIGBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6AD1FE0", Offset = "0x6AD05E0", VA = "0x186AD1FE0")]
		public GMCIPLKCNGP AJOMPAMKBMP(string PKALCDFCFBF, string LKMGECEEGEE, object GIDGOODJFLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2120", Offset = "0x6AD0720", VA = "0x186AD2120")]
		public GMCIPLKCNGP AJOMPAMKBMP(string PKALCDFCFBF, IDictionary<string, object> BHJLHIOPPEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2600", Offset = "0x6AD0C00", VA = "0x186AD2600")]
		private static IDictionary<string, object> MANGDKMFJNL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2200", Offset = "0x6AD0800", VA = "0x186AD2200")]
		public void CIDEKIJJAPH(bool OKIGMPKHPAB, string AJKBPDIMNDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2660", Offset = "0x6AD0C60", VA = "0x186AD2660")]
		public Task NBOIDEIKMKH([Optional] CancellationToken LAEIHJHNGEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2572A00", Offset = "0x2571000", VA = "0x182572A00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class NGKNGCBAEGI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct NPDJKHPHIKM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public NGKNGCBAEGI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6AD6890", Offset = "0x6AD4E90", VA = "0x186AD6890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6AD6CE0", Offset = "0x6AD52E0", VA = "0x186AD6CE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static Action<NGKNGCBAEGI> BPFAKKKHANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly string AFCDMPICECP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<string, object> PHMILIIDFEJ;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string FNFNOFHJOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5EB0", Offset = "0x6AD44B0", VA = "0x186AD5EB0")]
		private NGKNGCBAEGI(string AFCDMPICECP, int NJNOPMJJKAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6AD1450", Offset = "0x6ACFA50", VA = "0x186AD1450")]
		public static GMCIPLKCNGP OILMBKHFGKP(string AFCDMPICECP, int NJNOPMJJKAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5D50", Offset = "0x6AD4350", VA = "0x186AD5D50")]
		[AsyncStateMachine(typeof(NPDJKHPHIKM))]
		public Task NBOIDEIKMKH([Optional] CancellationToken LAEIHJHNGEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5E40", Offset = "0x6AD4440", VA = "0x186AD5E40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3472700", Offset = "0x3470D00", VA = "0x183472700")]
		internal void FODKDFJKBDL<T>(string KKCCAKAEMAH, T KBGCCIOIGBD) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5CF0", Offset = "0x6AD42F0", VA = "0x186AD5CF0")]
		internal void GDOJHJPIKLM(string KKCCAKAEMAH, object KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5C90", Offset = "0x6AD4290", VA = "0x186AD5C90")]
		internal void FODKDFJKBDL(string KKCCAKAEMAH, string KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3B25020", Offset = "0x3B23620", VA = "0x183B25020")]
		private void LODBJCCIDOP<T>(string KKCCAKAEMAH, T KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct PONHNKPPJIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string CIJLBPGJDKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly long? MBHFNFGPIAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly short? GKJHPGFIBHM;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7160", Offset = "0x6AD5760", VA = "0x186AD7160")]
		public PONHNKPPJIK(string OCEKCKOAFHB, [Optional] long? FFFLOIOFAMB, [Optional] short? EPGFALPMLBB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct FNDMNCJIIML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly int NKPGOLALOCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly string GOOHHJPFBAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly short BONKGCLMOFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly string MKALONOKCLC;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6AD1A30", Offset = "0x6AD0030", VA = "0x186AD1A30")]
		public FNDMNCJIIML(int LCDILMPPDOG, string KDLILMAPFGD, short DNFKGLFBNLF, string ANFJIGMMDKM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class DPIKNLEAAPM : FNAMINIIBJJ<NAODKKJCGKF, FNDMNCJIIML, PONHNKPPJIK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string KDLILMAPFGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private short DNFKGLFBNLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private string ANFJIGMMDKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Dictionary<short, int> GKMLJEGAKGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int EOOAJBFIKBG;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6AD1370", Offset = "0x6ACF970", VA = "0x186AD1370")]
		public DPIKNLEAAPM(string JHFJAFCMJGA, Guid KJHECKFPDFG, long PNHEMONCBEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0FA0", Offset = "0x6ACF5A0", VA = "0x186AD0FA0", Slot = "4")]
		public override void FJEPPMDLGDF(FNDMNCJIIML OKMEDGAPPCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6AD1290", Offset = "0x6ACF890", VA = "0x186AD1290")]
		public void GFDJEFMAIPC(short DNFKGLFBNLF, bool JKJPNIMMCGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x43F7DD0", Offset = "0x43F63D0", VA = "0x1843F7DD0")]
		public void CDKLLIOHDFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x956D10", Offset = "0x955310", VA = "0x180956D10")]
		public void OJOAAODDDEI(string KIFEMDHNLDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6AD01B0", Offset = "0x6ACE7B0", VA = "0x186AD01B0", Slot = "5")]
		public override void CCCPOAHOFEK(bool JBABOHBKBDK, PONHNKPPJIK DLGCHLJGCMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6ACFEF0", Offset = "0x6ACE4F0", VA = "0x186ACFEF0", Slot = "6")]
		public override BPOCDGAPBLA APFGEMLJPGO(NAODKKJCGKF NBKDLPDLNJE, int EAHKFAJBNDN, string PANEEJBPJIB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class LHNCMCPNGAC : BPOCDGAPBLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private string KDLILMAPFGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly short DNFKGLFBNLF;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3AE0", Offset = "0x6AD20E0", VA = "0x186AD3AE0")]
		public LHNCMCPNGAC(long GOBDDMLNCNK, int LCDILMPPDOG, string NHAJGGCEPLN, long PNHEMONCBEB, int KNCNKFIDAHL, string HHGJFFFBELN, short DNFKGLFBNLF, string KDLILMAPFGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3A50", Offset = "0x6AD2050", VA = "0x186AD3A50")]
		public void PHKDOFKCHKG(int LCDILMPPDOG, string KDLILMAPFGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3920", Offset = "0x6AD1F20", VA = "0x186AD3920", Slot = "5")]
		public override GMCIPLKCNGP BPICIMGKBJC(Guid JKHDHJCLOPL, string LMCHMNCGABJ, [Optional] string NHAJGGCEPLN, [Optional] long? PGBFDPMMEBI, [Optional] string HHGJFFFBELN, [Optional] string EMFOOALOJPO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class NAJEIACFFKK
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class NJFJFKIFEEP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float nextEventSendTime;

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public NJFJFKIFEEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6AD67F0", Offset = "0x6AD4DF0", VA = "0x186AD67F0")]
			internal bool AEMGBNBLDJH()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct LKKHAFGKIMI : IAsyncStateMachine
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
			private NJFJFKIFEEP <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TimeSpan <delayPollingInterval>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6AD3BD0", Offset = "0x6AD21D0", VA = "0x186AD3BD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6AD48C0", Offset = "0x6AD2EC0", VA = "0x186AD48C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct NHHFFFOKPAM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public bool isForcedEvent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6AD6200", Offset = "0x6AD4800", VA = "0x186AD6200", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6AD6790", Offset = "0x6AD4D90", VA = "0x186AD6790", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly float FGINANMGPGC;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static FIIDOADKEDD MGBNFJALEFB;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static CancellationTokenSource KCGLOFEJPJC;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static bool BGAPHLDONAI;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static int EGNBJCDFKIM;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly FLEKKBCEDJE<GMCIPLKCNGP, bool> LFEGMIKCPKB;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static BFNOGGKBHMI<GMCIPLKCNGP, bool> MDCDCLCCOMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6AD4A70", Offset = "0x6AD3070", VA = "0x186AD4A70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static bool IGGLPDCGIMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6AD5620", Offset = "0x6AD3C20", VA = "0x186AD5620")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6AD49B0", Offset = "0x6AD2FB0", VA = "0x186AD49B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private static bool OAHFGHGCAGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6AD4AC0", Offset = "0x6AD30C0", VA = "0x186AD4AC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6AD5370", Offset = "0x6AD3970", VA = "0x186AD5370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private static float AKDPPNCFIIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6AD53D0", Offset = "0x6AD39D0", VA = "0x186AD53D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6AD4A10", Offset = "0x6AD3010", VA = "0x186AD4A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5500", Offset = "0x6AD3B00", VA = "0x186AD5500")]
		[ONDAMKAMKDB.LAIHOOOIOBJ]
		internal static void LMLMKGJHIKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4B10", Offset = "0x6AD3110", VA = "0x186AD4B10")]
		internal static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6AD50E0", Offset = "0x6AD36E0", VA = "0x186AD50E0")]
		internal static void IHILNAOKAGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5670", Offset = "0x6AD3C70", VA = "0x186AD5670")]
		internal static void NCMDGGLGNAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5B30", Offset = "0x6AD4130", VA = "0x186AD5B30")]
		public static void OCICFBAINMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6AD56E0", Offset = "0x6AD3CE0", VA = "0x186AD56E0")]
		private static void NPJHCCOKKGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4DF0", Offset = "0x6AD33F0", VA = "0x186AD4DF0")]
		private static void IAAFPEIGDED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6AD52A0", Offset = "0x6AD38A0", VA = "0x186AD52A0")]
		[AsyncStateMachine(typeof(LKKHAFGKIMI))]
		private static Task IKFCHHFCIMH(CancellationToken LAEIHJHNGEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4D10", Offset = "0x6AD3310", VA = "0x186AD4D10")]
		private static void HPLNDCCLLGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5420", Offset = "0x6AD3A20", VA = "0x186AD5420")]
		[AsyncStateMachine(typeof(NHHFFFOKPAM))]
		private static Task LIMDIHIPLEH(bool EEFPNLDNILL, [Optional] CancellationToken LAEIHJHNGEK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class DNLIBJHOMEC<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class EMEBHJJFGHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public DNLIBJHOMEC<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public EMEBHJJFGHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x4072620", Offset = "0x4070C20", VA = "0x184072620")]
			internal object AOEFDNEGKJB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class KGHGCHFHDBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public DNLIBJHOMEC<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public KGHGCHFHDBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4AABE00", Offset = "0x4AAA400", VA = "0x184AABE00")]
			internal object CGCKBKGGAEF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class CGJIMMBBLDK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public DNLIBJHOMEC<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public CGJIMMBBLDK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x5A77CB0", Offset = "0x5A762B0", VA = "0x185A77CB0")]
			internal object EJMMKAFNNFB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class DOKAPLJDMPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public DNLIBJHOMEC<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public DOKAPLJDMPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6333470", Offset = "0x6331A70", VA = "0x186333470")]
			internal object CCMCLOBBGPF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class NOAJFPPIPAJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public DNLIBJHOMEC<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public NOAJFPPIPAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x4EEA9E0", Offset = "0x4EE8FE0", VA = "0x184EEA9E0")]
			internal object MKMHKCAIDEH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class KALCGDDKDDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public DNLIBJHOMEC<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public KALCGDDKDDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x4A941B0", Offset = "0x4A927B0", VA = "0x184A941B0")]
			internal object GACJKELFPIK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const float PDGKNMOLKCJ = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Guid JKHDHJCLOPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly string HHGJFFFBELN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly string ODGNPHEMLDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string IJOPCCHPFFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private string EMFOOALOJPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private string BCCAKJIJNBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private string GHEHENBBMDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private string JKCGHENFEMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private string FGFIFELLKLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private string DOEGOJJEDJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private string LMEMKNINDBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Guid? CPNGEOIJLOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private (int, int)? MLLFPKBAJIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly HashSet<T> FPCMHJJLLNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly Dictionary<(T, int), string> PGBJBOLHAEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly Dictionary<(T, int), float> DHACIHNMNHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Dictionary<T, string> OIEDHFGMOPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Dictionary<T, string> MBNKEJKLJAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Dictionary<T, string[]> NEMICHHHKLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private string MLEDPNIAIAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool GCJCKGGLEDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private Task EIPDABFMFOB;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x63311E0", Offset = "0x632F7E0", VA = "0x1863311E0")]
		public DNLIBJHOMEC(Guid JKHDHJCLOPL, string ODGNPHEMLDC, string HHGJFFFBELN, string IJOPCCHPFFE, [Optional] string EMFOOALOJPO, [Optional] string BCCAKJIJNBC, [Optional] string GHEHENBBMDC, [Optional] string DOEGOJJEDJH, [Optional] string MLEDPNIAIAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x956AD0", Offset = "0x9550D0", VA = "0x180956AD0")]
		public void MBJEKGEENGG(string EMFOOALOJPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x954470", Offset = "0x952A70", VA = "0x180954470")]
		public void IKBMDFKPIIG(string IJOPCCHPFFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xF86160", Offset = "0xF84760", VA = "0x180F86160")]
		public void JBNLEPBKMBC(string MLEDPNIAIAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x956B10", Offset = "0x955110", VA = "0x180956B10")]
		public void JPGJAEGHBFG(string JKCGHENFEMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x956D10", Offset = "0x955310", VA = "0x180956D10")]
		public void BCPPKFMLCOK(string LMEMKNINDBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x632B9E0", Offset = "0x6329FE0", VA = "0x18632B9E0")]
		public void FHAIOKHFAJL(Guid? JKHDHJCLOPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1B4AC20", Offset = "0x1B49220", VA = "0x181B4AC20")]
		public void BNCNPDJDJCL((int, int)? MLLFPKBAJIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x956D40", Offset = "0x955340", VA = "0x180956D40")]
		public void PCCMEMPOELD(string FGFIFELLKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x632E520", Offset = "0x632CB20", VA = "0x18632E520")]
		public void LKFHPHHFIDH(T PGBFDPMMEBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x632A860", Offset = "0x6328E60", VA = "0x18632A860")]
		public void AFHFDOMLLIL(T PGBFDPMMEBI, int JDOJDDHNDMA, float LKDAAJDJIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x632AD40", Offset = "0x6329340", VA = "0x18632AD40")]
		public void EBBKFNIFKHB(T PGBFDPMMEBI, int JDOJDDHNDMA, string FCCCBCHFBGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x632DEA0", Offset = "0x632C4A0", VA = "0x18632DEA0")]
		public void KCNEPNLOABJ(T PGBFDPMMEBI, string CJBNKLPJJFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x632B830", Offset = "0x6329E30", VA = "0x18632B830")]
		public void EIIIKEDDAAL(T PGBFDPMMEBI, string FOGKBJDKIMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x632CE20", Offset = "0x632B420", VA = "0x18632CE20")]
		public void HGNMBFJDLBK(T PGBFDPMMEBI, string[] NOHHGCNPHNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x632F3C0", Offset = "0x632D9C0", VA = "0x18632F3C0")]
		public Task NBOIDEIKMKH(bool MHOOEDPKADD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x632BA00", Offset = "0x632A000", VA = "0x18632BA00")]
		private (IEnumerable<T>, string) GDBJCFHGJFD()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x632D170", Offset = "0x632B770", VA = "0x18632D170")]
		public static GMCIPLKCNGP HIMPNHAPEGM(Guid JKHDHJCLOPL, string ODGNPHEMLDC, T PGBFDPMMEBI, string HHGJFFFBELN, string BGIAKAOMINL, string EMFOOALOJPO, int? EAHKFAJBNDN, [Optional] string IBBJMPKAHGD, [Optional] string CJBNKLPJJFC, [Optional] int? LCKGGGAJJFA, [Optional] Guid? CPNGEOIJLOG, [Optional] string MLEDPNIAIAL, [Optional] string NHAJGGCEPLN, [Optional] (int, int)? MLLFPKBAJIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6331030", Offset = "0x632F630", VA = "0x186331030")]
		[CompilerGenerated]
		private string NNJPPLBGIMD(T KGHCKLKGJKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x632AB90", Offset = "0x6329190", VA = "0x18632AB90")]
		[CompilerGenerated]
		private string BANAOOACHJF(T KGHCKLKGJKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6330E90", Offset = "0x632F490", VA = "0x186330E90")]
		[CompilerGenerated]
		private string NLCOAJJJBOL(T KGHCKLKGJKM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public abstract class FNAMINIIBJJ<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		protected readonly string JHFJAFCMJGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		protected readonly Guid KJHECKFPDFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		protected readonly long PNHEMONCBEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		protected int LCDILMPPDOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		protected int HEFIKJKNKJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		protected DateTime DPHGKFFGNKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		protected bool GONPKGFBEAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		protected Dictionary<long, BPOCDGAPBLA> PFDAMFJBCAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		protected bool EGEDFAKKCNG;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool PKFLGBGJCDM
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAAE930", Offset = "0xAACF30", VA = "0x180AAE930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool CDAGOCIPHBO
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xAFC4F0", Offset = "0xAFAAF0", VA = "0x180AFC4F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4437270", Offset = "0x4435870", VA = "0x184437270")]
		public FNAMINIIBJJ(string JHFJAFCMJGA, Guid KJHECKFPDFG, long PNHEMONCBEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void FJEPPMDLGDF(TListSessionStartParams OKMEDGAPPCL);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4437070", Offset = "0x4435670", VA = "0x184437070")]
		public void HIHHGDLPMLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void CCCPOAHOFEK(bool JBABOHBKBDK, TListSessionLogParams DLGCHLJGCMP);

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4436E80", Offset = "0x4435480", VA = "0x184436E80")]
		public void GBNPEOOPIBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4436ED0", Offset = "0x44354D0", VA = "0x184436ED0")]
		public void HGHPMENAECD(long GOBDDMLNCNK, int EAHKFAJBNDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4437080", Offset = "0x4435680", VA = "0x184437080")]
		public void KLBEBKKMMMM(long GOBDDMLNCNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract BPOCDGAPBLA APFGEMLJPGO(TItem MBDDOPABDGG, int EAHKFAJBNDN, string PANEEJBPJIB);
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class BPOCDGAPBLA : FDKCHFEMFPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private int LCDILMPPDOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private long GOBDDMLNCNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private long PNHEMONCBEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly string CNJDENCEMGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly string NCHFOJPPLLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly int KNCNKFIDAHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private DateTime AKCLJBEBOFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private double OKONAHKKKFP;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool OEMFDGOOIKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xCD2890", Offset = "0xCD0E90", VA = "0x180CD2890")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xCD2FF0", Offset = "0xCD15F0", VA = "0x180CD2FF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6ACDDA0", Offset = "0x6ACC3A0", VA = "0x186ACDDA0")]
		public BPOCDGAPBLA(long GOBDDMLNCNK, int LCDILMPPDOG, string NHAJGGCEPLN, long PNHEMONCBEB, int KNCNKFIDAHL, [Optional] string HHGJFFFBELN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6ACDC70", Offset = "0x6ACC270", VA = "0x186ACDC70")]
		public void LJDCFKCNHBI(int LCDILMPPDOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6ACDD50", Offset = "0x6ACC350", VA = "0x186ACDD50")]
		public void NJEJNHEPMOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6ACDB60", Offset = "0x6ACC160", VA = "0x186ACDB60")]
		public void FLCKKCHEAGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6ACDCE0", Offset = "0x6ACC2E0", VA = "0x186ACDCE0")]
		private void MGLOKGFKDAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD6B0", Offset = "0x6ACBCB0", VA = "0x186ACD6B0", Slot = "5")]
		public virtual GMCIPLKCNGP BPICIMGKBJC(Guid JKHDHJCLOPL, string LMCHMNCGABJ, [Optional] string NHAJGGCEPLN, [Optional] long? PGBFDPMMEBI, [Optional] string HHGJFFFBELN, [Optional] string EMFOOALOJPO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class DBIOLPDLMLO
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static Dictionary<string, Dictionary<string, object>> NDIKNOPEGPO;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static string AJDEODGCJFO;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static int DFADODFMPLJ;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly Dictionary<string, JEBCDHLLNLI> JHEIAEOMBBN;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static string JJOBABGJJPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x6ACE350", Offset = "0x6ACC950", VA = "0x186ACE350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6ACFCD0", Offset = "0x6ACE2D0", VA = "0x186ACFCD0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool IGANPIEEKLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6ACF970", Offset = "0x6ACDF70", VA = "0x186ACF970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static Dictionary<string, Dictionary<string, object>> COGNCEPLGFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6ACE5B0", Offset = "0x6ACCBB0", VA = "0x186ACE5B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static Guid? DENJFMBICBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x6ACF900", Offset = "0x6ACDF00", VA = "0x186ACF900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x6ACF2F0", Offset = "0x6ACD8F0", VA = "0x186ACF2F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static Guid? LNGMMGEKBIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6ACF350", Offset = "0x6ACD950", VA = "0x186ACF350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x6ACE780", Offset = "0x6ACCD80", VA = "0x186ACE780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6ACF260", Offset = "0x6ACD860", VA = "0x186ACF260")]
		public static void FLPCLMJIAME(string PLODMIMAPGG, JEBCDHLLNLI GFEDHLJPJCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6ACF620", Offset = "0x6ACDC20", VA = "0x186ACF620")]
		internal static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6ACF820", Offset = "0x6ACDE20", VA = "0x186ACF820")]
		internal static void IHILNAOKAGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6ACFC50", Offset = "0x6ACE250", VA = "0x186ACFC50")]
		internal static void NCMDGGLGNAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6ACE7E0", Offset = "0x6ACCDE0", VA = "0x186ACE7E0")]
		public static Guid FJEPPMDLGDF(string PLODMIMAPGG, [Optional] string? OHDOAHJDDOD, [Optional] Dictionary<string, object>? EEJFKHBLDLP)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6ACEDC0", Offset = "0x6ACD3C0", VA = "0x186ACEDC0")]
		public static Guid FJEPPMDLGDF(string PLODMIMAPGG, long OHDOAHJDDOD, [Optional] Dictionary<string, object>? EEJFKHBLDLP)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6ACF3C0", Offset = "0x6ACD9C0", VA = "0x186ACF3C0")]
		public static void HIHHGDLPMLA(string PLODMIMAPGG, [Optional] Guid? JINNLDEOCMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6ACE3A0", Offset = "0x6ACC9A0", VA = "0x186ACE3A0")]
		public static void BMGAPNCDIKI(string PLODMIMAPGG, string PKALCDFCFBF, object HGCONPIBKCO, bool BGAPHLDONAI = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6ACFA00", Offset = "0x6ACE000", VA = "0x186ACFA00")]
		public static bool LCAGLCCPHEE(string PLODMIMAPGG, [Optional] string? OHDOAHJDDOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6ACE600", Offset = "0x6ACCC00", VA = "0x186ACE600")]
		private static void CHJLECHOAMD(bool PEEGHBHEFHE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6ACFBF0", Offset = "0x6ACE1F0", VA = "0x186ACFBF0")]
		public static void LMGIPMOOIFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6ACF700", Offset = "0x6ACDD00", VA = "0x186ACF700")]
		private static void IAAFPEIGDED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6ACEE60", Offset = "0x6ACD460", VA = "0x186ACEE60")]
		private static void FKPKJBIPDEF(string PLODMIMAPGG, Guid JKHDHJCLOPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class CEOLIOGMGAG
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public struct JEHOOPACIIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public bool JHGFMOPHGIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public string BHPFPDNBMAP;

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xAAF4D0", Offset = "0xAADAD0", VA = "0x180AAF4D0")]
			public JEHOOPACIIC(bool JHGFMOPHGIB, string BHPFPDNBMAP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6ACDF30", Offset = "0x6ACC530", VA = "0x186ACDF30")]
		public static JEHOOPACIIC IEGNOINNOMJ(GMCIPLKCNGP BGJAJNGKGGN)
		{
			return default(JEHOOPACIIC);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6ACE250", Offset = "0x6ACC850", VA = "0x186ACE250")]
		private static void NKAEFHPEHCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6ACDE70", Offset = "0x6ACC470", VA = "0x186ACDE70")]
		private static void FFBPLMPMGIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class EDOBNOCMPDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6AD13F0", Offset = "0x6ACF9F0", VA = "0x186AD13F0")]
		public static GMCIPLKCNGP OCCFFFKDDCP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class JHENJJMJIDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3260", Offset = "0x6AD1860", VA = "0x186AD3260")]
		public static GMCIPLKCNGP CHKEOMGGFOF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6AD35C0", Offset = "0x6AD1BC0", VA = "0x186AD35C0")]
		public static GMCIPLKCNGP LIPDBNLHNAI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3440", Offset = "0x6AD1A40", VA = "0x186AD3440")]
		public static GMCIPLKCNGP FFOKGHBEMLJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3200", Offset = "0x6AD1800", VA = "0x186AD3200")]
		public static GMCIPLKCNGP CHELEOOAGFH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6AD36E0", Offset = "0x6AD1CE0", VA = "0x186AD36E0")]
		public static GMCIPLKCNGP PPDNPJPLIPJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3500", Offset = "0x6AD1B00", VA = "0x186AD3500")]
		public static GMCIPLKCNGP GKKOOHLPFPO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3680", Offset = "0x6AD1C80", VA = "0x186AD3680")]
		public static GMCIPLKCNGP NGFIKMCAPDF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3320", Offset = "0x6AD1920", VA = "0x186AD3320")]
		public static GMCIPLKCNGP DFJLJDINEFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6AD33E0", Offset = "0x6AD19E0", VA = "0x186AD33E0")]
		public static GMCIPLKCNGP FAKOILPCEFD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6AD34A0", Offset = "0x6AD1AA0", VA = "0x186AD34A0")]
		public static GMCIPLKCNGP GDGMDIKIJGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6AD31A0", Offset = "0x6AD17A0", VA = "0x186AD31A0")]
		public static GMCIPLKCNGP CELJMMEJCHC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3380", Offset = "0x6AD1980", VA = "0x186AD3380")]
		public static GMCIPLKCNGP DODDGFBOIAE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3620", Offset = "0x6AD1C20", VA = "0x186AD3620")]
		public static GMCIPLKCNGP LKICGCAABJC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6AD32C0", Offset = "0x6AD18C0", VA = "0x186AD32C0")]
		public static GMCIPLKCNGP CLNLHPLFBNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3560", Offset = "0x6AD1B60", VA = "0x186AD3560")]
		public static GMCIPLKCNGP IAKJACCJEMB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class JIBGJKHAHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3740", Offset = "0x6AD1D40", VA = "0x186AD3740")]
		public static GMCIPLKCNGP NKGDBECGCOD(long FFFLOIOFAMB, long OGHBKCHPPKA, bool KFDBDJLPICM, string HEOIEHKOKMI, string DIKLGMDDAFJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class OFHCMDOIFBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6FF0", Offset = "0x6AD55F0", VA = "0x186AD6FF0")]
		public static GMCIPLKCNGP PFCCOAFPOKE(string HOHDGOMKIEO, string FGKLODBMMNE, bool EKEMHHGLLIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6DC0", Offset = "0x6AD53C0", VA = "0x186AD6DC0")]
		public static GMCIPLKCNGP IOBPEBMKDBH(string BPPCEJGCMKA, string PAKCJCEHNIE, string LCLGMIAMOOG, [Optional] int? KHMEKCHOOFP, [Optional] double[] LBKLMGKKIMM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class HDDCLKJJGLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2890", Offset = "0x6AD0E90", VA = "0x186AD2890")]
		public static GMCIPLKCNGP AOKHBOHEHPC(string HIEALIELAPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2BE0", Offset = "0x6AD11E0", VA = "0x186AD2BE0")]
		public static GMCIPLKCNGP IMINJFMIHJA(string HKHPHIHDFNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2F30", Offset = "0x6AD1530", VA = "0x186AD2F30")]
		public static GMCIPLKCNGP NLIKHMPNLDF(int NJNOPMJJKAE, string OMOOEGOLALI, string KGHCKLKGJKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2970", Offset = "0x6AD0F70", VA = "0x186AD2970")]
		public static GMCIPLKCNGP AONKIFBJDMP(int NJNOPMJJKAE, string OMOOEGOLALI, string KGHCKLKGJKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2A30", Offset = "0x6AD1030", VA = "0x186AD2A30")]
		public static GMCIPLKCNGP IBGLGHHDDPL(int NJNOPMJJKAE, string OMOOEGOLALI, string KGHCKLKGJKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6AD29D0", Offset = "0x6AD0FD0", VA = "0x186AD29D0")]
		public static GMCIPLKCNGP HDMIMPOFPFC(int NJNOPMJJKAE, string OMOOEGOLALI, string KGHCKLKGJKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2A90", Offset = "0x6AD1090", VA = "0x186AD2A90")]
		public static GMCIPLKCNGP IJDNGOFLCDE(string OMOOEGOLALI, string KGHCKLKGJKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2DF0", Offset = "0x6AD13F0", VA = "0x186AD2DF0")]
		private static GMCIPLKCNGP JHAJNHNPDML(string JHFJAFCMJGA, int NJNOPMJJKAE, string GMLPIJBAHPD, string NFJADIGKJCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2CC0", Offset = "0x6AD12C0", VA = "0x186AD2CC0")]
		private static GMCIPLKCNGP JHAJNHNPDML(string JHFJAFCMJGA, string GMLPIJBAHPD, string NFJADIGKJCF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly IBCMILIKEJG IEGNOINNOMJ;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static AKPEKCLMGOC JJFLHFANALH;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static BKFMNGCFFLF IOKGEJEAKLB;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<GMCIPLKCNGP> IPLKOJPDLBO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long GIOILMPFJLG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6AD16E0", Offset = "0x6ACFCE0", VA = "0x186AD16E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6AD15E0", Offset = "0x6ACFBE0", VA = "0x186AD15E0")]
	[ONDAMKAMKDB.LAIHOOOIOBJ]
	internal static void FDAPFLHEMPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6AD18F0", Offset = "0x6ACFEF0", VA = "0x186AD18F0")]
	private static void NOAAHKDEMAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1560", Offset = "0x6ACFB60", VA = "0x186AD1560")]
	public static GMCIPLKCNGP CJIENNAOJJA(string AFCDMPICECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1450", Offset = "0x6ACFA50", VA = "0x186AD1450")]
	public static GMCIPLKCNGP CJIENNAOJJA(string AFCDMPICECP, int NJNOPMJJKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6AD17D0", Offset = "0x6ACFDD0", VA = "0x186AD17D0")]
	[ONDAMKAMKDB.LAIHOOOIOBJ]
	internal static void LMMNEGCLBHC()
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
