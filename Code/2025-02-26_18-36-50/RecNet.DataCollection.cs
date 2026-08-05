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
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A71750", Offset = "0x6A70B50", VA = "0x186A71750")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x975680", Offset = "0x974A80", VA = "0x180975680")]
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
		[Cpp2IlInjected.Address(RVA = "0x9756C0", Offset = "0x974AC0", VA = "0x1809756C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A6F330", Offset = "0x6A6E730", VA = "0x186A6F330", Slot = "4")]
		public override void OCICFIBHEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A71EC0", Offset = "0x6A712C0", VA = "0x186A71EC0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x242AF30", Offset = "0x242A330", VA = "0x18242AF30")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A6C7F0", Offset = "0x6A6BBF0", VA = "0x186A6C7F0")]
	public static void CHKGLMHHBMF(this EPFDINNLAOJ.GMCIPLKCNGP BGJAJNGKGGN, string HLEODLKDBHE, string NOGKIPDCPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C860", Offset = "0x6A6BC60", VA = "0x186A6C860")]
	public static void CHKGLMHHBMF(this EPFDINNLAOJ.GMCIPLKCNGP BGJAJNGKGGN, string HLEODLKDBHE, bool NOGKIPDCPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C8F0", Offset = "0x6A6BCF0", VA = "0x186A6C8F0")]
	public static void CHKGLMHHBMF(this EPFDINNLAOJ.GMCIPLKCNGP BGJAJNGKGGN, string HLEODLKDBHE, float KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C490", Offset = "0x6A6B890", VA = "0x186A6C490")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A6D9A0", Offset = "0x6A6CDA0", VA = "0x186A6D9A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A6CFD0", Offset = "0x6A6C3D0", VA = "0x186A6CFD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string FNFNOFHJOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xF04FD0", Offset = "0xF043D0", VA = "0x180F04FD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D200", Offset = "0x6A6C600", VA = "0x186A6D200")]
		public GMCIPLKCNGP(NGKNGCBAEGI NBGBHBICCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6A6CF50", Offset = "0x6A6C350", VA = "0x186A6CF50")]
		public GMCIPLKCNGP HHDHNPBMKNK(string KKCCAKAEMAH, string KBGCCIOIGBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3AC4EC0", Offset = "0x3AC42C0", VA = "0x183AC4EC0")]
		public GMCIPLKCNGP HHDHNPBMKNK<T>(string KKCCAKAEMAH, T KBGCCIOIGBD) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6A6CED0", Offset = "0x6A6C2D0", VA = "0x186A6CED0")]
		public GMCIPLKCNGP FLJNPKFNELD(string KKCCAKAEMAH, object KBGCCIOIGBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3AC5250", Offset = "0x3AC4650", VA = "0x183AC5250")]
		public GMCIPLKCNGP NLDMCDIANLJ<T>(string KKCCAKAEMAH, T? KBGCCIOIGBD) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D170", Offset = "0x6A6C570", VA = "0x186A6D170")]
		public GMCIPLKCNGP NLDMCDIANLJ(string KKCCAKAEMAH, string KBGCCIOIGBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6A6C9F0", Offset = "0x6A6BDF0", VA = "0x186A6C9F0")]
		public GMCIPLKCNGP AJOMPAMKBMP(string PKALCDFCFBF, string LKMGECEEGEE, object GIDGOODJFLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6A6CB30", Offset = "0x6A6BF30", VA = "0x186A6CB30")]
		public GMCIPLKCNGP AJOMPAMKBMP(string PKALCDFCFBF, IDictionary<string, object> BHJLHIOPPEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D010", Offset = "0x6A6C410", VA = "0x186A6D010")]
		private static IDictionary<string, object> MANGDKMFJNL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6A6CC10", Offset = "0x6A6C010", VA = "0x186A6CC10")]
		public void CIDEKIJJAPH(bool OKIGMPKHPAB, string AJKBPDIMNDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D070", Offset = "0x6A6C470", VA = "0x186A6D070")]
		public Task NBOIDEIKMKH([Optional] CancellationToken LAEIHJHNGEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x253FC80", Offset = "0x253F080", VA = "0x18253FC80", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A712A0", Offset = "0x6A706A0", VA = "0x186A712A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6A716F0", Offset = "0x6A70AF0", VA = "0x186A716F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6A708C0", Offset = "0x6A6FCC0", VA = "0x186A708C0")]
		private NGKNGCBAEGI(string AFCDMPICECP, int NJNOPMJJKAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6A6BE60", Offset = "0x6A6B260", VA = "0x186A6BE60")]
		public static GMCIPLKCNGP OILMBKHFGKP(string AFCDMPICECP, int NJNOPMJJKAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6A70760", Offset = "0x6A6FB60", VA = "0x186A70760")]
		[AsyncStateMachine(typeof(NPDJKHPHIKM))]
		public Task NBOIDEIKMKH([Optional] CancellationToken LAEIHJHNGEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6A70850", Offset = "0x6A6FC50", VA = "0x186A70850", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x34281F0", Offset = "0x34275F0", VA = "0x1834281F0")]
		internal void FODKDFJKBDL<T>(string KKCCAKAEMAH, T KBGCCIOIGBD) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6A70700", Offset = "0x6A6FB00", VA = "0x186A70700")]
		internal void GDOJHJPIKLM(string KKCCAKAEMAH, object KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6A706A0", Offset = "0x6A6FAA0", VA = "0x186A706A0")]
		internal void FODKDFJKBDL(string KKCCAKAEMAH, string KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3AC80C0", Offset = "0x3AC74C0", VA = "0x183AC80C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A71B70", Offset = "0x6A70F70", VA = "0x186A71B70")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A6C440", Offset = "0x6A6B840", VA = "0x186A6C440")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A6BD80", Offset = "0x6A6B180", VA = "0x186A6BD80")]
		public DPIKNLEAAPM(string JHFJAFCMJGA, Guid KJHECKFPDFG, long PNHEMONCBEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6A6B9B0", Offset = "0x6A6ADB0", VA = "0x186A6B9B0", Slot = "4")]
		public override void FJEPPMDLGDF(FNDMNCJIIML OKMEDGAPPCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6A6BCA0", Offset = "0x6A6B0A0", VA = "0x186A6BCA0")]
		public void GFDJEFMAIPC(short DNFKGLFBNLF, bool JKJPNIMMCGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x439E920", Offset = "0x439DD20", VA = "0x18439E920")]
		public void CDKLLIOHDFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x94FD10", Offset = "0x94F110", VA = "0x18094FD10")]
		public void OJOAAODDDEI(string KIFEMDHNLDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6A6ABC0", Offset = "0x6A69FC0", VA = "0x186A6ABC0", Slot = "5")]
		public override void CCCPOAHOFEK(bool JBABOHBKBDK, PONHNKPPJIK DLGCHLJGCMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6A6A900", Offset = "0x6A69D00", VA = "0x186A6A900", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A6E4F0", Offset = "0x6A6D8F0", VA = "0x186A6E4F0")]
		public LHNCMCPNGAC(long GOBDDMLNCNK, int LCDILMPPDOG, string NHAJGGCEPLN, long PNHEMONCBEB, int KNCNKFIDAHL, string HHGJFFFBELN, short DNFKGLFBNLF, string KDLILMAPFGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E460", Offset = "0x6A6D860", VA = "0x186A6E460")]
		public void PHKDOFKCHKG(int LCDILMPPDOG, string KDLILMAPFGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E330", Offset = "0x6A6D730", VA = "0x186A6E330", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public NJFJFKIFEEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6A71200", Offset = "0x6A70600", VA = "0x186A71200")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A6E5E0", Offset = "0x6A6D9E0", VA = "0x186A6E5E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6A6F2D0", Offset = "0x6A6E6D0", VA = "0x186A6F2D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A70C10", Offset = "0x6A70010", VA = "0x186A70C10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6A711A0", Offset = "0x6A705A0", VA = "0x186A711A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A6F480", Offset = "0x6A6E880", VA = "0x186A6F480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static bool IGGLPDCGIMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6A70030", Offset = "0x6A6F430", VA = "0x186A70030")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6A6F3C0", Offset = "0x6A6E7C0", VA = "0x186A6F3C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private static bool OAHFGHGCAGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6A6F4D0", Offset = "0x6A6E8D0", VA = "0x186A6F4D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6A6FD80", Offset = "0x6A6F180", VA = "0x186A6FD80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private static float AKDPPNCFIIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6A6FDE0", Offset = "0x6A6F1E0", VA = "0x186A6FDE0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6A6F420", Offset = "0x6A6E820", VA = "0x186A6F420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6A6FF10", Offset = "0x6A6F310", VA = "0x186A6FF10")]
		[ONDAMKAMKDB.LAIHOOOIOBJ]
		internal static void LMLMKGJHIKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F520", Offset = "0x6A6E920", VA = "0x186A6F520")]
		internal static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6A6FAF0", Offset = "0x6A6EEF0", VA = "0x186A6FAF0")]
		internal static void IHILNAOKAGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6A70080", Offset = "0x6A6F480", VA = "0x186A70080")]
		internal static void NCMDGGLGNAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6A70540", Offset = "0x6A6F940", VA = "0x186A70540")]
		public static void OCICFBAINMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6A700F0", Offset = "0x6A6F4F0", VA = "0x186A700F0")]
		private static void NPJHCCOKKGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F800", Offset = "0x6A6EC00", VA = "0x186A6F800")]
		private static void IAAFPEIGDED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6A6FCB0", Offset = "0x6A6F0B0", VA = "0x186A6FCB0")]
		[AsyncStateMachine(typeof(LKKHAFGKIMI))]
		private static Task IKFCHHFCIMH(CancellationToken LAEIHJHNGEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F720", Offset = "0x6A6EB20", VA = "0x186A6F720")]
		private static void HPLNDCCLLGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6A6FE30", Offset = "0x6A6F230", VA = "0x186A6FE30")]
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
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public EMEBHJJFGHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x401F9A0", Offset = "0x401EDA0", VA = "0x18401F9A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public KGHGCHFHDBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4A4FC30", Offset = "0x4A4F030", VA = "0x184A4FC30")]
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
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public CGJIMMBBLDK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x5A3F180", Offset = "0x5A3E580", VA = "0x185A3F180")]
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
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public DOKAPLJDMPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x62CB300", Offset = "0x62CA700", VA = "0x1862CB300")]
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
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public NOAJFPPIPAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x4E8C510", Offset = "0x4E8B910", VA = "0x184E8C510")]
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
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public KALCGDDKDDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x4A36F90", Offset = "0x4A36390", VA = "0x184A36F90")]
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
		[Cpp2IlInjected.Address(RVA = "0x62C9070", Offset = "0x62C8470", VA = "0x1862C9070")]
		public DNLIBJHOMEC(Guid JKHDHJCLOPL, string ODGNPHEMLDC, string HHGJFFFBELN, string IJOPCCHPFFE, [Optional] string EMFOOALOJPO, [Optional] string BCCAKJIJNBC, [Optional] string GHEHENBBMDC, [Optional] string DOEGOJJEDJH, [Optional] string MLEDPNIAIAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x94FAD0", Offset = "0x94EED0", VA = "0x18094FAD0")]
		public void MBJEKGEENGG(string EMFOOALOJPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x94D470", Offset = "0x94C870", VA = "0x18094D470")]
		public void IKBMDFKPIIG(string IJOPCCHPFFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xF73B50", Offset = "0xF72F50", VA = "0x180F73B50")]
		public void JBNLEPBKMBC(string MLEDPNIAIAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x94FB10", Offset = "0x94EF10", VA = "0x18094FB10")]
		public void JPGJAEGHBFG(string JKCGHENFEMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x94FD10", Offset = "0x94F110", VA = "0x18094FD10")]
		public void BCPPKFMLCOK(string LMEMKNINDBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x62C3870", Offset = "0x62C2C70", VA = "0x1862C3870")]
		public void FHAIOKHFAJL(Guid? JKHDHJCLOPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1B2FF60", Offset = "0x1B2F360", VA = "0x181B2FF60")]
		public void BNCNPDJDJCL((int, int)? MLLFPKBAJIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x94FD40", Offset = "0x94F140", VA = "0x18094FD40")]
		public void PCCMEMPOELD(string FGFIFELLKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x62C63B0", Offset = "0x62C57B0", VA = "0x1862C63B0")]
		public void LKFHPHHFIDH(T PGBFDPMMEBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x62C26F0", Offset = "0x62C1AF0", VA = "0x1862C26F0")]
		public void AFHFDOMLLIL(T PGBFDPMMEBI, int JDOJDDHNDMA, float LKDAAJDJIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x62C2BD0", Offset = "0x62C1FD0", VA = "0x1862C2BD0")]
		public void EBBKFNIFKHB(T PGBFDPMMEBI, int JDOJDDHNDMA, string FCCCBCHFBGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x62C5D30", Offset = "0x62C5130", VA = "0x1862C5D30")]
		public void KCNEPNLOABJ(T PGBFDPMMEBI, string CJBNKLPJJFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x62C36C0", Offset = "0x62C2AC0", VA = "0x1862C36C0")]
		public void EIIIKEDDAAL(T PGBFDPMMEBI, string FOGKBJDKIMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x62C4CB0", Offset = "0x62C40B0", VA = "0x1862C4CB0")]
		public void HGNMBFJDLBK(T PGBFDPMMEBI, string[] NOHHGCNPHNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x62C7250", Offset = "0x62C6650", VA = "0x1862C7250")]
		public Task NBOIDEIKMKH(bool MHOOEDPKADD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x62C3890", Offset = "0x62C2C90", VA = "0x1862C3890")]
		private (IEnumerable<T>, string) GDBJCFHGJFD()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x62C5000", Offset = "0x62C4400", VA = "0x1862C5000")]
		public static GMCIPLKCNGP HIMPNHAPEGM(Guid JKHDHJCLOPL, string ODGNPHEMLDC, T PGBFDPMMEBI, string HHGJFFFBELN, string BGIAKAOMINL, string EMFOOALOJPO, int? EAHKFAJBNDN, [Optional] string IBBJMPKAHGD, [Optional] string CJBNKLPJJFC, [Optional] int? LCKGGGAJJFA, [Optional] Guid? CPNGEOIJLOG, [Optional] string MLEDPNIAIAL, [Optional] string NHAJGGCEPLN, [Optional] (int, int)? MLLFPKBAJIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x62C8EC0", Offset = "0x62C82C0", VA = "0x1862C8EC0")]
		[CompilerGenerated]
		private string NNJPPLBGIMD(T KGHCKLKGJKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x62C2A20", Offset = "0x62C1E20", VA = "0x1862C2A20")]
		[CompilerGenerated]
		private string BANAOOACHJF(T KGHCKLKGJKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x62C8D20", Offset = "0x62C8120", VA = "0x1862C8D20")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA6A10", Offset = "0xAA5E10", VA = "0x180AA6A10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool CDAGOCIPHBO
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xAF41B0", Offset = "0xAF35B0", VA = "0x180AF41B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x43DD690", Offset = "0x43DCA90", VA = "0x1843DD690")]
		public FNAMINIIBJJ(string JHFJAFCMJGA, Guid KJHECKFPDFG, long PNHEMONCBEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void FJEPPMDLGDF(TListSessionStartParams OKMEDGAPPCL);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x43DD490", Offset = "0x43DC890", VA = "0x1843DD490")]
		public void HIHHGDLPMLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void CCCPOAHOFEK(bool JBABOHBKBDK, TListSessionLogParams DLGCHLJGCMP);

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x43DD2A0", Offset = "0x43DC6A0", VA = "0x1843DD2A0")]
		public void GBNPEOOPIBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x43DD2F0", Offset = "0x43DC6F0", VA = "0x1843DD2F0")]
		public void HGHPMENAECD(long GOBDDMLNCNK, int EAHKFAJBNDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x43DD4A0", Offset = "0x43DC8A0", VA = "0x1843DD4A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCBE180", Offset = "0xCBD580", VA = "0x180CBE180")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xCBE8E0", Offset = "0xCBDCE0", VA = "0x180CBE8E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6A687B0", Offset = "0x6A67BB0", VA = "0x186A687B0")]
		public BPOCDGAPBLA(long GOBDDMLNCNK, int LCDILMPPDOG, string NHAJGGCEPLN, long PNHEMONCBEB, int KNCNKFIDAHL, [Optional] string HHGJFFFBELN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6A68680", Offset = "0x6A67A80", VA = "0x186A68680")]
		public void LJDCFKCNHBI(int LCDILMPPDOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6A68760", Offset = "0x6A67B60", VA = "0x186A68760")]
		public void NJEJNHEPMOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6A68570", Offset = "0x6A67970", VA = "0x186A68570")]
		public void FLCKKCHEAGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6A686F0", Offset = "0x6A67AF0", VA = "0x186A686F0")]
		private void MGLOKGFKDAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6A680C0", Offset = "0x6A674C0", VA = "0x186A680C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A68D60", Offset = "0x6A68160", VA = "0x186A68D60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6A6A6E0", Offset = "0x6A69AE0", VA = "0x186A6A6E0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool IGANPIEEKLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6A6A380", Offset = "0x6A69780", VA = "0x186A6A380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static Dictionary<string, Dictionary<string, object>> COGNCEPLGFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6A68FC0", Offset = "0x6A683C0", VA = "0x186A68FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static Guid? DENJFMBICBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x6A6A310", Offset = "0x6A69710", VA = "0x186A6A310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x6A69D00", Offset = "0x6A69100", VA = "0x186A69D00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static Guid? LNGMMGEKBIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6A69D60", Offset = "0x6A69160", VA = "0x186A69D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x6A69190", Offset = "0x6A68590", VA = "0x186A69190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6A69C70", Offset = "0x6A69070", VA = "0x186A69C70")]
		public static void FLPCLMJIAME(string PLODMIMAPGG, JEBCDHLLNLI GFEDHLJPJCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6A6A030", Offset = "0x6A69430", VA = "0x186A6A030")]
		internal static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6A6A230", Offset = "0x6A69630", VA = "0x186A6A230")]
		internal static void IHILNAOKAGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6A6A660", Offset = "0x6A69A60", VA = "0x186A6A660")]
		internal static void NCMDGGLGNAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6A691F0", Offset = "0x6A685F0", VA = "0x186A691F0")]
		public static Guid FJEPPMDLGDF(string PLODMIMAPGG, [Optional] string? OHDOAHJDDOD, [Optional] Dictionary<string, object>? EEJFKHBLDLP)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6A697D0", Offset = "0x6A68BD0", VA = "0x186A697D0")]
		public static Guid FJEPPMDLGDF(string PLODMIMAPGG, long OHDOAHJDDOD, [Optional] Dictionary<string, object>? EEJFKHBLDLP)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6A69DD0", Offset = "0x6A691D0", VA = "0x186A69DD0")]
		public static void HIHHGDLPMLA(string PLODMIMAPGG, [Optional] Guid? JINNLDEOCMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6A68DB0", Offset = "0x6A681B0", VA = "0x186A68DB0")]
		public static void BMGAPNCDIKI(string PLODMIMAPGG, string PKALCDFCFBF, object HGCONPIBKCO, bool BGAPHLDONAI = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6A6A410", Offset = "0x6A69810", VA = "0x186A6A410")]
		public static bool LCAGLCCPHEE(string PLODMIMAPGG, [Optional] string? OHDOAHJDDOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6A69010", Offset = "0x6A68410", VA = "0x186A69010")]
		private static void CHJLECHOAMD(bool PEEGHBHEFHE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6A6A600", Offset = "0x6A69A00", VA = "0x186A6A600")]
		public static void LMGIPMOOIFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6A6A110", Offset = "0x6A69510", VA = "0x186A6A110")]
		private static void IAAFPEIGDED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6A69870", Offset = "0x6A68C70", VA = "0x186A69870")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA6B60", VA = "0x180AA7760")]
			public JEHOOPACIIC(bool JHGFMOPHGIB, string BHPFPDNBMAP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6A68940", Offset = "0x6A67D40", VA = "0x186A68940")]
		public static JEHOOPACIIC IEGNOINNOMJ(GMCIPLKCNGP BGJAJNGKGGN)
		{
			return default(JEHOOPACIIC);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6A68C60", Offset = "0x6A68060", VA = "0x186A68C60")]
		private static void NKAEFHPEHCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6A68880", Offset = "0x6A67C80", VA = "0x186A68880")]
		private static void FFBPLMPMGIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class EDOBNOCMPDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6A6BE00", Offset = "0x6A6B200", VA = "0x186A6BE00")]
		public static GMCIPLKCNGP OCCFFFKDDCP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class JHENJJMJIDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DC70", Offset = "0x6A6D070", VA = "0x186A6DC70")]
		public static GMCIPLKCNGP CHKEOMGGFOF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DFD0", Offset = "0x6A6D3D0", VA = "0x186A6DFD0")]
		public static GMCIPLKCNGP LIPDBNLHNAI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DE50", Offset = "0x6A6D250", VA = "0x186A6DE50")]
		public static GMCIPLKCNGP FFOKGHBEMLJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DC10", Offset = "0x6A6D010", VA = "0x186A6DC10")]
		public static GMCIPLKCNGP CHELEOOAGFH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E0F0", Offset = "0x6A6D4F0", VA = "0x186A6E0F0")]
		public static GMCIPLKCNGP PPDNPJPLIPJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DF10", Offset = "0x6A6D310", VA = "0x186A6DF10")]
		public static GMCIPLKCNGP GKKOOHLPFPO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E090", Offset = "0x6A6D490", VA = "0x186A6E090")]
		public static GMCIPLKCNGP NGFIKMCAPDF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DD30", Offset = "0x6A6D130", VA = "0x186A6DD30")]
		public static GMCIPLKCNGP DFJLJDINEFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DDF0", Offset = "0x6A6D1F0", VA = "0x186A6DDF0")]
		public static GMCIPLKCNGP FAKOILPCEFD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DEB0", Offset = "0x6A6D2B0", VA = "0x186A6DEB0")]
		public static GMCIPLKCNGP GDGMDIKIJGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DBB0", Offset = "0x6A6CFB0", VA = "0x186A6DBB0")]
		public static GMCIPLKCNGP CELJMMEJCHC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DD90", Offset = "0x6A6D190", VA = "0x186A6DD90")]
		public static GMCIPLKCNGP DODDGFBOIAE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E030", Offset = "0x6A6D430", VA = "0x186A6E030")]
		public static GMCIPLKCNGP LKICGCAABJC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DCD0", Offset = "0x6A6D0D0", VA = "0x186A6DCD0")]
		public static GMCIPLKCNGP CLNLHPLFBNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DF70", Offset = "0x6A6D370", VA = "0x186A6DF70")]
		public static GMCIPLKCNGP IAKJACCJEMB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class JIBGJKHAHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E150", Offset = "0x6A6D550", VA = "0x186A6E150")]
		public static GMCIPLKCNGP NKGDBECGCOD(long FFFLOIOFAMB, long OGHBKCHPPKA, bool KFDBDJLPICM, string HEOIEHKOKMI, string DIKLGMDDAFJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class OFHCMDOIFBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6A71A00", Offset = "0x6A70E00", VA = "0x186A71A00")]
		public static GMCIPLKCNGP PFCCOAFPOKE(string HOHDGOMKIEO, string FGKLODBMMNE, bool EKEMHHGLLIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6A717D0", Offset = "0x6A70BD0", VA = "0x186A717D0")]
		public static GMCIPLKCNGP IOBPEBMKDBH(string BPPCEJGCMKA, string PAKCJCEHNIE, string LCLGMIAMOOG, [Optional] int? KHMEKCHOOFP, [Optional] double[] LBKLMGKKIMM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class HDDCLKJJGLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D2A0", Offset = "0x6A6C6A0", VA = "0x186A6D2A0")]
		public static GMCIPLKCNGP AOKHBOHEHPC(string HIEALIELAPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D5F0", Offset = "0x6A6C9F0", VA = "0x186A6D5F0")]
		public static GMCIPLKCNGP IMINJFMIHJA(string HKHPHIHDFNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D940", Offset = "0x6A6CD40", VA = "0x186A6D940")]
		public static GMCIPLKCNGP NLIKHMPNLDF(int NJNOPMJJKAE, string OMOOEGOLALI, string KGHCKLKGJKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D380", Offset = "0x6A6C780", VA = "0x186A6D380")]
		public static GMCIPLKCNGP AONKIFBJDMP(int NJNOPMJJKAE, string OMOOEGOLALI, string KGHCKLKGJKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D440", Offset = "0x6A6C840", VA = "0x186A6D440")]
		public static GMCIPLKCNGP IBGLGHHDDPL(int NJNOPMJJKAE, string OMOOEGOLALI, string KGHCKLKGJKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D3E0", Offset = "0x6A6C7E0", VA = "0x186A6D3E0")]
		public static GMCIPLKCNGP HDMIMPOFPFC(int NJNOPMJJKAE, string OMOOEGOLALI, string KGHCKLKGJKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D4A0", Offset = "0x6A6C8A0", VA = "0x186A6D4A0")]
		public static GMCIPLKCNGP IJDNGOFLCDE(string OMOOEGOLALI, string KGHCKLKGJKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D800", Offset = "0x6A6CC00", VA = "0x186A6D800")]
		private static GMCIPLKCNGP JHAJNHNPDML(string JHFJAFCMJGA, int NJNOPMJJKAE, string GMLPIJBAHPD, string NFJADIGKJCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D6D0", Offset = "0x6A6CAD0", VA = "0x186A6D6D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A6C0F0", Offset = "0x6A6B4F0", VA = "0x186A6C0F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6A6BFF0", Offset = "0x6A6B3F0", VA = "0x186A6BFF0")]
	[ONDAMKAMKDB.LAIHOOOIOBJ]
	internal static void FDAPFLHEMPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C300", Offset = "0x6A6B700", VA = "0x186A6C300")]
	private static void NOAAHKDEMAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A6BF70", Offset = "0x6A6B370", VA = "0x186A6BF70")]
	public static GMCIPLKCNGP CJIENNAOJJA(string AFCDMPICECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A6BE60", Offset = "0x6A6B260", VA = "0x186A6BE60")]
	public static GMCIPLKCNGP CJIENNAOJJA(string AFCDMPICECP, int NJNOPMJJKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C1E0", Offset = "0x6A6B5E0", VA = "0x186A6C1E0")]
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
