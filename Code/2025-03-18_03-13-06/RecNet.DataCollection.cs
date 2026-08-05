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
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6BC14A0", Offset = "0x6BC06A0", VA = "0x186BC14A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x98D6C0", Offset = "0x98C8C0", VA = "0x18098D6C0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x98D700", Offset = "0x98C900", VA = "0x18098D700")]
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
	public class LogRegistrationIndex : LGGBAGMLBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6BBF920", Offset = "0x6BBEB20", VA = "0x186BBF920", Slot = "4")]
		public override void COGNOIDNGPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BC2A50", Offset = "0x6BC1C50", VA = "0x186BC2A50", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2493E30", Offset = "0x2493030", VA = "0x182493E30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LCOCKODGGJD
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> CJNDHCJOOKG();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class ONMALELBEMD
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6BC1A00", Offset = "0x6BC0C00", VA = "0x186BC1A00")]
	public static void FBAEKLOPKHD(this DJOAGLNCLDL.POHOKDOPBIA FODOLMGFLHI, string BIEAJHEIKNI, string IHPHNEHPDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6BC1970", Offset = "0x6BC0B70", VA = "0x186BC1970")]
	public static void FBAEKLOPKHD(this DJOAGLNCLDL.POHOKDOPBIA FODOLMGFLHI, string BIEAJHEIKNI, bool IHPHNEHPDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6BC1520", Offset = "0x6BC0720", VA = "0x186BC1520")]
	public static void FBAEKLOPKHD(this DJOAGLNCLDL.POHOKDOPBIA FODOLMGFLHI, string BIEAJHEIKNI, float OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6BC1620", Offset = "0x6BC0820", VA = "0x186BC1620")]
	public static void FBAEKLOPKHD(this DJOAGLNCLDL.POHOKDOPBIA FODOLMGFLHI, string BIEAJHEIKNI, EFBNEIOOJKJ IHPHNEHPDFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class DJOAGLNCLDL
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface MNKKNOBKPIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		POHOKDOPBIA PDGKFBKJCKL(Guid OEJALLLJJBO, string MEABJFEDAHF, [Optional] string JKAEGLJGOPO, [Optional] long? NDKANFCADML, [Optional] string MLOCIFPIMBM, [Optional] string CDKLGHBBGLF);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class CGFLEINKAMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6BB9380", Offset = "0x6BB8580", VA = "0x186BB9380")]
		public static POHOKDOPBIA PBFKEBLIJKK(Guid OEJALLLJJBO, string MEABJFEDAHF, string JKAEGLJGOPO, [Optional] long? NDKANFCADML, [Optional] string MLOCIFPIMBM, [Optional] string CDKLGHBBGLF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class POHOKDOPBIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected KDBOPGGFIHA ELLEMLBGHOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly IDictionary<string, IDictionary<string, object>> IDMHFJOCDDD;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool GAEIFKLBIOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6BC2620", Offset = "0x6BC1820", VA = "0x186BC2620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string GDFEKDDMEOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xF61290", Offset = "0xF60490", VA = "0x180F61290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6BC26C0", Offset = "0x6BC18C0", VA = "0x186BC26C0")]
		public POHOKDOPBIA(KDBOPGGFIHA ELLEMLBGHOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6BC2280", Offset = "0x6BC1480", VA = "0x186BC2280")]
		public POHOKDOPBIA ELOHCHPBMIE(string AKOEHEOHLAC, string OMFJNFBDJCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3B87FA0", Offset = "0x3B871A0", VA = "0x183B87FA0")]
		public POHOKDOPBIA ELOHCHPBMIE<T>(string AKOEHEOHLAC, T OMFJNFBDJCA) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6BC2200", Offset = "0x6BC1400", VA = "0x186BC2200")]
		public POHOKDOPBIA BMDGCOHMHLI(string AKOEHEOHLAC, object OMFJNFBDJCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3B87F10", Offset = "0x3B87110", VA = "0x183B87F10")]
		public POHOKDOPBIA AIKPGBELJEM<T>(string AKOEHEOHLAC, T? OMFJNFBDJCA) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6BC1EB0", Offset = "0x6BC10B0", VA = "0x186BC1EB0")]
		public POHOKDOPBIA AIKPGBELJEM(string AKOEHEOHLAC, string OMFJNFBDJCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6BC2300", Offset = "0x6BC1500", VA = "0x186BC2300")]
		public POHOKDOPBIA FOEBOKELLAD(string DCPPIGOIABG, string MBDBONINAPC, object LJELDKAOCJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6BC2440", Offset = "0x6BC1640", VA = "0x186BC2440")]
		public POHOKDOPBIA FOEBOKELLAD(string DCPPIGOIABG, IDictionary<string, object> FKONFNGBCPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6BC2660", Offset = "0x6BC1860", VA = "0x186BC2660")]
		private static IDictionary<string, object> OIDJLANAIAC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6BC1F40", Offset = "0x6BC1140", VA = "0x186BC1F40")]
		public void BCMADJHENKN(bool MAIKFKMOAMP, string DGDFKIPENNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6BC2520", Offset = "0x6BC1720", VA = "0x186BC2520")]
		public Task JMFDJAKOLCH([Optional] CancellationToken KPIINMODKFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x25A9B80", Offset = "0x25A8D80", VA = "0x1825A9B80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class KDBOPGGFIHA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct AGGAKKIEKCA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public KDBOPGGFIHA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6BB8E90", Offset = "0x6BB8090", VA = "0x186BB8E90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6BB92D0", Offset = "0x6BB84D0", VA = "0x186BB92D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static Action<KDBOPGGFIHA> DGEMIDMIAKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly string EIJINJKPAOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<string, object> COGIFFFODPF;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string GDFEKDDMEOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6BBE3A0", Offset = "0x6BBD5A0", VA = "0x186BBE3A0")]
		private KDBOPGGFIHA(string EIJINJKPAOB, int GMGPDOAAFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA050", Offset = "0x6BB9250", VA = "0x186BBA050")]
		public static POHOKDOPBIA JENMMFKNHKF(string EIJINJKPAOB, int GMGPDOAAFEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6BBE1E0", Offset = "0x6BBD3E0", VA = "0x186BBE1E0")]
		[AsyncStateMachine(typeof(AGGAKKIEKCA))]
		public Task JMFDJAKOLCH([Optional] CancellationToken KPIINMODKFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6BBE330", Offset = "0x6BBD530", VA = "0x186BBE330", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3B70270", Offset = "0x3B6F470", VA = "0x183B70270")]
		internal void HELFMKLMEGC<T>(string AKOEHEOHLAC, T OMFJNFBDJCA) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6BBE2D0", Offset = "0x6BBD4D0", VA = "0x186BBE2D0")]
		internal void PFPMOBKKMKL(string AKOEHEOHLAC, object OMFJNFBDJCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6BBE180", Offset = "0x6BBD380", VA = "0x186BBE180")]
		internal void HELFMKLMEGC(string AKOEHEOHLAC, string OMFJNFBDJCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3B84060", Offset = "0x3B83260", VA = "0x183B84060")]
		private void JMDFGOEOPFC<T>(string AKOEHEOHLAC, T OMFJNFBDJCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct OOPCOIJPHPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string FALNPMJKOGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly long? CBKFHOJDEKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly short? AHDHILKIMPO;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6BC1AD0", Offset = "0x6BC0CD0", VA = "0x186BC1AD0")]
		public OOPCOIJPHPL(string DPCLCDAMIEJ, [Optional] long? KCAAOMDKNIH, [Optional] short? ILACMKKCJAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct ANMKECBEJPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly int PPIAMNNGCFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly string GAIFNEFBFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly short EPGAHFEILKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly string EOCGAPPLNHK;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6BB9330", Offset = "0x6BB8530", VA = "0x186BB9330")]
		public ANMKECBEJPP(int PPODBOCLAHA, string HEIENGLEHDM, short FDKFIGLENGE, string ELJLGNLNDDP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class JFAPECLDHDB : DIOMDAIOOLA<KBJNMBFDPMK, ANMKECBEJPP, OOPCOIJPHPL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string HEIENGLEHDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private short FDKFIGLENGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private string ELJLGNLNDDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Dictionary<short, int> MCBAFLMBFOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int IGBAKMDBKEK;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6BBE100", Offset = "0x6BBD300", VA = "0x186BBE100")]
		public JFAPECLDHDB(string APLPDPCNINO, Guid JFCNAMJKIMP, long CJIDHKGANPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6BBDA80", Offset = "0x6BBCC80", VA = "0x186BBDA80", Slot = "4")]
		public override void BCMFPHEAEHA(ANMKECBEJPP NPENKIECEHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6BBE020", Offset = "0x6BBD220", VA = "0x186BBE020")]
		public void HDKIFELIJIA(short FDKFIGLENGE, bool CCOMJBEAPIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x44A0780", Offset = "0x449F980", VA = "0x1844A0780")]
		public void ONDHPKHBFME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x961650", Offset = "0x960850", VA = "0x180961650")]
		public void GDPGGHFPLKC(string OGKAOAPGKCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6BBCC90", Offset = "0x6BBBE90", VA = "0x186BBCC90", Slot = "5")]
		public override void ABMABHKLMAN(bool JDILIKAFPEO, OOPCOIJPHPL NNFKHEOLOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6BBDD70", Offset = "0x6BBCF70", VA = "0x186BBDD70", Slot = "6")]
		public override GLALKDOMJBM EPDMAHFFBNC(KBJNMBFDPMK HKBPNHDCPDD, int KOOLKCPAFBB, string DIIGCEKPIAO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class EAIGOJOOIKC : GLALKDOMJBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private string HEIENGLEHDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly short FDKFIGLENGE;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA400", Offset = "0x6BB9600", VA = "0x186BBA400")]
		public EAIGOJOOIKC(long BJDEDKEAADM, int PPODBOCLAHA, string JKAEGLJGOPO, long CJIDHKGANPH, int FENGNBNFLKP, string MLOCIFPIMBM, short FDKFIGLENGE, string HEIENGLEHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA250", Offset = "0x6BB9450", VA = "0x186BBA250")]
		public void AOIKPAGCBHB(int PPODBOCLAHA, string HEIENGLEHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA2D0", Offset = "0x6BB94D0", VA = "0x186BBA2D0", Slot = "5")]
		public override POHOKDOPBIA PDGKFBKJCKL(Guid OEJALLLJJBO, string MEABJFEDAHF, [Optional] string JKAEGLJGOPO, [Optional] long? NDKANFCADML, [Optional] string MLOCIFPIMBM, [Optional] string CDKLGHBBGLF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class LMDHLAFIDNE
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class EDBHBIEBPCD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float nextEventSendTime;

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public EDBHBIEBPCD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6BBA4F0", Offset = "0x6BB96F0", VA = "0x186BBA4F0")]
			internal bool BMAOMLHOFEI()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct GKKBMOILLNI : IAsyncStateMachine
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
			private EDBHBIEBPCD <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TimeSpan <delayPollingInterval>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6BBAD10", Offset = "0x6BB9F10", VA = "0x186BBAD10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6BBB9D0", Offset = "0x6BBABD0", VA = "0x186BBB9D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct IGOKHEDLBBJ : IAsyncStateMachine
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

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6BBC6B0", Offset = "0x6BBB8B0", VA = "0x186BBC6B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6BBCC30", Offset = "0x6BBBE30", VA = "0x186BBCC30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly float KNDIDAKMCIE;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static JDFJKMABMDJ PGKELCELKPP;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static CancellationTokenSource ILGKONILJHJ;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static bool OANJOBJNNND;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static int AFHOJINIHEE;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly NENPGIPFKEI<POHOKDOPBIA, bool> AKHENGFLJPL;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static LMPONAIBOKE<POHOKDOPBIA, bool> DNHGFGHICLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6BBEB60", Offset = "0x6BBDD60", VA = "0x186BBEB60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static bool PGCEPIFKCGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6BBE6E0", Offset = "0x6BBD8E0", VA = "0x186BBE6E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6BBEDD0", Offset = "0x6BBDFD0", VA = "0x186BBEDD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private static bool LAABECHIJAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6BBEE30", Offset = "0x6BBE030", VA = "0x186BBEE30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6BBEF60", Offset = "0x6BBE160", VA = "0x186BBEF60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private static float DCCDDAIABBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6BBEC10", Offset = "0x6BBDE10", VA = "0x186BBEC10")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6BBEBB0", Offset = "0x6BBDDB0", VA = "0x186BBEBB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6BBECB0", Offset = "0x6BBDEB0", VA = "0x186BBECB0")]
		[AEGEAJMGHGA.LGPOCIOLIAD]
		internal static void GKADHMNCEJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6BBF650", Offset = "0x6BBE850", VA = "0x186BBF650")]
		internal static void PDAIGIIELDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6BBEFC0", Offset = "0x6BBE1C0", VA = "0x186BBEFC0")]
		internal static void KHKCOPJHGHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6BBF450", Offset = "0x6BBE650", VA = "0x186BBF450")]
		internal static void LMJMDPCGHEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6BBEC60", Offset = "0x6BBDE60", VA = "0x186BBEC60")]
		public static void GFPNMOHIMIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6BBE730", Offset = "0x6BBD930", VA = "0x186BBE730")]
		private static void DOGIJECAJFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6BBF170", Offset = "0x6BBE370", VA = "0x186BBF170")]
		private static void LDIPNOBGHOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6BBF580", Offset = "0x6BBE780", VA = "0x186BBF580")]
		[AsyncStateMachine(typeof(GKKBMOILLNI))]
		private static Task ONEADEMACDK(CancellationToken KPIINMODKFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6BBF4B0", Offset = "0x6BBE6B0", VA = "0x186BBF4B0")]
		private static void ODCMALJHJCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6BBEE80", Offset = "0x6BBE080", VA = "0x186BBEE80")]
		[AsyncStateMachine(typeof(IGOKHEDLBBJ))]
		private static Task JCHMAKIBCMB(bool IDEEDOENAMC, [Optional] CancellationToken KPIINMODKFJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class JEAPBJHKBHK<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class CPJAGNPBOBE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public JEAPBJHKBHK<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public CPJAGNPBOBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x5DCED30", Offset = "0x5DCDF30", VA = "0x185DCED30")]
			internal object GJMFLBIGGGA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class OBDAMJHKBPH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public JEAPBJHKBHK<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public OBDAMJHKBPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x4F46890", Offset = "0x4F45A90", VA = "0x184F46890")]
			internal object DELJAGIBKNA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class JBDOJMEEFGA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public JEAPBJHKBHK<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public JBDOJMEEFGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x49540F0", Offset = "0x49532F0", VA = "0x1849540F0")]
			internal object KPDPKPIMBJG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class EEDDIIFFAPJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public JEAPBJHKBHK<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public EEDDIIFFAPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x40DF110", Offset = "0x40DE310", VA = "0x1840DF110")]
			internal object FALMIKKNIHA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class PBILPIPGHHG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public JEAPBJHKBHK<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public PBILPIPGHHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x50B94F0", Offset = "0x50B86F0", VA = "0x1850B94F0")]
			internal object IJKFGDAFPBP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class BLLGNALEBCA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public JEAPBJHKBHK<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public BLLGNALEBCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x58D4760", Offset = "0x58D3960", VA = "0x1858D4760")]
			internal object ACNOHFBLEPC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const float GKKJINLGOAO = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Guid OEJALLLJJBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly string MLOCIFPIMBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly string LJPLNKDMCPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string NDLJOPLBFNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private string CDKLGHBBGLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private string BHFIOHLONLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private string LJIBBDFDILF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private string NMBNEDNHDLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private string MOKFAIPAGKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private string NDNNDGBADJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private string FPHDKBBNDNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private string CNMADLGNCJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Guid? JDMJNDNDDAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private (int, int)? ALHBBNNPGDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly HashSet<T> LCMOFAMKCOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly Dictionary<(T, int), string> MIEMOLGNMNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Dictionary<(T, int), float> HEHCMEAFGAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Dictionary<T, string> MIKLJGACLDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Dictionary<T, string> NKGBAICKEJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly Dictionary<T, string[]> FPHNDLDKAGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private string KCDADHMFNDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool NBHOPICLLNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Task KAFPMNBICJI;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x496FB30", Offset = "0x496ED30", VA = "0x18496FB30")]
		public JEAPBJHKBHK(Guid OEJALLLJJBO, string LJPLNKDMCPA, string MLOCIFPIMBM, string NDLJOPLBFNH, [Optional] string CDKLGHBBGLF, [Optional] string BHFIOHLONLM, [Optional] string LJIBBDFDILF, [Optional] string NDNNDGBADJF, [Optional] string KCDADHMFNDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x964F40", Offset = "0x964140", VA = "0x180964F40")]
		public void JKDMFFNDNPK(string CDKLGHBBGLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x968CE0", Offset = "0x967EE0", VA = "0x180968CE0")]
		public void LHEFGLMGLOL(string NDLJOPLBFNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xC63500", Offset = "0xC62700", VA = "0x180C63500")]
		public void NJDHHHOEFGA(string KCDADHMFNDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x961610", Offset = "0x960810", VA = "0x180961610")]
		public void MAGCJHHDGMH(string NMBNEDNHDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x961650", Offset = "0x960850", VA = "0x180961650")]
		public void LIGCMNDNOHH(string FPHDKBBNDNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x966D50", Offset = "0x965F50", VA = "0x180966D50")]
		public void GPOEACELHPD(string CNMADLGNCJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x496A0D0", Offset = "0x49692D0", VA = "0x18496A0D0")]
		public void FDHOBGNADBH(Guid? OEJALLLJJBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x496E3F0", Offset = "0x496D5F0", VA = "0x18496E3F0")]
		public void NHNCFHMGBIE((int, int)? ALHBBNNPGDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x961640", Offset = "0x960840", VA = "0x180961640")]
		public void BGBHIHFKIBF(string MOKFAIPAGKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4968F10", Offset = "0x4968110", VA = "0x184968F10")]
		public void BFIJOLFEGKN(T NDKANFCADML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4969890", Offset = "0x4968A90", VA = "0x184969890")]
		public void CLIDCKKPBDO(T NDKANFCADML, int GBBCBGEKBGN, float MBNMMCCMGDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x496A840", Offset = "0x4969A40", VA = "0x18496A840")]
		public void GBLHMPDOCDG(T NDKANFCADML, int GBBCBGEKBGN, string BGGAAPCFHGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x496A0F0", Offset = "0x49692F0", VA = "0x18496A0F0")]
		public void FMKPFICCMOM(T NDKANFCADML, string ENHLPLLNLLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4969BF0", Offset = "0x4968DF0", VA = "0x184969BF0")]
		public void EBFINGDLHED(T NDKANFCADML, string CJNGJGPNJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x496E750", Offset = "0x496D950", VA = "0x18496E750")]
		public void NKJFMDLOKIK(T NDKANFCADML, string[] LKJACMJEMPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x496B170", Offset = "0x496A370", VA = "0x18496B170")]
		public Task JMFDJAKOLCH(bool CPGNGBBHKKK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x496F510", Offset = "0x496E710", VA = "0x18496F510")]
		private (IEnumerable<T>, string) OBHNEDPEMAF()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x496DBE0", Offset = "0x496CDE0", VA = "0x18496DBE0")]
		public static POHOKDOPBIA KBABFIJJNFN(Guid OEJALLLJJBO, string LJPLNKDMCPA, T NDKANFCADML, string MLOCIFPIMBM, string AMIBHLBJGGK, string CDKLGHBBGLF, int? KOOLKCPAFBB, [Optional] string MNOBIIHEFLE, [Optional] string ENHLPLLNLLD, [Optional] int? HDCOFAJHOOE, [Optional] Guid? JDMJNDNDDAK, [Optional] string KCDADHMFNDL, [Optional] string JKAEGLJGOPO, [Optional] (int, int)? ALHBBNNPGDC, [Optional] string CKACMBHANHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x496AE00", Offset = "0x496A000", VA = "0x18496AE00")]
		[CompilerGenerated]
		private string JICIHLNKDNB(T JDNOHHGIHEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x49690A0", Offset = "0x49682A0", VA = "0x1849690A0")]
		[CompilerGenerated]
		private string CGEPAFBADLL(T JDNOHHGIHEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x496AF20", Offset = "0x496A120", VA = "0x18496AF20")]
		[CompilerGenerated]
		private string JKJEMGNBDLA(T JDNOHHGIHEO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public abstract class DIOMDAIOOLA<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		protected readonly string APLPDPCNINO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		protected readonly Guid JFCNAMJKIMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		protected readonly long CJIDHKGANPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		protected int PPODBOCLAHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		protected int OHNCJGOBKFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		protected DateTime PKMKBDALGGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		protected bool NONMGCENMIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		protected Dictionary<long, GLALKDOMJBM> LBHDFGFJGDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		protected bool EHPKGKOBLAK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool LEEPFAKCGED
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xB05420", Offset = "0xB04620", VA = "0x180B05420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool CPMAJOMLNBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xB62A00", Offset = "0xB61C00", VA = "0x180B62A00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x63E0EA0", Offset = "0x63E00A0", VA = "0x1863E0EA0")]
		public DIOMDAIOOLA(string APLPDPCNINO, Guid JFCNAMJKIMP, long CJIDHKGANPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void BCMFPHEAEHA(TListSessionStartParams NPENKIECEHD);

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x476E1E0", Offset = "0x476D3E0", VA = "0x18476E1E0")]
		public void LALPKJCBBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void ABMABHKLMAN(bool JDILIKAFPEO, TListSessionLogParams NNFKHEOLOCP);

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x63E0E00", Offset = "0x63E0000", VA = "0x1863E0E00")]
		public void MEFOPAOJLBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x63E0C60", Offset = "0x63DFE60", VA = "0x1863E0C60")]
		public void KCGHDCBPFKE(long BJDEDKEAADM, int KOOLKCPAFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x63E0BD0", Offset = "0x63DFDD0", VA = "0x1863E0BD0")]
		public void HKCLBAHAJNE(long BJDEDKEAADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract GLALKDOMJBM EPDMAHFFBNC(TItem LOKFKJLCEOD, int KOOLKCPAFBB, string DIIGCEKPIAO);
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class GLALKDOMJBM : MNKKNOBKPIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private int PPODBOCLAHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private long BJDEDKEAADM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private long CJIDHKGANPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly string JAHGECFGMKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly string OKONCKBBHHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly int FENGNBNFLKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private DateTime EEDPIKNJLBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private double IPOPPEIIPCG;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IBDNGNAJFOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xD2FFA0", Offset = "0xD2F1A0", VA = "0x180D2FFA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xD30B90", Offset = "0xD2FD90", VA = "0x180D30B90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6BBC110", Offset = "0x6BBB310", VA = "0x186BBC110")]
		public GLALKDOMJBM(long BJDEDKEAADM, int PPODBOCLAHA, string JKAEGLJGOPO, long CJIDHKGANPH, int FENGNBNFLKP, [Optional] string MLOCIFPIMBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6BBBBF0", Offset = "0x6BBADF0", VA = "0x186BBBBF0")]
		public void NAIGLJLCJEA(int PPODBOCLAHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6BBBB40", Offset = "0x6BBAD40", VA = "0x186BBBB40")]
		public void HEHONNJDPBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6BBBA30", Offset = "0x6BBAC30", VA = "0x186BBBA30")]
		public void FLDCDGOAMOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6BBBB90", Offset = "0x6BBAD90", VA = "0x186BBBB90")]
		private void JBONACNIJDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6BBBC60", Offset = "0x6BBAE60", VA = "0x186BBBC60", Slot = "5")]
		public virtual POHOKDOPBIA PDGKFBKJCKL(Guid OEJALLLJJBO, string MEABJFEDAHF, [Optional] string JKAEGLJGOPO, [Optional] long? NDKANFCADML, [Optional] string MLOCIFPIMBM, [Optional] string CDKLGHBBGLF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class MIHGICKCALD
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static Dictionary<string, Dictionary<string, object>> EPAHJDGLKHD;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static string EDEBOPGCMKM;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static int DFKELNILLKK;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static readonly Dictionary<string, LCOCKODGGJD> DDOFAPNNHGC;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static string JKONMEPEBFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6BC0630", Offset = "0x6BBF830", VA = "0x186BC0630")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6BC0910", Offset = "0x6BBFB10", VA = "0x186BC0910")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool BBFFIOCLCNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6BC12D0", Offset = "0x6BC04D0", VA = "0x186BC12D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static Dictionary<string, Dictionary<string, object>> DKJLPELBFCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x6BC11A0", Offset = "0x6BC03A0", VA = "0x186BC11A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static Guid? OODCMKMDPBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x6BC0190", Offset = "0x6BBF390", VA = "0x186BC0190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6BC1140", Offset = "0x6BC0340", VA = "0x186BC1140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static Guid? JKAEENIMHPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x6BC09C0", Offset = "0x6BBFBC0", VA = "0x186BC09C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6BC10E0", Offset = "0x6BC02E0", VA = "0x186BC10E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6BC0880", Offset = "0x6BBFA80", VA = "0x186BC0880")]
		public static void IBKAGOIHOPI(string JMOPDNJCOMK, LCOCKODGGJD OFMOJFOKPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6BC11F0", Offset = "0x6BC03F0", VA = "0x186BC11F0")]
		internal static void PDAIGIIELDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6BC0A20", Offset = "0x6BBFC20", VA = "0x186BC0A20")]
		internal static void KHKCOPJHGHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6BC1060", Offset = "0x6BC0260", VA = "0x186BC1060")]
		internal static void LMJMDPCGHEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6BBFA50", Offset = "0x6BBEC50", VA = "0x186BBFA50")]
		public static Guid BCMFPHEAEHA(string JMOPDNJCOMK, [Optional] string? COMIOEDNDND, [Optional] Dictionary<string, object>? PPHBLFJKJGP)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6BBF9B0", Offset = "0x6BBEBB0", VA = "0x186BBF9B0")]
		public static Guid BCMFPHEAEHA(string JMOPDNJCOMK, long COMIOEDNDND, [Optional] Dictionary<string, object>? PPHBLFJKJGP)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6BC0B00", Offset = "0x6BBFD00", VA = "0x186BC0B00")]
		public static void LALPKJCBBPD(string JMOPDNJCOMK, [Optional] Guid? FGPNICIMMFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6BC0680", Offset = "0x6BBF880", VA = "0x186BC0680")]
		public static void HPILHBNDJGN(string JMOPDNJCOMK, string DCPPIGOIABG, object NIJKDODDBMP, bool OANJOBJNNND = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6BC0E70", Offset = "0x6BC0070", VA = "0x186BC0E70")]
		public static bool LMBHMNNHPAC(string JMOPDNJCOMK, [Optional] string? COMIOEDNDND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6BC0020", Offset = "0x6BBF220", VA = "0x186BC0020")]
		private static void ECJHCKFJGJN(bool OMBCEDNBBBD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6BC05E0", Offset = "0x6BBF7E0", VA = "0x186BC05E0")]
		public static void GOGGBGJLNBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6BC0D60", Offset = "0x6BBFF60", VA = "0x186BC0D60")]
		private static void LDIPNOBGHOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6BC01F0", Offset = "0x6BBF3F0", VA = "0x186BC01F0")]
		private static void FPBIHNKINDB(string JMOPDNJCOMK, Guid OEJALLLJJBO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class GLKDOFCPNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public struct IFDBOHBKACI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public bool GDICEIEOEJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public string NGDINNOFNDP;

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xB07060", Offset = "0xB06260", VA = "0x180B07060")]
			public IFDBOHBKACI(bool GDICEIEOEJN, string NGDINNOFNDP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6BBC3A0", Offset = "0x6BBB5A0", VA = "0x186BBC3A0")]
		public static IFDBOHBKACI IPKFDHIOJFD(POHOKDOPBIA FODOLMGFLHI)
		{
			return default(IFDBOHBKACI);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6BBC1E0", Offset = "0x6BBB3E0", VA = "0x186BBC1E0")]
		private static void CBCJJKJCJMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6BBC2E0", Offset = "0x6BBB4E0", VA = "0x186BBC2E0")]
		private static void DKDJKOOFBCJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class OOMLNNNOGPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6BC1A70", Offset = "0x6BC0C70", VA = "0x186BC1A70")]
		public static POHOKDOPBIA GCPKKILNOCJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class EGJPGOIIAEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA7D0", Offset = "0x6BB99D0", VA = "0x186BBA7D0")]
		public static POHOKDOPBIA ICMAAPDLLJE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA710", Offset = "0x6BB9910", VA = "0x186BBA710")]
		public static POHOKDOPBIA HMGHEPGBNOA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6BBAA70", Offset = "0x6BB9C70", VA = "0x186BBAA70")]
		public static POHOKDOPBIA OKKMCHAMNGG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA890", Offset = "0x6BB9A90", VA = "0x186BBA890")]
		public static POHOKDOPBIA JJABNCIKDMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA650", Offset = "0x6BB9850", VA = "0x186BBA650")]
		public static POHOKDOPBIA CCGKEEAILHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA950", Offset = "0x6BB9B50", VA = "0x186BBA950")]
		public static POHOKDOPBIA KNNNMFJCNPE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA830", Offset = "0x6BB9A30", VA = "0x186BBA830")]
		public static POHOKDOPBIA IFPNDPHCLNI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA590", Offset = "0x6BB9790", VA = "0x186BBA590")]
		public static POHOKDOPBIA BFLMJNCCKAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA6B0", Offset = "0x6BB98B0", VA = "0x186BBA6B0")]
		public static POHOKDOPBIA CGKBNMKHKGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA5F0", Offset = "0x6BB97F0", VA = "0x186BBA5F0")]
		public static POHOKDOPBIA BOJDMDNCPOA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA9B0", Offset = "0x6BB9BB0", VA = "0x186BBA9B0")]
		public static POHOKDOPBIA NBBOOIEFLNK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA770", Offset = "0x6BB9970", VA = "0x186BBA770")]
		public static POHOKDOPBIA IAKPKPJDJLA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6BBAA10", Offset = "0x6BB9C10", VA = "0x186BBAA10")]
		public static POHOKDOPBIA NFEMPMFNKJA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6BBAAD0", Offset = "0x6BB9CD0", VA = "0x186BBAAD0")]
		public static POHOKDOPBIA POGELGJFJBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA8F0", Offset = "0x6BB9AF0", VA = "0x186BBA8F0")]
		public static POHOKDOPBIA KKCMIPFDKCB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class GKANMFFNJBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6BBAB30", Offset = "0x6BB9D30", VA = "0x186BBAB30")]
		public static POHOKDOPBIA FABDCMJDEBC(long KCAAOMDKNIH, long HPHKCHODKPD, bool GPPEOOCEMJJ, string JHGCPDCHALO, string OAPFGEPEHIF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class PJCCDFCMGCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6BC1B10", Offset = "0x6BC0D10", VA = "0x186BC1B10")]
		public static POHOKDOPBIA FFKIFLDHNEB(string CNJHAMLJOLL, string FOJLDOKKJKJ, bool NJMOEFBLPGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6BC1C80", Offset = "0x6BC0E80", VA = "0x186BC1C80")]
		public static POHOKDOPBIA NGOCEGJEGAB(string IBLIOEFMDMM, string LLEPMLNOJKD, string MFPGIOFJJCO, [Optional] int? CPHKKCPGPPB, [Optional] double[] OEJPNCJHKFO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class DJLGKAIHFAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6BB9AF0", Offset = "0x6BB8CF0", VA = "0x186BB9AF0")]
		public static POHOKDOPBIA HNKPBNOJFFC(string NPCNMHEMOEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6BB9590", Offset = "0x6BB8790", VA = "0x186BB9590")]
		public static POHOKDOPBIA AJEKCHMFBGL(string NPLKPHGKGPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6BB9BD0", Offset = "0x6BB8DD0", VA = "0x186BB9BD0")]
		public static POHOKDOPBIA JHALJEGHFOJ(int GMGPDOAAFEJ, string MBDFMCIDAOB, string JDNOHHGIHEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6BB9940", Offset = "0x6BB8B40", VA = "0x186BB9940")]
		public static POHOKDOPBIA CCNPOIBNEED(int GMGPDOAAFEJ, string MBDFMCIDAOB, string JDNOHHGIHEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6BB9C30", Offset = "0x6BB8E30", VA = "0x186BB9C30")]
		public static POHOKDOPBIA PNBFBEEHJOM(int GMGPDOAAFEJ, string MBDFMCIDAOB, string JDNOHHGIHEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6BB98E0", Offset = "0x6BB8AE0", VA = "0x186BB98E0")]
		public static POHOKDOPBIA BNECFOKIJAF(int GMGPDOAAFEJ, string MBDFMCIDAOB, string JDNOHHGIHEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6BB99A0", Offset = "0x6BB8BA0", VA = "0x186BB99A0")]
		public static POHOKDOPBIA CICNAEAOHMJ(string MBDFMCIDAOB, string JDNOHHGIHEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6BB97A0", Offset = "0x6BB89A0", VA = "0x186BB97A0")]
		private static POHOKDOPBIA BGHECPOPIII(string APLPDPCNINO, int GMGPDOAAFEJ, string FAFLIJEBPHC, string DEKOJDACPII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6BB9670", Offset = "0x6BB8870", VA = "0x186BB9670")]
		private static POHOKDOPBIA BGHECPOPIII(string APLPDPCNINO, string FAFLIJEBPHC, string DEKOJDACPII)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly PBBCGFNIILA IPKFDHIOJFD;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static APDBIEPKPGD PHHBHBAMAOG;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static CCCHMDLMIBJ CANPBFFPBLN;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<POHOKDOPBIA> KJCIBFPACGI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long AFGIIECALBI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6BB9F60", Offset = "0x6BB9160", VA = "0x186BB9F60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6BB9D50", Offset = "0x6BB8F50", VA = "0x186BB9D50")]
	[AEGEAJMGHGA.LGPOCIOLIAD]
	internal static void BPPGGBEBHKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6BB9C90", Offset = "0x6BB8E90", VA = "0x186BB9C90")]
	private static void AFLFELHKHKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6BBA160", Offset = "0x6BB9360", VA = "0x186BBA160")]
	public static POHOKDOPBIA MALBLIGAIKP(string EIJINJKPAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6BBA050", Offset = "0x6BB9250", VA = "0x186BBA050")]
	public static POHOKDOPBIA MALBLIGAIKP(string EIJINJKPAOB, int GMGPDOAAFEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6BB9E40", Offset = "0x6BB9040", VA = "0x186BB9E40")]
	[AEGEAJMGHGA.LGPOCIOLIAD]
	internal static void CMHANGDLBKK()
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
