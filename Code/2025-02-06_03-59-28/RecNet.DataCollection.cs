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
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x68BED90", Offset = "0x68BDB90", VA = "0x1868BED90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x920390", Offset = "0x91F190", VA = "0x180920390")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9203D0", Offset = "0x91F1D0", VA = "0x1809203D0")]
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
	public class LogRegistrationIndex : CGFLIBNDCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x68BD340", Offset = "0x68BC140", VA = "0x1868BD340", Slot = "4")]
		public override void EHDMJEMLBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x68C21A0", Offset = "0x68C0FA0", VA = "0x1868C21A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2408FF0", Offset = "0x2407DF0", VA = "0x182408FF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NJEHEOLAING
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> ANLMJPKBNEE();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EDNGPNMMEOK
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x68B9300", Offset = "0x68B8100", VA = "0x1868B9300")]
	public static void BNFDDDPFBFB(this NMLAFBBNCED.JDLHEEOEBBA BFMJINOLMIC, string AGEIABNDPIA, string EBMLOBFBAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x68B9170", Offset = "0x68B7F70", VA = "0x1868B9170")]
	public static void BNFDDDPFBFB(this NMLAFBBNCED.JDLHEEOEBBA BFMJINOLMIC, string AGEIABNDPIA, bool EBMLOBFBAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x68B9200", Offset = "0x68B8000", VA = "0x1868B9200")]
	public static void BNFDDDPFBFB(this NMLAFBBNCED.JDLHEEOEBBA BFMJINOLMIC, string AGEIABNDPIA, float IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x68B9370", Offset = "0x68B8170", VA = "0x1868B9370")]
	public static void BNFDDDPFBFB(this NMLAFBBNCED.JDLHEEOEBBA BFMJINOLMIC, string AGEIABNDPIA, AOHLJMMBEHE EBMLOBFBAOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class NMLAFBBNCED
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface JNANCFLGGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JDLHEEOEBBA FGDMAIMJDCL(Guid MNGOHBKCBKP, string OBJNNCEDCAK, [Optional] string EPEGCBJHLKJ, [Optional] long? CJCLBEGEAPD, [Optional] string NLMNIBPNGDG, [Optional] string PKLLLHOEAPC);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class NNFFGHNMILP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x68BD8A0", Offset = "0x68BC6A0", VA = "0x1868BD8A0")]
		public static JDLHEEOEBBA DOBFCOJMJFF(Guid MNGOHBKCBKP, string OBJNNCEDCAK, string EPEGCBJHLKJ, [Optional] long? CJCLBEGEAPD, [Optional] string NLMNIBPNGDG, [Optional] string PKLLLHOEAPC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class JDLHEEOEBBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected EJIOFCIGIDO NEPCFFIOLCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly IDictionary<string, IDictionary<string, object>> JKOIPKNFBBF;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool NOHDFCBGJNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x68BC070", Offset = "0x68BAE70", VA = "0x1868BC070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string EAFDGBDOHMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xF1CBD0", Offset = "0xF1B9D0", VA = "0x180F1CBD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x68BC870", Offset = "0x68BB670", VA = "0x1868BC870")]
		public JDLHEEOEBBA(EJIOFCIGIDO NEPCFFIOLCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x68BC7F0", Offset = "0x68BB5F0", VA = "0x1868BC7F0")]
		public JDLHEEOEBBA PHBIGIKBCJM(string AMBDMECJFHI, string IPHILEOFJLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x39DA630", Offset = "0x39D9430", VA = "0x1839DA630")]
		public JDLHEEOEBBA PHBIGIKBCJM<T>(string AMBDMECJFHI, T IPHILEOFJLB) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x68BC0B0", Offset = "0x68BAEB0", VA = "0x1868BC0B0")]
		public JDLHEEOEBBA HBJNENJLPOK(string AMBDMECJFHI, object IPHILEOFJLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x39DA5A0", Offset = "0x39D93A0", VA = "0x1839DA5A0")]
		public JDLHEEOEBBA IBAFKDHFBJN<T>(string AMBDMECJFHI, T? IPHILEOFJLB) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x68BC130", Offset = "0x68BAF30", VA = "0x1868BC130")]
		public JDLHEEOEBBA IBAFKDHFBJN(string AMBDMECJFHI, string IPHILEOFJLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x68BC300", Offset = "0x68BB100", VA = "0x1868BC300")]
		public JDLHEEOEBBA JFCNIFONBCL(string BGAMMBCJHMC, string FFOHLCGHDKA, object JOAPLPPIFPC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x68BC220", Offset = "0x68BB020", VA = "0x1868BC220")]
		public JDLHEEOEBBA JFCNIFONBCL(string BGAMMBCJHMC, IDictionary<string, object> OLAJDKDOKOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x68BC1C0", Offset = "0x68BAFC0", VA = "0x1868BC1C0")]
		private static IDictionary<string, object> IMKMNMAKBLE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x68BC540", Offset = "0x68BB340", VA = "0x1868BC540")]
		public void OGJLKMNLNML(bool ELGDODMALJG, string EHNLJDEMFLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x68BC440", Offset = "0x68BB240", VA = "0x1868BC440")]
		public Task LLIGLAPNLMD([Optional] CancellationToken FEHCANHDGHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x25203F0", Offset = "0x251F1F0", VA = "0x1825203F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class EJIOFCIGIDO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct JGKKJDOIMFJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public EJIOFCIGIDO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x68BC910", Offset = "0x68BB710", VA = "0x1868BC910", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x68BCD60", Offset = "0x68BBB60", VA = "0x1868BCD60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static Action<EJIOFCIGIDO> FDJHPBNPPHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly string CMBLAJKGABB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<string, object> DEJACFIJKGA;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string EAFDGBDOHMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x68B9FE0", Offset = "0x68B8DE0", VA = "0x1868B9FE0")]
		private EJIOFCIGIDO(string CMBLAJKGABB, int JFPAEBMEBNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x68B9CB0", Offset = "0x68B8AB0", VA = "0x1868B9CB0")]
		public static JDLHEEOEBBA DCMOGLEGFAE(string CMBLAJKGABB, int JFPAEBMEBNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x68B9E80", Offset = "0x68B8C80", VA = "0x1868B9E80")]
		[AsyncStateMachine(typeof(JGKKJDOIMFJ))]
		public Task LLIGLAPNLMD([Optional] CancellationToken FEHCANHDGHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x68B9F70", Offset = "0x68B8D70", VA = "0x1868B9F70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3093760", Offset = "0x3092560", VA = "0x183093760")]
		internal void KKIGFDGNLAC<T>(string AMBDMECJFHI, T IPHILEOFJLB) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x68B9DC0", Offset = "0x68B8BC0", VA = "0x1868B9DC0")]
		internal void JFJKIKAMMLL(string AMBDMECJFHI, object IPHILEOFJLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x68B9E20", Offset = "0x68B8C20", VA = "0x1868B9E20")]
		internal void KKIGFDGNLAC(string AMBDMECJFHI, string IPHILEOFJLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x39D8C30", Offset = "0x39D7A30", VA = "0x1839D8C30")]
		private void KNALMKMNCMI<T>(string AMBDMECJFHI, T IPHILEOFJLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct IGGJNOEGOHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string GBIFIABIMGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly long? IPJEADBLJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly short? MPMMCEPLDHI;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x68BAB30", Offset = "0x68B9930", VA = "0x1868BAB30")]
		public IGGJNOEGOHH(string KBBMCFICBGP, [Optional] long? OGMIFIGJENM, [Optional] short? LGNGKENLIGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct FHNANJMHLED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly int FNEKGICKJOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly string DJEOCNOKOBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly short HGFNCNPKNDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly string GGGMMBFJNMC;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x68BA320", Offset = "0x68B9120", VA = "0x1868BA320")]
		public FHNANJMHLED(int EMENHGJALNA, string JEHHAOKAKPG, short BJJIAMGBPLF, string LOCCCKIABKN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class JBPDFEIFKNB : FLIIBPMNHEG<JBFNOBDBFKF, FHNANJMHLED, IGGJNOEGOHH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string JEHHAOKAKPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private short BJJIAMGBPLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private string LOCCCKIABKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Dictionary<short, int> MODHMNAILHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int ALKLOABHCBB;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x68BBFF0", Offset = "0x68BADF0", VA = "0x1868BBFF0")]
		public JBPDFEIFKNB(string ENMMNOBEHAE, Guid EJIEILOLLIA, long OOLFINCIKKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x68BBD00", Offset = "0x68BAB00", VA = "0x1868BBD00", Slot = "4")]
		public override void MIIMICGFFNJ(FHNANJMHLED FEBBANLGDLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x68BAB70", Offset = "0x68B9970", VA = "0x1868BAB70")]
		public void CHGELLFHHAF(short BJJIAMGBPLF, bool GKANPJKJLDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x43797B0", Offset = "0x43785B0", VA = "0x1843797B0")]
		public void GLFEEOKGGEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8F4220", Offset = "0x8F3020", VA = "0x1808F4220")]
		public void GKKEDCADPME(string ADBKCLAPGDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x68BAC50", Offset = "0x68B9A50", VA = "0x1868BAC50", Slot = "5")]
		public override void DAODMGGBJHL(bool IHKPHDAAHLN, IGGJNOEGOHH JNAPJKJKNBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x68BBA40", Offset = "0x68BA840", VA = "0x1868BBA40", Slot = "6")]
		public override HFFLMGOOHOI FAALNBCMLGH(JBFNOBDBFKF PLEMGGECAPI, int KNCPCNBMDNF, string PPGAJAMICJG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class OCAFJCINMBC : HFFLMGOOHOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private string JEHHAOKAKPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly short BJJIAMGBPLF;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x68BEFD0", Offset = "0x68BDDD0", VA = "0x1868BEFD0")]
		public OCAFJCINMBC(long JAKPCLIAKMF, int EMENHGJALNA, string EPEGCBJHLKJ, long OOLFINCIKKG, int IEGGLJNENHL, string NLMNIBPNGDG, short BJJIAMGBPLF, string JEHHAOKAKPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x68BEF40", Offset = "0x68BDD40", VA = "0x1868BEF40")]
		public void OFOCCEJBKGK(int EMENHGJALNA, string JEHHAOKAKPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x68BEE10", Offset = "0x68BDC10", VA = "0x1868BEE10", Slot = "5")]
		public override JDLHEEOEBBA FGDMAIMJDCL(Guid MNGOHBKCBKP, string OBJNNCEDCAK, [Optional] string EPEGCBJHLKJ, [Optional] long? CJCLBEGEAPD, [Optional] string NLMNIBPNGDG, [Optional] string PKLLLHOEAPC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class NPFOPCOBKIN
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class APMBOAKEOBO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float nextEventSendTime;

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public APMBOAKEOBO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x68B89D0", Offset = "0x68B77D0", VA = "0x1868B89D0")]
			internal bool EPDPELGMCOH()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct PGCMMIGPKOI : IAsyncStateMachine
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
			private APMBOAKEOBO <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TimeSpan <delayPollingInterval>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x68C1140", Offset = "0x68BFF40", VA = "0x1868C1140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x68C1E30", Offset = "0x68C0C30", VA = "0x1868C1E30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct EEMFJBMMPOF : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x68B96C0", Offset = "0x68B84C0", VA = "0x1868B96C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x68B9C50", Offset = "0x68B8A50", VA = "0x1868B9C50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly float HMAJJFDIBII;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static DPIEDOFFLCF HMHLOFOACGH;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static CancellationTokenSource ONADNLJNPJE;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static bool BOCFDGCNBLI;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static int MJJIGLFJDPL;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly HPCPKCGMACP<JDLHEEOEBBA, bool> GLMEPLPAOPB;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static OODKHPOFHAN<JDLHEEOEBBA, bool> KAOJCHANCOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x68BDDB0", Offset = "0x68BCBB0", VA = "0x1868BDDB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static bool PAOKFJDKGOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x68BDC40", Offset = "0x68BCA40", VA = "0x1868BDC40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x68BE300", Offset = "0x68BD100", VA = "0x1868BE300")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private static bool LFEJEMILFJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x68BDAB0", Offset = "0x68BC8B0", VA = "0x1868BDAB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x68BDFC0", Offset = "0x68BCDC0", VA = "0x1868BDFC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private static float MINPFHHDONG
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x68BEB10", Offset = "0x68BD910", VA = "0x1868BEB10")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x68BDB00", Offset = "0x68BC900", VA = "0x1868BDB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x68BEB60", Offset = "0x68BD960", VA = "0x1868BEB60")]
		[IGIDCNKGIJD.GHJADADFOEE]
		internal static void PGCEAIILHMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x68BE100", Offset = "0x68BCF00", VA = "0x1868BE100")]
		internal static void JEELJGCJJCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x68BDE00", Offset = "0x68BCC00", VA = "0x1868BDE00")]
		internal static void IJPACGLADPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x68BE650", Offset = "0x68BD450", VA = "0x1868BE650")]
		internal static void MBAHIIJBOPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x68BDC90", Offset = "0x68BCA90", VA = "0x1868BDC90")]
		public static void FCAAJKHKMAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x68BE6C0", Offset = "0x68BD4C0", VA = "0x1868BE6C0")]
		private static void MDJBKLELNBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x68BE360", Offset = "0x68BD160", VA = "0x1868BE360")]
		private static void MAKHHHDOBHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x68BDCE0", Offset = "0x68BCAE0", VA = "0x1868BDCE0")]
		[AsyncStateMachine(typeof(PGCMMIGPKOI))]
		private static Task FIBALGANOPO(CancellationToken FEHCANHDGHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x68BE020", Offset = "0x68BCE20", VA = "0x1868BE020")]
		private static void INAKLHCGIMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x68BDB60", Offset = "0x68BC960", VA = "0x1868BDB60")]
		[AsyncStateMachine(typeof(EEMFJBMMPOF))]
		private static Task BLPLCGGHHKP(bool BAKGLOLKHBA, [Optional] CancellationToken FEHCANHDGHE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class MKKDBBODKEN<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class KLHALNMKIDG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public MKKDBBODKEN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public KLHALNMKIDG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x49D34F0", Offset = "0x49D22F0", VA = "0x1849D34F0")]
			internal object CGBMEDHOLIE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class GHHFPOHNJNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public MKKDBBODKEN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public GHHFPOHNJNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x44C23B0", Offset = "0x44C11B0", VA = "0x1844C23B0")]
			internal object FLOKELHGBFI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class KHFLGOMBOPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public MKKDBBODKEN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public KHFLGOMBOPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x49B49B0", Offset = "0x49B37B0", VA = "0x1849B49B0")]
			internal object LFBKNMCJEBB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class ACLOFBLKKHG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public MKKDBBODKEN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public ACLOFBLKKHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x447D430", Offset = "0x447C230", VA = "0x18447D430")]
			internal object DAOLLCKMAHD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class KJBFDGDOBHD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public MKKDBBODKEN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public KJBFDGDOBHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x49C12F0", Offset = "0x49C00F0", VA = "0x1849C12F0")]
			internal object JCMJMLPNHBB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const float DBAKIOCBELN = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Guid MNGOHBKCBKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly string NLMNIBPNGDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly string HMCFFBGNGEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string JCIBJOLPMID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private string PKLLLHOEAPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private string PGLDBOJJAIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private string CCEIPOLHBNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private string LAAFLDDLCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private string GNNLANBJGFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private string NAFCFFLFKFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private Guid? JACDHIGMKNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private (int, int)? LCLPNODDEKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly HashSet<T> BKMCJJAHIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly Dictionary<(T, int), string> KACKABENHLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly Dictionary<(T, int), float> ONJENIPOGFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly Dictionary<T, string> GGIALFNDOHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Dictionary<T, string[]> IEANNNMFNJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private string PEPPLLBCNJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private bool IBDCFPFNMGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Task BNIAMBMGHDH;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4CAE1D0", Offset = "0x4CACFD0", VA = "0x184CAE1D0")]
		public MKKDBBODKEN(Guid MNGOHBKCBKP, string HMCFFBGNGEA, string NLMNIBPNGDG, string JCIBJOLPMID, [Optional] string PKLLLHOEAPC, [Optional] string PGLDBOJJAIM, [Optional] string CCEIPOLHBNA, [Optional] string NAFCFFLFKFM, [Optional] string PEPPLLBCNJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8F4480", Offset = "0x8F3280", VA = "0x1808F4480")]
		public void LDKFHOHDPFB(string PKLLLHOEAPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B30", Offset = "0x8F6930", VA = "0x1808F7B30")]
		public void LOKBOLHGHNH(string JCIBJOLPMID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xD01130", Offset = "0xCFFF30", VA = "0x180D01130")]
		public void BKGHNOPALBK(string PEPPLLBCNJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8F4250", Offset = "0x8F3050", VA = "0x1808F4250")]
		public void BDMDEOMNNIH(string LAAFLDDLCIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4CAE1C0", Offset = "0x4CACFC0", VA = "0x184CAE1C0")]
		public void NPDNMGIAJEH(Guid? MNGOHBKCBKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x3FE6DA0", Offset = "0x3FE5BA0", VA = "0x183FE6DA0")]
		public void DLADDBJCPFL((int, int)? LCLPNODDEKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8F4470", Offset = "0x8F3270", VA = "0x1808F4470")]
		public void EINGODIHJBB(string GNNLANBJGFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4CAA990", Offset = "0x4CA9790", VA = "0x184CAA990")]
		public void JOALDIOEONE(T CJCLBEGEAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4CAB380", Offset = "0x4CAA180", VA = "0x184CAB380")]
		public void LFIBEFMJFAC(T CJCLBEGEAPD, int KPOJHPBLLLP, float ENFBFHBOFDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4CA9670", Offset = "0x4CA8470", VA = "0x184CA9670")]
		public void FHHOBICDNBH(T CJCLBEGEAPD, int KPOJHPBLLLP, string JGPAHPLCPNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4CA90B0", Offset = "0x4CA7EB0", VA = "0x184CA90B0")]
		public void CIOMOFNOOEO(T CJCLBEGEAPD, string IPHJMBDJDJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4CAE010", Offset = "0x4CACE10", VA = "0x184CAE010")]
		public void NMEEADKMGOI(T CJCLBEGEAPD, string[] ACOGMPKKPLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4CAD120", Offset = "0x4CABF20", VA = "0x184CAD120")]
		public Task LLIGLAPNLMD(bool MKKNPGPEIPF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4CA7C90", Offset = "0x4CA6A90", VA = "0x184CA7C90")]
		private (IEnumerable<T>, string) BFPFKFOHCBJ()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4CAA1E0", Offset = "0x4CA8FE0", VA = "0x184CAA1E0")]
		public static JDLHEEOEBBA IHADLOHOKMO(Guid MNGOHBKCBKP, string HMCFFBGNGEA, T CJCLBEGEAPD, string NLMNIBPNGDG, string OBOGILMBFBJ, string PKLLLHOEAPC, int? KNCPCNBMDNF, [Optional] string ENDOBDPCKGE, [Optional] string IPHJMBDJDJN, [Optional] int? JHCMAEPOGAC, [Optional] Guid? JACDHIGMKNH, [Optional] string PEPPLLBCNJD, [Optional] string EPEGCBJHLKJ, [Optional] (int, int)? LCLPNODDEKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4CAAEF0", Offset = "0x4CA9CF0", VA = "0x184CAAEF0")]
		[CompilerGenerated]
		private string KMNABBKJAFE(T MIFPCBFGGLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x4CA9BA0", Offset = "0x4CA89A0", VA = "0x184CA9BA0")]
		[CompilerGenerated]
		private string HFKEFONHPMG(T MIFPCBFGGLI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class FLIIBPMNHEG<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		protected readonly string ENMMNOBEHAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		protected readonly Guid EJIEILOLLIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		protected readonly long OOLFINCIKKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		protected int EMENHGJALNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		protected int KMHMHMCPBAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		protected DateTime MIAFFEKKNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		protected bool DDKELLFIGLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		protected Dictionary<long, HFFLMGOOHOI> DMPFAOPMMGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		protected bool EKPMDDLGAMD;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool KPNNPKOKIEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xADD5B0", Offset = "0xADC3B0", VA = "0x180ADD5B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IKNFOECOFHI
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xB45480", Offset = "0xB44280", VA = "0x180B45480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x43CC6B0", Offset = "0x43CB4B0", VA = "0x1843CC6B0")]
		public FLIIBPMNHEG(string ENMMNOBEHAE, Guid EJIEILOLLIA, long OOLFINCIKKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void MIIMICGFFNJ(TListSessionStartParams FEBBANLGDLC);

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xFBF370", Offset = "0xFBE170", VA = "0x180FBF370")]
		public void GNAMKBEKJPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void DAODMGGBJHL(bool IHKPHDAAHLN, TListSessionLogParams JNAPJKJKNBL);

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x43CC350", Offset = "0x43CB150", VA = "0x1843CC350")]
		public void DKOAKAFJJPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x43CC3F0", Offset = "0x43CB1F0", VA = "0x1843CC3F0")]
		public void GPNECMNIMIE(long JAKPCLIAKMF, int KNCPCNBMDNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x43CC590", Offset = "0x43CB390", VA = "0x1843CC590")]
		public void LLMFBIFOFJP(long JAKPCLIAKMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract HFFLMGOOHOI FAALNBCMLGH(TItem MJONLBMPPCK, int KNCPCNBMDNF, string PPGAJAMICJG);
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class HFFLMGOOHOI : JNANCFLGGFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private int EMENHGJALNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private long JAKPCLIAKMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private long OOLFINCIKKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly string GBFOEAKFGJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly string MFAIDJOFOOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly int IEGGLJNENHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private DateTime FDEMLAKIKJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private double EJBBMBKOEGE;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HGOEPABFHFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xCE57F0", Offset = "0xCE45F0", VA = "0x180CE57F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xCE4AC0", Offset = "0xCE38C0", VA = "0x180CE4AC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x68BAA60", Offset = "0x68B9860", VA = "0x1868BAA60")]
		public HFFLMGOOHOI(long JAKPCLIAKMF, int EMENHGJALNA, string EPEGCBJHLKJ, long OOLFINCIKKG, int IEGGLJNENHL, [Optional] string NLMNIBPNGDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x68BA930", Offset = "0x68B9730", VA = "0x1868BA930")]
		public void GKCPKINFEFL(int EMENHGJALNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x68BA9A0", Offset = "0x68B97A0", VA = "0x1868BA9A0")]
		public void LMCJAPKJHON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x68BA370", Offset = "0x68B9170", VA = "0x1868BA370")]
		public void EGLNOMICNEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x68BA9F0", Offset = "0x68B97F0", VA = "0x1868BA9F0")]
		private void PDDKHGMKHHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x68BA480", Offset = "0x68B9280", VA = "0x1868BA480", Slot = "5")]
		public virtual JDLHEEOEBBA FGDMAIMJDCL(Guid MNGOHBKCBKP, string OBJNNCEDCAK, [Optional] string EPEGCBJHLKJ, [Optional] long? CJCLBEGEAPD, [Optional] string NLMNIBPNGDG, [Optional] string PKLLLHOEAPC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class OFFLDLFGCHB
	{
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static Dictionary<string, Dictionary<string, object>> HJDABNOOMMC;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static string MBIKNCLLALP;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static int BGMDNAIHAOE;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly Dictionary<string, NJEHEOLAING> CNGEKLHLCNL;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static string IOPIKLJOALA
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x68C00E0", Offset = "0x68BEEE0", VA = "0x1868C00E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x68C09B0", Offset = "0x68BF7B0", VA = "0x1868C09B0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool CGIPDBLIDEN
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x68BF2B0", Offset = "0x68BE0B0", VA = "0x1868BF2B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static Dictionary<string, Dictionary<string, object>> LLPJLECIKPF
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x68BF790", Offset = "0x68BE590", VA = "0x1868BF790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static Guid? EFMMNOIBMIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x68BFA40", Offset = "0x68BE840", VA = "0x1868BFA40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x68BF730", Offset = "0x68BE530", VA = "0x1868BF730")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static Guid? CFECDOCFFKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x68BFAB0", Offset = "0x68BE8B0", VA = "0x1868BFAB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x68C0130", Offset = "0x68BEF30", VA = "0x1868C0130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x68C0A70", Offset = "0x68BF870", VA = "0x1868C0A70")]
		public static void PPIANCBLKNN(string PLNKKPBDMMH, NJEHEOLAING DMMBKKKLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x68BFC00", Offset = "0x68BEA00", VA = "0x1868BFC00")]
		internal static void JEELJGCJJCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x68BFB20", Offset = "0x68BE920", VA = "0x1868BFB20")]
		internal static void IJPACGLADPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x68C02B0", Offset = "0x68BF0B0", VA = "0x1868C02B0")]
		internal static void MBAHIIJBOPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x68C03D0", Offset = "0x68BF1D0", VA = "0x1868C03D0")]
		public static Guid MIIMICGFFNJ(string PLNKKPBDMMH, [Optional] string? HPBFLANECBP, [Optional] Dictionary<string, object>? CIPDFCDNNIM)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x68C0330", Offset = "0x68BF130", VA = "0x1868C0330")]
		public static Guid MIIMICGFFNJ(string PLNKKPBDMMH, long HPBFLANECBP, [Optional] Dictionary<string, object>? CIPDFCDNNIM)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x68BF7E0", Offset = "0x68BE5E0", VA = "0x1868BF7E0")]
		public static void GNAMKBEKJPM(string PLNKKPBDMMH, [Optional] Guid? OGOMDMBFOMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x68BF340", Offset = "0x68BE140", VA = "0x1868BF340")]
		public static void DDOBMEGJEDH(string PLNKKPBDMMH, string BGAMMBCJHMC, object BEOHMJELECP, bool BOCFDGCNBLI = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x68BF0C0", Offset = "0x68BDEC0", VA = "0x1868BF0C0")]
		public static bool ALIPPPIHEKM(string PLNKKPBDMMH, [Optional] string? HPBFLANECBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x68BF550", Offset = "0x68BE350", VA = "0x1868BF550")]
		private static void DJIBNOENOHE(bool NFICKDDKJKK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x68BF6D0", Offset = "0x68BE4D0", VA = "0x1868BF6D0")]
		public static void EKMHJLLBJNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x68C0190", Offset = "0x68BEF90", VA = "0x1868C0190")]
		private static void MAKHHHDOBHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x68BFCE0", Offset = "0x68BEAE0", VA = "0x1868BFCE0")]
		private static void JMODFAEECDA(string PLNKKPBDMMH, Guid MNGOHBKCBKP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class OKIOAFLAKLO
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public struct NDLIGKFLBLG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public bool AAIFAFJIHJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public string PGIAAHGDEIH;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xAFF4C0", Offset = "0xAFE2C0", VA = "0x180AFF4C0")]
			public NDLIGKFLBLG(bool AAIFAFJIHJG, string PGIAAHGDEIH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x68C0D60", Offset = "0x68BFB60", VA = "0x1868C0D60")]
		public static NDLIGKFLBLG KAMAHCNLDOK(JDLHEEOEBBA BFMJINOLMIC)
		{
			return default(NDLIGKFLBLG);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x68C0C60", Offset = "0x68BFA60", VA = "0x1868C0C60")]
		private static void BPEIFKAABAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x68C1080", Offset = "0x68BFE80", VA = "0x1868C1080")]
		private static void MDMAGBKGKGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class ALEFDGGGFAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x68B83D0", Offset = "0x68B71D0", VA = "0x1868B83D0")]
		public static JDLHEEOEBBA ALJMHLGDNPH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class ALIMIJFBHJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x68B8670", Offset = "0x68B7470", VA = "0x1868B8670")]
		public static JDLHEEOEBBA EIPEHFMFEPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x68B8430", Offset = "0x68B7230", VA = "0x1868B8430")]
		public static JDLHEEOEBBA ACPKKGJEEAH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x68B8490", Offset = "0x68B7290", VA = "0x1868B8490")]
		public static JDLHEEOEBBA ANNCNHDOOLA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x68B8730", Offset = "0x68B7530", VA = "0x1868B8730")]
		public static JDLHEEOEBBA FOJKMHPPKPM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x68B8790", Offset = "0x68B7590", VA = "0x1868B8790")]
		public static JDLHEEOEBBA JFDAHOIGOOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x68B88B0", Offset = "0x68B76B0", VA = "0x1868B88B0")]
		public static JDLHEEOEBBA MCAKDBJCCCG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x68B86D0", Offset = "0x68B74D0", VA = "0x1868B86D0")]
		public static JDLHEEOEBBA FJCADEJCNHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x68B87F0", Offset = "0x68B75F0", VA = "0x1868B87F0")]
		public static JDLHEEOEBBA KCEPJDHNIML()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x68B85B0", Offset = "0x68B73B0", VA = "0x1868B85B0")]
		public static JDLHEEOEBBA CPENKCEAADH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x68B8550", Offset = "0x68B7350", VA = "0x1868B8550")]
		public static JDLHEEOEBBA CLMGBPEHKPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x68B84F0", Offset = "0x68B72F0", VA = "0x1868B84F0")]
		public static JDLHEEOEBBA BGMEKDMDMNC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x68B8850", Offset = "0x68B7650", VA = "0x1868B8850")]
		public static JDLHEEOEBBA LMMPKDGBHPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x68B8910", Offset = "0x68B7710", VA = "0x1868B8910")]
		public static JDLHEEOEBBA NLFOBKOEKOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x68B8610", Offset = "0x68B7410", VA = "0x1868B8610")]
		public static JDLHEEOEBBA DBCGDOHDFDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x68B8970", Offset = "0x68B7770", VA = "0x1868B8970")]
		public static JDLHEEOEBBA PBEAHNFKKOI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class JNJGMDOEFKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x68BCDC0", Offset = "0x68BBBC0", VA = "0x1868BCDC0")]
		public static JDLHEEOEBBA BDMKGMEMFKD(long OGMIFIGJENM, long MGNAIIKHEOI, bool CDKJKCKJCLJ, string AGPEPBJBADE, string LCKDMNBMMLK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class KPLPKGCNNFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x68BCFA0", Offset = "0x68BBDA0", VA = "0x1868BCFA0")]
		public static JDLHEEOEBBA GCFGMJMMCEN(string HBJKHAIFGCH, string OGHCEBFDGGN, bool EICBHBPFONO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x68BD110", Offset = "0x68BBF10", VA = "0x1868BD110")]
		public static JDLHEEOEBBA HLCHNBCNMGH(string MOBMLKIIAJP, string FPLEEPOHAOC, string IJGIJMBLPFF, [Optional] int? ANKIECBFLAK, [Optional] double[] AJDMFFEGMKI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class DMDNGGDIFHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x68B8E20", Offset = "0x68B7C20", VA = "0x1868B8E20")]
		public static JDLHEEOEBBA KENDHDMAILA(string AIMCGHMILKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x68B8CE0", Offset = "0x68B7AE0", VA = "0x1868B8CE0")]
		public static JDLHEEOEBBA DDMKHNGCPMB(string EHGFGHDIGNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x68B8DC0", Offset = "0x68B7BC0", VA = "0x1868B8DC0")]
		public static JDLHEEOEBBA HEFDBAALKIP(int JFPAEBMEBNC, string PPKJBGAOBJL, string MIFPCBFGGLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x68B90B0", Offset = "0x68B7EB0", VA = "0x1868B90B0")]
		public static JDLHEEOEBBA PLLBCDICHPB(int JFPAEBMEBNC, string PPKJBGAOBJL, string MIFPCBFGGLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x68B9110", Offset = "0x68B7F10", VA = "0x1868B9110")]
		public static JDLHEEOEBBA PNBEHHELBHH(int JFPAEBMEBNC, string PPKJBGAOBJL, string MIFPCBFGGLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x68B8F00", Offset = "0x68B7D00", VA = "0x1868B8F00")]
		public static JDLHEEOEBBA KJOMMHGHFNF(int JFPAEBMEBNC, string PPKJBGAOBJL, string MIFPCBFGGLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x68B8F60", Offset = "0x68B7D60", VA = "0x1868B8F60")]
		public static JDLHEEOEBBA LJJBPMCHMCP(string PPKJBGAOBJL, string MIFPCBFGGLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x68B8A70", Offset = "0x68B7870", VA = "0x1868B8A70")]
		private static JDLHEEOEBBA AKKOBDJGLLD(string ENMMNOBEHAE, int JFPAEBMEBNC, string PAIGLLBFODH, string JGPHNGDKKEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x68B8BB0", Offset = "0x68B79B0", VA = "0x1868B8BB0")]
		private static JDLHEEOEBBA AKKOBDJGLLD(string ENMMNOBEHAE, string PAIGLLBFODH, string JGPHNGDKKEN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly IMOCAMGHNDM KAMAHCNLDOK;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static APGKKIHKPFK NGOGICJFNDP;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static OAPMCPIPKPI IGGGJABBDGJ;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<JDLHEEOEBBA> IAMAPOKOGEM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long IEKBFCLLLAD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x68BD4F0", Offset = "0x68BC2F0", VA = "0x1868BD4F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x68BD730", Offset = "0x68BC530", VA = "0x1868BD730")]
	[IGIDCNKGIJD.GHJADADFOEE]
	internal static void MHKPNJJHBBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x68BD660", Offset = "0x68BC460", VA = "0x1868BD660")]
	private static void LHCCJBDPFPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x68BD5E0", Offset = "0x68BC3E0", VA = "0x1868BD5E0")]
	public static JDLHEEOEBBA LDMCGANLGOD(string CMBLAJKGABB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x68B9CB0", Offset = "0x68B8AB0", VA = "0x1868B9CB0")]
	public static JDLHEEOEBBA LDMCGANLGOD(string CMBLAJKGABB, int JFPAEBMEBNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x68BD3D0", Offset = "0x68BC1D0", VA = "0x1868BD3D0")]
	[IGIDCNKGIJD.GHJADADFOEE]
	internal static void GHEKBPEPIGO()
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
