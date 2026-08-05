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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E7A6F0", Offset = "0x6E790F0", VA = "0x186E7A6F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D8490", Offset = "0x9D6E90", VA = "0x1809D8490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D84D0", Offset = "0x9D6ED0", VA = "0x1809D84D0")]
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
	public class LogRegistrationIndex : CCAGPMFGEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6E7A660", Offset = "0x6E79060", VA = "0x186E7A660", Slot = "4")]
		public override void BLLBFFICICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E7AA60", Offset = "0x6E79460", VA = "0x186E7AA60", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2571680", Offset = "0x2570080", VA = "0x182571680")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JHAINLCFPKH
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> OFCPNEMABMP();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LHOLLBCLIDP
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6E7A1B0", Offset = "0x6E78BB0", VA = "0x186E7A1B0")]
	public static void KLHLEFAKNBO(this HOJMCLHGIAG.AFOPNHCEOML HGDPJNEFOBK, string LDKAEPPBIFE, string NIBODHDOIKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6E7A120", Offset = "0x6E78B20", VA = "0x186E7A120")]
	public static void KLHLEFAKNBO(this HOJMCLHGIAG.AFOPNHCEOML HGDPJNEFOBK, string LDKAEPPBIFE, bool NIBODHDOIKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6E7A020", Offset = "0x6E78A20", VA = "0x186E7A020")]
	public static void KLHLEFAKNBO(this HOJMCLHGIAG.AFOPNHCEOML HGDPJNEFOBK, string LDKAEPPBIFE, float PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6E79CD0", Offset = "0x6E786D0", VA = "0x186E79CD0")]
	public static void KLHLEFAKNBO(this HOJMCLHGIAG.AFOPNHCEOML HGDPJNEFOBK, string LDKAEPPBIFE, JGIABCHHNAM NIBODHDOIKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HOJMCLHGIAG
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface JBGEFMNEFJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		AFOPNHCEOML HOOIGABJCCM(Guid ALLFNAMPKOM, string MPCBKHNPJND, [Optional] string HIKLKIAGMEB, [Optional] long? JGGJKMELMEK, [Optional] string KLIIKAALBNF, [Optional] string NJMKAOFNHOH);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class JMABFMGBKFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6E79120", Offset = "0x6E77B20", VA = "0x186E79120")]
		public static AFOPNHCEOML PBJLIBJIHPM(Guid ALLFNAMPKOM, string MPCBKHNPJND, string HIKLKIAGMEB, [Optional] long? JGGJKMELMEK, [Optional] string KLIIKAALBNF, [Optional] string NJMKAOFNHOH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AFOPNHCEOML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected HMJCGGBOPOC GLECKDJIKIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly IDictionary<string, IDictionary<string, object>> BDELAOJIALD;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool OEGLAHDCOFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6E71470", Offset = "0x6E6FE70", VA = "0x186E71470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string KDGFKHPBKMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x1059650", Offset = "0x1058050", VA = "0x181059650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6E71620", Offset = "0x6E70020", VA = "0x186E71620")]
		public AFOPNHCEOML(HMJCGGBOPOC GLECKDJIKIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6E70F20", Offset = "0x6E6F920", VA = "0x186E70F20")]
		public AFOPNHCEOML EFECHIDHHAB(string LDIFMBFDAPL, string PPJFMHBDGNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3D41CC0", Offset = "0x3D406C0", VA = "0x183D41CC0")]
		public AFOPNHCEOML EFECHIDHHAB<T>(string LDIFMBFDAPL, T PPJFMHBDGNA) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6E71540", Offset = "0x6E6FF40", VA = "0x186E71540")]
		public AFOPNHCEOML KPLMGAJIGKI(string LDIFMBFDAPL, object PPJFMHBDGNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3D42050", Offset = "0x3D40A50", VA = "0x183D42050")]
		public AFOPNHCEOML KAKJAPLMLPA<T>(string LDIFMBFDAPL, T? PPJFMHBDGNA) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6E714B0", Offset = "0x6E6FEB0", VA = "0x186E714B0")]
		public AFOPNHCEOML KAKJAPLMLPA(string LDIFMBFDAPL, string PPJFMHBDGNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6E71250", Offset = "0x6E6FC50", VA = "0x186E71250")]
		public AFOPNHCEOML HCKNCHJOICO(string JPFKLCLPCCC, string NJBPFCDJFGD, object DFPGGEDGGGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6E71390", Offset = "0x6E6FD90", VA = "0x186E71390")]
		public AFOPNHCEOML HCKNCHJOICO(string JPFKLCLPCCC, IDictionary<string, object> NOGFBEHEDEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6E715C0", Offset = "0x6E6FFC0", VA = "0x186E715C0")]
		private static IDictionary<string, object> NPEIJIHHNDD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6E70FA0", Offset = "0x6E6F9A0", VA = "0x186E70FA0")]
		public void EIDJCCAMNGA(bool COFEJGIBNHN, string JCIHOHOOKDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6E70E20", Offset = "0x6E6F820", VA = "0x186E70E20")]
		public Task AECMNJEEBPC([Optional] CancellationToken BJEPDCCBCHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2684270", Offset = "0x2682C70", VA = "0x182684270", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class HMJCGGBOPOC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct KOKBJPFJFOH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public HMJCGGBOPOC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6E79330", Offset = "0x6E77D30", VA = "0x186E79330", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6E797A0", Offset = "0x6E781A0", VA = "0x186E797A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static Action<HMJCGGBOPOC> KAHEEIOLHKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly string MBFDNBCBIAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<string, object> NKPCLDONOBK;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string KDGFKHPBKMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6E76DD0", Offset = "0x6E757D0", VA = "0x186E76DD0")]
		private HMJCGGBOPOC(string MBFDNBCBIAD, int IHGDIMPKJAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6E76BF0", Offset = "0x6E755F0", VA = "0x186E76BF0")]
		public static AFOPNHCEOML IDEDHGEBOCJ(string MBFDNBCBIAD, int IHGDIMPKJAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6E76AA0", Offset = "0x6E754A0", VA = "0x186E76AA0")]
		[AsyncStateMachine(typeof(KOKBJPFJFOH))]
		public Task AECMNJEEBPC([Optional] CancellationToken BJEPDCCBCHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6E76D60", Offset = "0x6E75760", VA = "0x186E76D60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x341E2C0", Offset = "0x341CCC0", VA = "0x18341E2C0")]
		internal void FOJJPKLGKIJ<T>(string LDIFMBFDAPL, T PPJFMHBDGNA) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6E76D00", Offset = "0x6E75700", VA = "0x186E76D00")]
		internal void JMNFDCCPKEE(string LDIFMBFDAPL, object PPJFMHBDGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6E76B90", Offset = "0x6E75590", VA = "0x186E76B90")]
		internal void FOJJPKLGKIJ(string LDIFMBFDAPL, string PPJFMHBDGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3D48310", Offset = "0x3D46D10", VA = "0x183D48310")]
		private void MAJNCIDGLLN<T>(string LDIFMBFDAPL, T PPJFMHBDGNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct EENHDDMJODG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string BFOJDBMEEDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly long? FJEOJHLFBHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly short? DBODNAGMDOD;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6E73AD0", Offset = "0x6E724D0", VA = "0x186E73AD0")]
		public EENHDDMJODG(string AAIPPJKCNEN, [Optional] long? ELGKGFHIPBE, [Optional] short? HBMIGHKGJCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct FGKMNLADGCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly int BCOLENCHBMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly string OKFHGOOGOGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly short DANNPBKMJLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly string APPIEGOPNJH;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6E73E10", Offset = "0x6E72810", VA = "0x186E73E10")]
		public FGKMNLADGCG(int GCOFMHANEJE, string OJJCPPOPLBA, short NMBJNLDOKOD, string OLKNCKDHAGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class BAEEMKDDBCL : DDFPPKCAOPG<IGFMFOIJJDP, FGKMNLADGCG, EENHDDMJODG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string OJJCPPOPLBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private short NMBJNLDOKOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private string OLKNCKDHAGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Dictionary<short, int> FGGFEGKEGFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int JCJLBCOFELB;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6E72B20", Offset = "0x6E71520", VA = "0x186E72B20")]
		public BAEEMKDDBCL(string OIFBLMLCCCH, Guid FOIIJMEDOMO, long INJFGKAIFAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6E724A0", Offset = "0x6E70EA0", VA = "0x186E724A0", Slot = "4")]
		public override void GPGANPHHCAM(FGKMNLADGCG HHFCLMPGKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6E72790", Offset = "0x6E71190", VA = "0x186E72790")]
		public void IJADGMEAOJC(short NMBJNLDOKOD, bool MLJLOGKKCIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x47A2DA0", Offset = "0x47A17A0", VA = "0x1847A2DA0")]
		public void OEPACLGGHIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4B0", Offset = "0x9AAEB0", VA = "0x1809AC4B0")]
		public void MFNAGFHECNA(string DALMIEJJCKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6E716C0", Offset = "0x6E700C0", VA = "0x186E716C0", Slot = "5")]
		public override void AKKBMGLBKBF(bool KHMEOCBAEGC, EENHDDMJODG EIOLLEOGEMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6E72870", Offset = "0x6E71270", VA = "0x186E72870", Slot = "6")]
		public override BJDJLOMGFCH KMGJIJOEHGJ(IGFMFOIJJDP KKEBIDHHPAO, int DOAKEFBOPIA, string OINHMALLBOO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class EHDNNAFPHDO : BJDJLOMGFCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private string OJJCPPOPLBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly short NMBJNLDOKOD;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6E73CC0", Offset = "0x6E726C0", VA = "0x186E73CC0")]
		public EHDNNAFPHDO(long OFPOOCKAALP, int GCOFMHANEJE, string HIKLKIAGMEB, long INJFGKAIFAL, int HJEMLONLLJF, string KLIIKAALBNF, short NMBJNLDOKOD, string OJJCPPOPLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6E73B10", Offset = "0x6E72510", VA = "0x186E73B10")]
		public void ALKCEFBEJIF(int GCOFMHANEJE, string OJJCPPOPLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6E73B90", Offset = "0x6E72590", VA = "0x186E73B90", Slot = "5")]
		public override AFOPNHCEOML HOOIGABJCCM(Guid ALLFNAMPKOM, string MPCBKHNPJND, [Optional] string HIKLKIAGMEB, [Optional] long? JGGJKMELMEK, [Optional] string KLIIKAALBNF, [Optional] string NJMKAOFNHOH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class HIPNOELFGAH
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class LPJBFFDCHKK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float nextEventSendTime;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public LPJBFFDCHKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6E7A5C0", Offset = "0x6E78FC0", VA = "0x186E7A5C0")]
			internal bool PMBHKCPKOPK()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct GKCBLGCEGMO : IAsyncStateMachine
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
			private LPJBFFDCHKK <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TimeSpan <delayPollingInterval>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6E74560", Offset = "0x6E72F60", VA = "0x186E74560", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6E75220", Offset = "0x6E73C20", VA = "0x186E75220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct HEJHLOIFIGK : IAsyncStateMachine
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

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6E75280", Offset = "0x6E73C80", VA = "0x186E75280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6E75800", Offset = "0x6E74200", VA = "0x186E75800", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly float BHICGMDPLDH;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static BGNEBPNKOAE FAKMMFCIMGO;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static CancellationTokenSource FMBNPMGNAGE;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static bool MCDDLFACKCN;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static int OLJAEJJMAII;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly KKHFJLAMDJE<AFOPNHCEOML, bool> MAJIPGFELHP;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static NONCBENIHAN<AFOPNHCEOML, bool> ACAIPACAPAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6E75F40", Offset = "0x6E74940", VA = "0x186E75F40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static bool HMBFIKMDHDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6E75B10", Offset = "0x6E74510", VA = "0x186E75B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6E75860", Offset = "0x6E74260", VA = "0x186E75860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private static bool CGJCIGCAAFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6E75AC0", Offset = "0x6E744C0", VA = "0x186E75AC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6E76780", Offset = "0x6E75180", VA = "0x186E76780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private static float FDBPDKNMCMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6E75A70", Offset = "0x6E74470", VA = "0x186E75A70")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6E767E0", Offset = "0x6E751E0", VA = "0x186E767E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6E76840", Offset = "0x6E75240", VA = "0x186E76840")]
		[GPPLJIPNHLO.LKFPCGJJCOD]
		internal static void OANAACPIHHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6E75C90", Offset = "0x6E74690", VA = "0x186E75C90")]
		internal static void ELAEPFFNBKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6E758C0", Offset = "0x6E742C0", VA = "0x186E758C0")]
		internal static void CMKPBKOPCPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6E75B60", Offset = "0x6E74560", VA = "0x186E75B60")]
		internal static void EIMIDAFDIHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6E76960", Offset = "0x6E75360", VA = "0x186E76960")]
		public static void PGHBCMBMMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6E76350", Offset = "0x6E74D50", VA = "0x186E76350")]
		private static void JINBONFMFPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6E76070", Offset = "0x6E74A70", VA = "0x186E76070")]
		private static void JALAABHENJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6E75BC0", Offset = "0x6E745C0", VA = "0x186E75BC0")]
		[AsyncStateMachine(typeof(GKCBLGCEGMO))]
		private static Task EJPECPADCDK(CancellationToken BJEPDCCBCHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6E75E70", Offset = "0x6E74870", VA = "0x186E75E70")]
		private static void ELFBLIEDIBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6E75F90", Offset = "0x6E74990", VA = "0x186E75F90")]
		[AsyncStateMachine(typeof(HEJHLOIFIGK))]
		private static Task IHCMCAIKGHN(bool HPIDONLBAHJ, [Optional] CancellationToken BJEPDCCBCHJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class LOFLLFOIJLL<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class NHLCIEDMCCG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public LOFLLFOIJLL<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public NHLCIEDMCCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x51AE890", Offset = "0x51AD290", VA = "0x1851AE890")]
			internal object OEAFOGKBDOP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class OPFCFMGBKFD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public LOFLLFOIJLL<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public OPFCFMGBKFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x532D870", Offset = "0x532C270", VA = "0x18532D870")]
			internal object NHJEACFHGBD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class NGCKDEGIOGC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public LOFLLFOIJLL<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public NGCKDEGIOGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x51AC0E0", Offset = "0x51AAAE0", VA = "0x1851AC0E0")]
			internal object MLOHGPAIEIF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class NFDKOIMONJG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public LOFLLFOIJLL<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public NFDKOIMONJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x51A91C0", Offset = "0x51A7BC0", VA = "0x1851A91C0")]
			internal object JIOPFMLLOIP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class ALIOCGFMNPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public LOFLLFOIJLL<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public ALIOCGFMNPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x50872B0", Offset = "0x5085CB0", VA = "0x1850872B0")]
			internal object LJNEHAICBDB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class BPLKIMJPHCN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public LOFLLFOIJLL<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public BPLKIMJPHCN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x64C3B50", Offset = "0x64C2550", VA = "0x1864C3B50")]
			internal object CMMEBPHIDDJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class EBNJMHABNFL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public LOFLLFOIJLL<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public EBNJMHABNFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x43526E0", Offset = "0x43510E0", VA = "0x1843526E0")]
			internal object IDCBLDAGJON()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const float GHINEBGFEJH = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Guid ALLFNAMPKOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly string KLIIKAALBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly string JBDFNFPJBOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string MCLIPFGJFHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private string NJMKAOFNHOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private string GFEDNKDCLBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private string PIFIPAFLHGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private string EIKFJKLPELA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private string EMJNPHBIICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private string NEFICJEIBLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private string CHFCHOEBOGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private string KILNCBKNIPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Guid? ADOEHCOHDMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private (int, int)? JNFPFHEHDJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly HashSet<T> FLLLODLBGCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly Dictionary<(T, int), string> JILFBJPKFIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Dictionary<(T, int), float> HGEFJKHJDDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Dictionary<T, string> NONIHKPONGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Dictionary<T, string> JAIOGDDJMOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly Dictionary<T, string> MHOBCMEILDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<T, string[]> FPKIFPCAMFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private string LGKHOEKDFLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private bool CPEJNFAMNCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Task BOJAGDMNFDN;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4EE8010", Offset = "0x4EE6A10", VA = "0x184EE8010")]
		public LOFLLFOIJLL(Guid ALLFNAMPKOM, string JBDFNFPJBOG, string KLIIKAALBNF, string MCLIPFGJFHO, [Optional] string NJMKAOFNHOH, [Optional] string GFEDNKDCLBJ, [Optional] string PIFIPAFLHGF, [Optional] string NEFICJEIBLP, [Optional] string LGKHOEKDFLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDB0", Offset = "0x9AD7B0", VA = "0x1809AEDB0")]
		public void MGEHAACMIHG(string NJMKAOFNHOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9B5530", Offset = "0x9B3F30", VA = "0x1809B5530")]
		public void OPICHJIJHCG(string MCLIPFGJFHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA26F40", Offset = "0xA25940", VA = "0x180A26F40")]
		public void GBKMFNFGOCF(string LGKHOEKDFLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4D0", Offset = "0x9AAED0", VA = "0x1809AC4D0")]
		public void ONPBILOEPOO(string EIKFJKLPELA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4B0", Offset = "0x9AAEB0", VA = "0x1809AC4B0")]
		public void HENNCAEONJL(string CHFCHOEBOGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9AC500", Offset = "0x9AAF00", VA = "0x1809AC500")]
		public void MGBFHEMBCNG(string KILNCBKNIPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7420", Offset = "0x4EE5E20", VA = "0x184EE7420")]
		public void KCNAECNEHMF(Guid? ALLFNAMPKOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4EDFA90", Offset = "0x4EDE490", VA = "0x184EDFA90")]
		public void BNHFJCHIMHA((int, int)? JNFPFHEHDJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9AC520", Offset = "0x9AAF20", VA = "0x1809AC520")]
		public void DFGOHPILDMC(string EMJNPHBIICK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4EE64D0", Offset = "0x4EE4ED0", VA = "0x184EE64D0")]
		public void BBBDPFDFKNA(T JGGJKMELMEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4EE6B90", Offset = "0x4EE5590", VA = "0x184EE6B90")]
		public void GFCKIGHEPOI(T JGGJKMELMEK, int ABPHJKAGAEF, float JHEFBFGKIFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4EE68E0", Offset = "0x4EE52E0", VA = "0x184EE68E0")]
		public void FPFOKCICIND(T JGGJKMELMEK, int ABPHJKAGAEF, string MLKICEBJAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4EE6660", Offset = "0x4EE5060", VA = "0x184EE6660")]
		public void BNOMLLHMEFD(T JGGJKMELMEK, string ECPAEBPMDNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7CB0", Offset = "0x4EE66B0", VA = "0x184EE7CB0")]
		public void ODKGDFKIENF(T JGGJKMELMEK, string IKLAJMGDAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7AE0", Offset = "0x4EE64E0", VA = "0x184EE7AE0")]
		public void MDEFJHJCBEO(T JGGJKMELMEK, bool OHIECOGGHMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7E60", Offset = "0x4EE6860", VA = "0x184EE7E60")]
		public void OPEBDOJKOHP(T JGGJKMELMEK, string[] GJKAKCHDHAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4EE54A0", Offset = "0x4EE3EA0", VA = "0x184EE54A0")]
		public Task AECMNJEEBPC(bool JDEIJIAFEMH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7440", Offset = "0x4EE5E40", VA = "0x184EE7440")]
		private (IEnumerable<T>, string) KDLCEDFIEFE()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4EE6F80", Offset = "0x4EE5980", VA = "0x184EE6F80")]
		public static AFOPNHCEOML ICLDHHIHKLJ(Guid ALLFNAMPKOM, string JBDFNFPJBOG, T JGGJKMELMEK, string KLIIKAALBNF, string BPNMIBPOGCA, string NJMKAOFNHOH, int? DOAKEFBOPIA, [Optional] string HAEOOFKLHAO, [Optional] string ECPAEBPMDNO, [Optional] int? CHHOPGFNENC, [Optional] Guid? ADOEHCOHDMI, [Optional] string LGKHOEKDFLC, [Optional] string HIKLKIAGMEB, [Optional] (int, int)? JNFPFHEHDJP, [Optional] string DNPLCOHLIAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7390", Offset = "0x4EE5D90", VA = "0x184EE7390")]
		[CompilerGenerated]
		private string JIKJEGJBMPB(T ICHIIHCEGJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4EE5410", Offset = "0x4EE3E10", VA = "0x184EE5410")]
		[CompilerGenerated]
		private string AAONFPHADAO(T ICHIIHCEGJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4EE6810", Offset = "0x4EE5210", VA = "0x184EE6810")]
		[CompilerGenerated]
		private string CGHKNNJPCLH(T ICHIIHCEGJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x4EE6EF0", Offset = "0x4EE58F0", VA = "0x184EE6EF0")]
		[CompilerGenerated]
		private string HNJFKHKKEHA(T ICHIIHCEGJD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public abstract class DDFPPKCAOPG<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		protected readonly string OIFBLMLCCCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		protected readonly Guid FOIIJMEDOMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		protected readonly long INJFGKAIFAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		protected int GCOFMHANEJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		protected int ODFMNIHNMCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		protected DateTime ENEODOCBMGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		protected bool DIKBDHKHBKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		protected Dictionary<long, BJDJLOMGFCH> JEGBHJGDBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		protected bool LELAHKFFGBG;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool LNAJNJCEACL
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xBAD060", Offset = "0xBABA60", VA = "0x180BAD060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool BNJPBDCCFMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xC02F10", Offset = "0xC01910", VA = "0x180C02F10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3EED570", Offset = "0x3EEBF70", VA = "0x183EED570")]
		public DDFPPKCAOPG(string OIFBLMLCCCH, Guid FOIIJMEDOMO, long INJFGKAIFAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void GPGANPHHCAM(TListSessionStartParams HHFCLMPGKJO);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3EED560", Offset = "0x3EEBF60", VA = "0x183EED560")]
		public void NMIDDHHEJLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void AKKBMGLBKBF(bool KHMEOCBAEGC, TListSessionLogParams EIOLLEOGEMI);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3EED200", Offset = "0x3EEBC00", VA = "0x183EED200")]
		public void ADMIMOOMBFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3EED2A0", Offset = "0x3EEBCA0", VA = "0x183EED2A0")]
		public void GBHMHCHHIAP(long OFPOOCKAALP, int DOAKEFBOPIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3EED440", Offset = "0x3EEBE40", VA = "0x183EED440")]
		public void MKDJHOOLGDK(long OFPOOCKAALP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract BJDJLOMGFCH KMGJIJOEHGJ(TItem OIBJKKOCOBE, int DOAKEFBOPIA, string OINHMALLBOO);
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class BJDJLOMGFCH : JBGEFMNEFJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int GCOFMHANEJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private long OFPOOCKAALP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private long INJFGKAIFAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly string EKACBJFHFOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly string EKOEGMAHOBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly int HJEMLONLLJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private DateTime EKECNJGPJFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private double OAMFLBADGJD;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MBABIKCLMDD
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xDB02E0", Offset = "0xDAECE0", VA = "0x180DB02E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xDB0A20", Offset = "0xDAF420", VA = "0x180DB0A20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6E73280", Offset = "0x6E71C80", VA = "0x186E73280")]
		public BJDJLOMGFCH(long OFPOOCKAALP, int GCOFMHANEJE, string HIKLKIAGMEB, long INJFGKAIFAL, int HJEMLONLLJF, [Optional] string KLIIKAALBNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6E731B0", Offset = "0x6E71BB0", VA = "0x186E731B0")]
		public void OCIGHIJFLHC(int GCOFMHANEJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6E72BA0", Offset = "0x6E715A0", VA = "0x186E72BA0")]
		public void DFJLLNGDNJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6E72BF0", Offset = "0x6E715F0", VA = "0x186E72BF0")]
		public void GOANECCEKHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6E73220", Offset = "0x6E71C20", VA = "0x186E73220")]
		private void OHHAPNIDMLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6E72D00", Offset = "0x6E71700", VA = "0x186E72D00", Slot = "5")]
		public virtual AFOPNHCEOML HOOIGABJCCM(Guid ALLFNAMPKOM, string MPCBKHNPJND, [Optional] string HIKLKIAGMEB, [Optional] long? JGGJKMELMEK, [Optional] string KLIIKAALBNF, [Optional] string NJMKAOFNHOH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class IJODIPHABNA
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static Dictionary<string, Dictionary<string, object>> BDNLDDNIAJL;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static string GAHLINCGKDB;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static int GKDELCILACB;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static readonly Dictionary<string, JHAINLCFPKH> BAKECGADFOJ;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static string PPILFBHALCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x6E78CE0", Offset = "0x6E776E0", VA = "0x186E78CE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6E789D0", Offset = "0x6E773D0", VA = "0x186E789D0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool HEMJLFJMBOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x6E78780", Offset = "0x6E77180", VA = "0x186E78780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static Dictionary<string, Dictionary<string, object>> JDLLGJELHPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6E78D30", Offset = "0x6E77730", VA = "0x186E78D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static Guid? ENBPIFFLEAK
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x6E77B00", Offset = "0x6E76500", VA = "0x186E77B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6E78A80", Offset = "0x6E77480", VA = "0x186E78A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static Guid? BIGAOGDMPNI
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x6E78810", Offset = "0x6E77210", VA = "0x186E78810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x6E77CC0", Offset = "0x6E766C0", VA = "0x186E77CC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6E77630", Offset = "0x6E76030", VA = "0x186E77630")]
		public static void BHICPCGCJMJ(string KGPHCJDKGHD, JHAINLCFPKH EIKPHGBNBEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6E77BE0", Offset = "0x6E765E0", VA = "0x186E77BE0")]
		internal static void ELAEPFFNBKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6E77A20", Offset = "0x6E76420", VA = "0x186E77A20")]
		internal static void CMKPBKOPCPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6E77B60", Offset = "0x6E76560", VA = "0x186E77B60")]
		internal static void EIMIDAFDIHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6E78110", Offset = "0x6E76B10", VA = "0x186E78110")]
		public static Guid GPGANPHHCAM(string KGPHCJDKGHD, [Optional] string? AHCLLGDNLLI, [Optional] Dictionary<string, object>? CLOEHPOBKJM)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6E786E0", Offset = "0x6E770E0", VA = "0x186E786E0")]
		public static Guid GPGANPHHCAM(string KGPHCJDKGHD, long AHCLLGDNLLI, [Optional] Dictionary<string, object>? CLOEHPOBKJM)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6E78D80", Offset = "0x6E77780", VA = "0x186E78D80")]
		public static void NMIDDHHEJLO(string KGPHCJDKGHD, [Optional] Guid? BIGAPECKJPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6E78AE0", Offset = "0x6E774E0", VA = "0x186E78AE0")]
		public static void JKHHKJKBCOL(string KGPHCJDKGHD, string JPFKLCLPCCC, object NFNPIOLPJGD, bool MCDDLFACKCN = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6E77830", Offset = "0x6E76230", VA = "0x186E77830")]
		public static bool BPMOMIDCEDL(string KGPHCJDKGHD, [Optional] string? AHCLLGDNLLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6E776C0", Offset = "0x6E760C0", VA = "0x186E776C0")]
		private static void BJHJBLCGMBM(bool EFCDOAOEBMA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6E78870", Offset = "0x6E77270", VA = "0x186E78870")]
		public static void IKANIJBBKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6E788C0", Offset = "0x6E772C0", VA = "0x186E788C0")]
		private static void JALAABHENJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6E77D20", Offset = "0x6E76720", VA = "0x186E77D20")]
		private static void FOBACJDPHLD(string KGPHCJDKGHD, Guid ALLFNAMPKOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class KOPJDFIKBAL
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public struct OMGLBKIGKNG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public bool FMDMJGBDOPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public string NDDKDBBBHMN;

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xBB1AB0", Offset = "0xBB04B0", VA = "0x180BB1AB0")]
			public OMGLBKIGKNG(bool FMDMJGBDOPB, string NDDKDBBBHMN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6E798C0", Offset = "0x6E782C0", VA = "0x186E798C0")]
		public static OMGLBKIGKNG HIMKLMLGBHH(AFOPNHCEOML HGDPJNEFOBK)
		{
			return default(OMGLBKIGKNG);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6E79BD0", Offset = "0x6E785D0", VA = "0x186E79BD0")]
		private static void PILIMFCJMDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6E79800", Offset = "0x6E78200", VA = "0x186E79800")]
		private static void AJFJOHBDBFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class FDDBDPGGOBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6E73DB0", Offset = "0x6E727B0", VA = "0x186E73DB0")]
		public static AFOPNHCEOML KDEMCHOBODM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class DECEMOOEFMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6E73A70", Offset = "0x6E72470", VA = "0x186E73A70")]
		public static AFOPNHCEOML POHBEKJGGKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6E73950", Offset = "0x6E72350", VA = "0x186E73950")]
		public static AFOPNHCEOML MMBBHDNDCAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6E738F0", Offset = "0x6E722F0", VA = "0x186E738F0")]
		public static AFOPNHCEOML LBGDMNNBACB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6E739B0", Offset = "0x6E723B0", VA = "0x186E739B0")]
		public static AFOPNHCEOML MMKNBLEPAAA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6E73A10", Offset = "0x6E72410", VA = "0x186E73A10")]
		public static AFOPNHCEOML MPPHADDNLJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6E73710", Offset = "0x6E72110", VA = "0x186E73710")]
		public static AFOPNHCEOML COBBBOBEGOF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6E73530", Offset = "0x6E71F30", VA = "0x186E73530")]
		public static AFOPNHCEOML AFAMENLNOIG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6E73890", Offset = "0x6E72290", VA = "0x186E73890")]
		public static AFOPNHCEOML JKFBEGLBAOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6E73590", Offset = "0x6E71F90", VA = "0x186E73590")]
		public static AFOPNHCEOML BBNFMEGDCMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6E737D0", Offset = "0x6E721D0", VA = "0x186E737D0")]
		public static AFOPNHCEOML DIKAIFLLIFD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6E735F0", Offset = "0x6E71FF0", VA = "0x186E735F0")]
		public static AFOPNHCEOML CFFLPHNMEBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6E73650", Offset = "0x6E72050", VA = "0x186E73650")]
		public static AFOPNHCEOML CIOPHEHONFM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6E736B0", Offset = "0x6E720B0", VA = "0x186E736B0")]
		public static AFOPNHCEOML CKPBMLAKKOH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6E73770", Offset = "0x6E72170", VA = "0x186E73770")]
		public static AFOPNHCEOML DAHMEKEPLMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6E73830", Offset = "0x6E72230", VA = "0x186E73830")]
		public static AFOPNHCEOML DKCNLNEPOFO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class CEOBCPCGIPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6E73350", Offset = "0x6E71D50", VA = "0x186E73350")]
		public static AFOPNHCEOML IJEBNOJPAJP(long ELGKGFHIPBE, long OAJKHGNBEDJ, bool GNLHDIBDALA, string FBBAMNLELEF, string AJIOPGFEHEN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class LKPNAOPFNPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6E7A220", Offset = "0x6E78C20", VA = "0x186E7A220")]
		public static AFOPNHCEOML ENFJGAJCMFF(string DDGBLBKOKJH, string LJBOOHGLBGG, bool GDPHMLBDEDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6E7A390", Offset = "0x6E78D90", VA = "0x186E7A390")]
		public static AFOPNHCEOML KANOFPFOADJ(string OJFCDDMGKNP, string LNKAJODGKGC, string CEJNEFCCPLH, [Optional] int? HDDEFCFHEJN, [Optional] double[] HICNAJAFAPG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class FMBFLKCINMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6E74060", Offset = "0x6E72A60", VA = "0x186E74060")]
		public static AFOPNHCEOML IOKFOLOHPAE(string GMCMCJJCIDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6E73F80", Offset = "0x6E72980", VA = "0x186E73F80")]
		public static AFOPNHCEOML ICINHCLCKDL(string FLPLIDKAOOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6E73E60", Offset = "0x6E72860", VA = "0x186E73E60")]
		public static AFOPNHCEOML BCPJEIHPHLL(int IHGDIMPKJAD, string EMLAIMJKHOE, string ICHIIHCEGJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6E743B0", Offset = "0x6E72DB0", VA = "0x186E743B0")]
		public static AFOPNHCEOML LJGMDGPNNOK(int IHGDIMPKJAD, string EMLAIMJKHOE, string ICHIIHCEGJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6E73F20", Offset = "0x6E72920", VA = "0x186E73F20")]
		public static AFOPNHCEOML HIFDONGNBMB(int IHGDIMPKJAD, string EMLAIMJKHOE, string ICHIIHCEGJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6E73EC0", Offset = "0x6E728C0", VA = "0x186E73EC0")]
		public static AFOPNHCEOML ECAJMPDOHAK(int IHGDIMPKJAD, string EMLAIMJKHOE, string ICHIIHCEGJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6E74410", Offset = "0x6E72E10", VA = "0x186E74410")]
		public static AFOPNHCEOML PIDLHGCBKFH(string EMLAIMJKHOE, string ICHIIHCEGJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6E74270", Offset = "0x6E72C70", VA = "0x186E74270")]
		private static AFOPNHCEOML LDMHBOMLJBO(string OIFBLMLCCCH, int IHGDIMPKJAD, string GFHLLLMALKF, string HGCJHEMBCNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6E74140", Offset = "0x6E72B40", VA = "0x186E74140")]
		private static AFOPNHCEOML LDMHBOMLJBO(string OIFBLMLCCCH, string GFHLLLMALKF, string HGCJHEMBCNB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly LMPJBEBLCLM HIMKLMLGBHH;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static LJNIFHMEAPL DBFKBOKJGBA;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static ABDKHFBDLNJ MNFBFLMJLOK;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<AFOPNHCEOML> GNFOJCBAKAN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long NLDMADIECEF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6E77280", Offset = "0x6E75C80", VA = "0x186E77280")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6E77190", Offset = "0x6E75B90", VA = "0x186E77190")]
	[GPPLJIPNHLO.LKFPCGJJCOD]
	internal static void BIGGMDGOIEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6E77370", Offset = "0x6E75D70", VA = "0x186E77370")]
	private static void DBBCGPDOGKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6E77110", Offset = "0x6E75B10", VA = "0x186E77110")]
	public static AFOPNHCEOML ANHELDMEEFP(string MBFDNBCBIAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6E76BF0", Offset = "0x6E755F0", VA = "0x186E76BF0")]
	public static AFOPNHCEOML ANHELDMEEFP(string MBFDNBCBIAD, int IHGDIMPKJAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6E77430", Offset = "0x6E75E30", VA = "0x186E77430")]
	public static bool HAEIBPMAMAB(this BGNEBPNKOAE ODNLGPBLJAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6E774A0", Offset = "0x6E75EA0", VA = "0x186E774A0")]
	[GPPLJIPNHLO.LKFPCGJJCOD]
	internal static void NLIJHGPOFGA()
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
