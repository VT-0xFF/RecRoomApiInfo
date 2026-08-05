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
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6AEA380", Offset = "0x6AE8F80", VA = "0x186AEA380")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9836D0", Offset = "0x9822D0", VA = "0x1809836D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x983710", Offset = "0x982310", VA = "0x180983710")]
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
	public class LogRegistrationIndex : NELPCBNCFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6AE7A60", Offset = "0x6AE6660", VA = "0x186AE7A60", Slot = "4")]
		public override void CHOGICNNBDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6AEBC40", Offset = "0x6AEA840", VA = "0x186AEBC40", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x240ECE0", Offset = "0x240D8E0", VA = "0x18240ECE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KKAIANLKIHB
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> IHAJMKPOKEK();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class IMGFNMNLHHJ
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6AE69A0", Offset = "0x6AE55A0", VA = "0x186AE69A0")]
	public static void NEINEGKDBGL(this BDKGKPLHPOD.INEHONOFCNC AEOOLJFIGNK, string OGPLKEOKAII, string HIMJPACFJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6AE6E60", Offset = "0x6AE5A60", VA = "0x186AE6E60")]
	public static void NEINEGKDBGL(this BDKGKPLHPOD.INEHONOFCNC AEOOLJFIGNK, string OGPLKEOKAII, bool HIMJPACFJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6AE6A10", Offset = "0x6AE5610", VA = "0x186AE6A10")]
	public static void NEINEGKDBGL(this BDKGKPLHPOD.INEHONOFCNC AEOOLJFIGNK, string OGPLKEOKAII, float MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6AE6B10", Offset = "0x6AE5710", VA = "0x186AE6B10")]
	public static void NEINEGKDBGL(this BDKGKPLHPOD.INEHONOFCNC AEOOLJFIGNK, string OGPLKEOKAII, EPLMBJGGEGI HIMJPACFJCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class BDKGKPLHPOD
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface JLOMCHMJPBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		INEHONOFCNC FFBCEOIKLEO(Guid PKLHPLNMANJ, string LGFDJLFDMGB, [Optional] string JBIFHOHNPLO, [Optional] long? CPNKHDBPNAC, [Optional] string HKPMNNOAICG, [Optional] string BEBJNLIHPCE);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class AKKCPBPNKKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2410", Offset = "0x6AE1010", VA = "0x186AE2410")]
		public static INEHONOFCNC NDIGAOPKCAB(Guid PKLHPLNMANJ, string LGFDJLFDMGB, string JBIFHOHNPLO, [Optional] long? CPNKHDBPNAC, [Optional] string HKPMNNOAICG, [Optional] string BEBJNLIHPCE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class INEHONOFCNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected MCJJHOEGOFC MCKCODFDFLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly IDictionary<string, IDictionary<string, object>> KGIHMFIELCH;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool BCBDHJFKIDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6AE76C0", Offset = "0x6AE62C0", VA = "0x186AE76C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string KNNKLJAGBLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xF00A70", Offset = "0xEFF670", VA = "0x180F00A70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6AE7700", Offset = "0x6AE6300", VA = "0x186AE7700")]
		public INEHONOFCNC(MCJJHOEGOFC MCKCODFDFLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6AE6EF0", Offset = "0x6AE5AF0", VA = "0x186AE6EF0")]
		public INEHONOFCNC ACKKPEFKBEB(string JENIGBAOHNC, string MPDLOLIOGJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3A55D00", Offset = "0x3A54900", VA = "0x183A55D00")]
		public INEHONOFCNC ACKKPEFKBEB<T>(string JENIGBAOHNC, T MPDLOLIOGJL) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6AE7230", Offset = "0x6AE5E30", VA = "0x186AE7230")]
		public INEHONOFCNC AGOLBLCGJCN(string JENIGBAOHNC, object MPDLOLIOGJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3A56090", Offset = "0x3A54C90", VA = "0x183A56090")]
		public INEHONOFCNC JPBNPMMCIED<T>(string JENIGBAOHNC, T? MPDLOLIOGJL) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6AE7630", Offset = "0x6AE6230", VA = "0x186AE7630")]
		public INEHONOFCNC JPBNPMMCIED(string JENIGBAOHNC, string MPDLOLIOGJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6AE74F0", Offset = "0x6AE60F0", VA = "0x186AE74F0")]
		public INEHONOFCNC ELPCACJOKKM(string JFJJDJPFAIO, string NKANGPLHEGE, object LLDJIJICLJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6AE7410", Offset = "0x6AE6010", VA = "0x186AE7410")]
		public INEHONOFCNC ELPCACJOKKM(string JFJJDJPFAIO, IDictionary<string, object> EJIKONGOMAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6AE73B0", Offset = "0x6AE5FB0", VA = "0x186AE73B0")]
		private static IDictionary<string, object> DNAJHNFJBDC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6AE6F70", Offset = "0x6AE5B70", VA = "0x186AE6F70")]
		public void AFDMFMFFGOG(bool MGGAOKMGNGN, string IKPLIBJPLCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6AE72B0", Offset = "0x6AE5EB0", VA = "0x186AE72B0")]
		public Task BNOPHIDIEBO([Optional] CancellationToken NAOIMKEDKEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x25227D0", Offset = "0x25213D0", VA = "0x1825227D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MCJJHOEGOFC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct BDCBNHFPDIC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public MCJJHOEGOFC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6AE2D20", Offset = "0x6AE1920", VA = "0x186AE2D20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6AE3160", Offset = "0x6AE1D60", VA = "0x186AE3160", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static Action<MCJJHOEGOFC> OKPEHOHNEAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly string BBNMPEGFDHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<string, object> JJBAIBMHFEM;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string KNNKLJAGBLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6AE7D10", Offset = "0x6AE6910", VA = "0x186AE7D10")]
		private MCJJHOEGOFC(string BBNMPEGFDHI, int HOGOECIJPMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6AE3240", Offset = "0x6AE1E40", VA = "0x186AE3240")]
		public static INEHONOFCNC EPPBBCFCJMI(string BBNMPEGFDHI, int HOGOECIJPMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6AE7AF0", Offset = "0x6AE66F0", VA = "0x186AE7AF0")]
		[AsyncStateMachine(typeof(BDCBNHFPDIC))]
		public Task BNOPHIDIEBO([Optional] CancellationToken NAOIMKEDKEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6AE7CA0", Offset = "0x6AE68A0", VA = "0x186AE7CA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3169750", Offset = "0x3168350", VA = "0x183169750")]
		internal void CKKDLBEIGAA<T>(string JENIGBAOHNC, T MPDLOLIOGJL) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6AE7C40", Offset = "0x6AE6840", VA = "0x186AE7C40")]
		internal void JAFGNBAOADK(string JENIGBAOHNC, object MPDLOLIOGJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6AE7BE0", Offset = "0x6AE67E0", VA = "0x186AE7BE0")]
		internal void CKKDLBEIGAA(string JENIGBAOHNC, string MPDLOLIOGJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3A57610", Offset = "0x3A56210", VA = "0x183A57610")]
		private void FIBPOHNGLII<T>(string JENIGBAOHNC, T MPDLOLIOGJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct KAAFHDHJHCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string NPLENDKEDKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly long? JMAKOHJDMGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly short? DLGOILNNPBI;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6AE7840", Offset = "0x6AE6440", VA = "0x186AE7840")]
		public KAAFHDHJHCA(string FLFMCNAKDKL, [Optional] long? EPGJLNEAJPA, [Optional] short? KONOCFNBECN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct DHADCCLDAKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly int BEPPIPOBFAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly string HCEHKJELGNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly short BJBGAKLOFKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly string DNJEFDEDHFK;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6AE56F0", Offset = "0x6AE42F0", VA = "0x186AE56F0")]
		public DHADCCLDAKI(int LHNFMFIAHOI, string PMCHBGOAEBK, short IHLFJAKBHPI, string MHJFOFHDIGA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class OINKNOAOFME : MJBFNHNOCEK<EPIPNAOLOKM, DHADCCLDAKI, KAAFHDHJHCA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string PMCHBGOAEBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private short IHLFJAKBHPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private string MHJFOFHDIGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Dictionary<short, int> HCMLKKPPOAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int MDEKHGIKOKD;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB870", Offset = "0x6AEA470", VA = "0x186AEB870")]
		public OINKNOAOFME(string OOLGKGAAMHG, Guid OICFLDGNLHO, long HLKMIHCGHAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA400", Offset = "0x6AE9000", VA = "0x186AEA400", Slot = "4")]
		public override void FEOGMCEKOBM(DHADCCLDAKI DGLCJOHNPAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA9A0", Offset = "0x6AE95A0", VA = "0x186AEA9A0")]
		public void MBCKJBDLLBE(short IHLFJAKBHPI, bool MLCPBPMBAAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4382E20", Offset = "0x4381A20", VA = "0x184382E20")]
		public void NDCNOJLKDAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x961530", Offset = "0x960130", VA = "0x180961530")]
		public void AFLIMKAFCHM(string KCLPFBIAPGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6AEAA80", Offset = "0x6AE9680", VA = "0x186AEAA80", Slot = "5")]
		public override void NLBFAJFDFAE(bool GBMKLOJNLMO, KAAFHDHJHCA PKIDMLLKNGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA6F0", Offset = "0x6AE92F0", VA = "0x186AEA6F0", Slot = "6")]
		public override GAKFHLFOFAG FFLLCMKPNKE(EPIPNAOLOKM FJLJIEFHLOJ, int BIEEMEKMINN, string CGMLDHEADFF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class NBLAMLBMFCA : GAKFHLFOFAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private string PMCHBGOAEBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly short IHLFJAKBHPI;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA290", Offset = "0x6AE8E90", VA = "0x186AEA290")]
		public NBLAMLBMFCA(long NDMNLGHHJKE, int LHNFMFIAHOI, string JBIFHOHNPLO, long HLKMIHCGHAM, int KAPPBHAGMHD, string HKPMNNOAICG, short IHLFJAKBHPI, string PMCHBGOAEBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA210", Offset = "0x6AE8E10", VA = "0x186AEA210")]
		public void GGHBINOONAI(int LHNFMFIAHOI, string PMCHBGOAEBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA0E0", Offset = "0x6AE8CE0", VA = "0x186AEA0E0", Slot = "5")]
		public override INEHONOFCNC FFBCEOIKLEO(Guid PKLHPLNMANJ, string LGFDJLFDMGB, [Optional] string JBIFHOHNPLO, [Optional] long? CPNKHDBPNAC, [Optional] string HKPMNNOAICG, [Optional] string BEBJNLIHPCE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class BJBINIBGFED
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class JFFKJNKCBDF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float nextEventSendTime;

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public JFFKJNKCBDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6AE77A0", Offset = "0x6AE63A0", VA = "0x186AE77A0")]
			internal bool PEJMLKOBGOP()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct BEGMJBJCKNK : IAsyncStateMachine
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
			private JFFKJNKCBDF <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TimeSpan <delayPollingInterval>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6AE3780", Offset = "0x6AE2380", VA = "0x186AE3780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6AE4450", Offset = "0x6AE3050", VA = "0x186AE4450", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct FCFDFANBJEK : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x6AE5740", Offset = "0x6AE4340", VA = "0x186AE5740", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6AE5CC0", Offset = "0x6AE48C0", VA = "0x186AE5CC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly float EKHCGFCAHHP;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static DEECLODLFLE EPNBOPCMOMD;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static CancellationTokenSource OLOFLDLMNMC;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static bool CHGMBDAKHKF;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static int FHPILJIIGEB;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly NFIBJPEHBKM<INEHONOFCNC, bool> HIGKFMMDCKH;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static ODFKPJBJNGD<INEHONOFCNC, bool> KHJAKJHKCFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6AE4B10", Offset = "0x6AE3710", VA = "0x186AE4B10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static bool OBKDIFDFAEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6AE5490", Offset = "0x6AE4090", VA = "0x186AE5490")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6AE5430", Offset = "0x6AE4030", VA = "0x186AE5430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private static bool KJNFMBELBDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6AE50B0", Offset = "0x6AE3CB0", VA = "0x186AE50B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6AE4F20", Offset = "0x6AE3B20", VA = "0x186AE4F20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private static float AEKCKPDDGKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6AE44B0", Offset = "0x6AE30B0", VA = "0x186AE44B0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6AE5050", Offset = "0x6AE3C50", VA = "0x186AE5050")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6AE5100", Offset = "0x6AE3D00", VA = "0x186AE5100")]
		[DCPAEAFJNOM.MNANKELNNCD]
		internal static void HHPMAHOIFJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6AE4930", Offset = "0x6AE3530", VA = "0x186AE4930")]
		internal static void AIMKJDEKJHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6AE5220", Offset = "0x6AE3E20", VA = "0x186AE5220")]
		internal static void LKJKNINAOLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6AE53D0", Offset = "0x6AE3FD0", VA = "0x186AE53D0")]
		internal static void NEGCNFCHNIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6AE54E0", Offset = "0x6AE40E0", VA = "0x186AE54E0")]
		public static void ONGLPHHGDAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6AE4500", Offset = "0x6AE3100", VA = "0x186AE4500")]
		private static void ACPPIPGCMJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6AE4C40", Offset = "0x6AE3840", VA = "0x186AE4C40")]
		private static void DKDMAJADGNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6AE5530", Offset = "0x6AE4130", VA = "0x186AE5530")]
		[AsyncStateMachine(typeof(BEGMJBJCKNK))]
		private static Task POAIDKEIOAA(CancellationToken NAOIMKEDKEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6AE4F80", Offset = "0x6AE3B80", VA = "0x186AE4F80")]
		private static void FHELDJLHCNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6AE4B60", Offset = "0x6AE3760", VA = "0x186AE4B60")]
		[AsyncStateMachine(typeof(FCFDFANBJEK))]
		private static Task DJMMIAJKKGH(bool FIDIDMBFJHA, [Optional] CancellationToken NAOIMKEDKEJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class DDCOLEKKBEE<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class IOFNOAFOGNH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public DDCOLEKKBEE<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public IOFNOAFOGNH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x4718E30", Offset = "0x4717A30", VA = "0x184718E30")]
			internal object DOGOCDBJOOE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class FJJOJPJFOBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public DDCOLEKKBEE<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public FJJOJPJFOBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x4411580", Offset = "0x4410180", VA = "0x184411580")]
			internal object AHHIGANLPKL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class MJBAMCPIEIM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public DDCOLEKKBEE<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public MJBAMCPIEIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4D4D880", Offset = "0x4D4C480", VA = "0x184D4D880")]
			internal object PEFKMEMNNGH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class HHJCPOMCEPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public DDCOLEKKBEE<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public HHJCPOMCEPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x45B51F0", Offset = "0x45B3DF0", VA = "0x1845B51F0")]
			internal object JDKBONIIDJB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class JHINKAACMBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public DDCOLEKKBEE<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public JHINKAACMBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x493CAB0", Offset = "0x493B6B0", VA = "0x18493CAB0")]
			internal object EJKBMFJFIDG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const float BNLIEDOBLGK = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Guid PKLHPLNMANJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly string HKPMNNOAICG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly string KLAFJLMPPKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string HLHKGJFOKJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private string BEBJNLIHPCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private string FMEPJDOHLBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private string OPODICMFEMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private string MNFBDCCCCAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private string FMFAMCIHFLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private string PBLELPHOHON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private string JGFLIPDEPGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Guid? NLBKDEFCMIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private (int, int)? BAKIMCCFLPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly HashSet<T> JNGDCFNDKPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly Dictionary<(T, int), string> IIABGPIPCPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly Dictionary<(T, int), float> CKEMJEEAPFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Dictionary<T, string> DFIAIMCNEAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Dictionary<T, string[]> DJFPGHMMBIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private string HHKCFDPBJKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private bool EOELIECNGIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Task LLBBIGGFFDB;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x62FFF30", Offset = "0x62FEB30", VA = "0x1862FFF30")]
		public DDCOLEKKBEE(Guid PKLHPLNMANJ, string KLAFJLMPPKE, string HKPMNNOAICG, string HLHKGJFOKJM, [Optional] string BEBJNLIHPCE, [Optional] string FMEPJDOHLBG, [Optional] string OPODICMFEMG, [Optional] string PBLELPHOHON, [Optional] string HHKCFDPBJKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x95D140", Offset = "0x95BD40", VA = "0x18095D140")]
		public void DMDMPDBALJB(string BEBJNLIHPCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9574E0", Offset = "0x9560E0", VA = "0x1809574E0")]
		public void GOCGFBLFPIB(string HLHKGJFOKJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xBCAC10", Offset = "0xBC9810", VA = "0x180BCAC10")]
		public void GNBHBIAKJPL(string HHKCFDPBJKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x95EFF0", Offset = "0x95DBF0", VA = "0x18095EFF0")]
		public void EGLNKIMDLNO(string MNFBDCCCCAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x961530", Offset = "0x960130", VA = "0x180961530")]
		public void NKICLFIJNKD(string JGFLIPDEPGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x62FD640", Offset = "0x62FC240", VA = "0x1862FD640")]
		public void HNLFEAEFOLO(Guid? PKLHPLNMANJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1B2B7D0", Offset = "0x1B2A3D0", VA = "0x181B2B7D0")]
		public void JNGINPIHEML((int, int)? BAKIMCCFLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x95F040", Offset = "0x95DC40", VA = "0x18095F040")]
		public void LAIEDBKEPDK(string FMFAMCIHFLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x62FDEE0", Offset = "0x62FCAE0", VA = "0x1862FDEE0")]
		public void MFBEEFGDJJB(T CPNKHDBPNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x62FE570", Offset = "0x62FD170", VA = "0x1862FE570")]
		public void NFGBOIOFMBA(T CPNKHDBPNAC, int GAAPOMDIHJK, float ALPIBOHIFKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x62FC7D0", Offset = "0x62FB3D0", VA = "0x1862FC7D0")]
		public void HBMLMACNBHI(T CPNKHDBPNAC, int GAAPOMDIHJK, string EIFHHGJNFLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x62FD810", Offset = "0x62FC410", VA = "0x1862FD810")]
		public void JFPFNHDGFEA(T CPNKHDBPNAC, string EAGLKPCKNFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x62FBD70", Offset = "0x62FA970", VA = "0x1862FBD70")]
		public void DMKNKDFCFHA(T CPNKHDBPNAC, string[] MFDBFPIHJBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x62F96D0", Offset = "0x62F82D0", VA = "0x1862F96D0")]
		public Task BNOPHIDIEBO(bool NBNIPGNLIMD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x62FEC50", Offset = "0x62FD850", VA = "0x1862FEC50")]
		private (IEnumerable<T>, string) OEMGBBPPBHE()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x62FCE80", Offset = "0x62FBA80", VA = "0x1862FCE80")]
		public static INEHONOFCNC HBNDIPCFGCO(Guid PKLHPLNMANJ, string KLAFJLMPPKE, T CPNKHDBPNAC, string HKPMNNOAICG, string FNLMINALPAO, string BEBJNLIHPCE, int? BIEEMEKMINN, [Optional] string LGEOKBFAOEN, [Optional] string EAGLKPCKNFH, [Optional] int? DPCCEJBDFFK, [Optional] Guid? NLBKDEFCMIL, [Optional] string HHKCFDPBJKK, [Optional] string JBIFHOHNPLO, [Optional] (int, int)? BAKIMCCFLPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x62FD780", Offset = "0x62FC380", VA = "0x1862FD780")]
		[CompilerGenerated]
		private string JCLMFGBIIOP(T HGEMPDBGGBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x62FBB00", Offset = "0x62FA700", VA = "0x1862FBB00")]
		[CompilerGenerated]
		private string CAECGBEDENC(T HGEMPDBGGBJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class MJBFNHNOCEK<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		protected readonly string OOLGKGAAMHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		protected readonly Guid OICFLDGNLHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		protected readonly long HLKMIHCGHAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		protected int LHNFMFIAHOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		protected int JEGOJEHEGFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		protected DateTime ANLBJBLFGIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		protected bool BEGPGDBFHGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		protected Dictionary<long, GAKFHLFOFAG> HFFLPBIBLFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		protected bool BFFDFKNALKI;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool ALCMCMGHEPF
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xAB3FC0", Offset = "0xAB2BC0", VA = "0x180AB3FC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool GDGKAADAGJK
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xAFA9E0", Offset = "0xAF95E0", VA = "0x180AFA9E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4D4DE00", Offset = "0x4D4CA00", VA = "0x184D4DE00")]
		public MJBFNHNOCEK(string OOLGKGAAMHG, Guid OICFLDGNLHO, long HLKMIHCGHAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void FEOGMCEKOBM(TListSessionStartParams DGLCJOHNPAD);

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4D4DC80", Offset = "0x4D4C880", VA = "0x184D4DC80")]
		public void OCJGOCEMGAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void NLBFAJFDFAE(bool GBMKLOJNLMO, TListSessionLogParams PKIDMLLKNGO);

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4D4DCE0", Offset = "0x4D4C8E0", VA = "0x184D4DCE0")]
		public void PHCACBCHHIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4D4DBB0", Offset = "0x4D4C7B0", VA = "0x184D4DBB0")]
		public void LJCOCFCJMGG(long NDMNLGHHJKE, int BIEEMEKMINN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4D4D9C0", Offset = "0x4D4C5C0", VA = "0x184D4D9C0")]
		public void BGFDBCLAFCM(long NDMNLGHHJKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract GAKFHLFOFAG FFLLCMKPNKE(TItem HLGDOFMLIOK, int BIEEMEKMINN, string CGMLDHEADFF);
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class GAKFHLFOFAG : JLOMCHMJPBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private int LHNFMFIAHOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private long NDMNLGHHJKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private long HLKMIHCGHAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly string MKMPAGHEADD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly string HMLDLFMLNOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly int KAPPBHAGMHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private DateTime ELEOHLCPMHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private double BLABMPBLKMG;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool EFLDBNMFIPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xCC4450", Offset = "0xCC3050", VA = "0x180CC4450")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xCC4440", Offset = "0xCC3040", VA = "0x180CC4440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6AE6400", Offset = "0x6AE5000", VA = "0x186AE6400")]
		public GAKFHLFOFAG(long NDMNLGHHJKE, int LHNFMFIAHOI, string JBIFHOHNPLO, long HLKMIHCGHAM, int KAPPBHAGMHD, [Optional] string HKPMNNOAICG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6AE6280", Offset = "0x6AE4E80", VA = "0x186AE6280")]
		public void JICPMOBIEOF(int LHNFMFIAHOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6AE5D80", Offset = "0x6AE4980", VA = "0x186AE5D80")]
		public void DPIPODCDOPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6AE62F0", Offset = "0x6AE4EF0", VA = "0x186AE62F0")]
		public void PBIGLDIKBOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6AE5D20", Offset = "0x6AE4920", VA = "0x186AE5D20")]
		private void CLFBPBCELGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6AE5DD0", Offset = "0x6AE49D0", VA = "0x186AE5DD0", Slot = "5")]
		public virtual INEHONOFCNC FFBCEOIKLEO(Guid PKLHPLNMANJ, string LGFDJLFDMGB, [Optional] string JBIFHOHNPLO, [Optional] long? CPNKHDBPNAC, [Optional] string HKPMNNOAICG, [Optional] string BEBJNLIHPCE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class MKGIHKPBMGA
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static Dictionary<string, Dictionary<string, object>> LMKCGJHBPHJ;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static string GELFGHBKPGL;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static int KLMKKMPNOMD;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly Dictionary<string, KKAIANLKIHB> KJMGEJCHOEC;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static string JADHALBAFLP
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6AE8AD0", Offset = "0x6AE76D0", VA = "0x186AE8AD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6AE9190", Offset = "0x6AE7D90", VA = "0x186AE9190")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool CJKAMFFEIGD
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6AE8930", Offset = "0x6AE7530", VA = "0x186AE8930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static Dictionary<string, Dictionary<string, object>> ILKLLCMLAFG
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6AE9940", Offset = "0x6AE8540", VA = "0x186AE9940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static Guid? FMLCBKICEDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6AE94A0", Offset = "0x6AE80A0", VA = "0x186AE94A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6AE9F40", Offset = "0x6AE8B40", VA = "0x186AE9F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static Guid? JJMOANMNBFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6AE88D0", Offset = "0x6AE74D0", VA = "0x186AE88D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x6AE9440", Offset = "0x6AE8040", VA = "0x186AE9440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6AE93B0", Offset = "0x6AE7FB0", VA = "0x186AE93B0")]
		public static void GEBHCBJAEFN(string ELDOFHMNODP, KKAIANLKIHB COICCBJAGOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6AE87F0", Offset = "0x6AE73F0", VA = "0x186AE87F0")]
		internal static void AIMKJDEKJHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9990", Offset = "0x6AE8590", VA = "0x186AE9990")]
		internal static void LKJKNINAOLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9A70", Offset = "0x6AE8670", VA = "0x186AE9A70")]
		internal static void NEGCNFCHNIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8BC0", Offset = "0x6AE77C0", VA = "0x186AE8BC0")]
		public static Guid FEOGMCEKOBM(string ELDOFHMNODP, [Optional] string? ANIODJNIDPF, [Optional] Dictionary<string, object>? DDAHDLGEMLE)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8B20", Offset = "0x6AE7720", VA = "0x186AE8B20")]
		public static Guid FEOGMCEKOBM(string ELDOFHMNODP, long ANIODJNIDPF, [Optional] Dictionary<string, object>? DDAHDLGEMLE)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9CE0", Offset = "0x6AE88E0", VA = "0x186AE9CE0")]
		public static void OCJGOCEMGAI(string ELDOFHMNODP, [Optional] Guid? IEIMOIIMGDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6AE85F0", Offset = "0x6AE71F0", VA = "0x186AE85F0")]
		public static void AGCKLPCPMLK(string ELDOFHMNODP, string JFJJDJPFAIO, object FMOAKHMHEND, bool CHGMBDAKHKF = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9AF0", Offset = "0x6AE86F0", VA = "0x186AE9AF0")]
		public static bool NHLFAJIFJOD(string ELDOFHMNODP, [Optional] string? ANIODJNIDPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9240", Offset = "0x6AE7E40", VA = "0x186AE9240")]
		private static void FJPDKMBJBEK(bool LONJECKMMCK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9500", Offset = "0x6AE8100", VA = "0x186AE9500")]
		public static void HMBONKPLPJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6AE89C0", Offset = "0x6AE75C0", VA = "0x186AE89C0")]
		private static void DKDMAJADGNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9550", Offset = "0x6AE8150", VA = "0x186AE9550")]
		private static void KGECIFENFGD(string ELDOFHMNODP, Guid PKLHPLNMANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class GKFHHFGPOJE
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public struct JOBHINMHBHO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public bool CFLNFJDNJEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public string ADNNPIPKIEB;

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xAB5040", Offset = "0xAB3C40", VA = "0x180AB5040")]
			public JOBHINMHBHO(bool CFLNFJDNJEK, string ADNNPIPKIEB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6AE65D0", Offset = "0x6AE51D0", VA = "0x186AE65D0")]
		public static JOBHINMHBHO HBFNBGCENOB(INEHONOFCNC AEOOLJFIGNK)
		{
			return default(JOBHINMHBHO);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6AE64D0", Offset = "0x6AE50D0", VA = "0x186AE64D0")]
		private static void ALJMDIPFBHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6AE68E0", Offset = "0x6AE54E0", VA = "0x186AE68E0")]
		private static void LILCBANNIND()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class OOPLIOKILKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB8F0", Offset = "0x6AEA4F0", VA = "0x186AEB8F0")]
		public static INEHONOFCNC GBBNPAJOELK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class MEKEOBGIOFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8230", Offset = "0x6AE6E30", VA = "0x186AE8230")]
		public static INEHONOFCNC FNEEENMHNLN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8590", Offset = "0x6AE7190", VA = "0x186AE8590")]
		public static INEHONOFCNC OODJPPHMNAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8410", Offset = "0x6AE7010", VA = "0x186AE8410")]
		public static INEHONOFCNC LLODKGCHNDB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8110", Offset = "0x6AE6D10", VA = "0x186AE8110")]
		public static INEHONOFCNC DIGCAJKPILI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6AE81D0", Offset = "0x6AE6DD0", VA = "0x186AE81D0")]
		public static INEHONOFCNC EIKFKHHDFFO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6AE83B0", Offset = "0x6AE6FB0", VA = "0x186AE83B0")]
		public static INEHONOFCNC LKHHGMMCGOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8170", Offset = "0x6AE6D70", VA = "0x186AE8170")]
		public static INEHONOFCNC DJNNMKOFALA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8470", Offset = "0x6AE7070", VA = "0x186AE8470")]
		public static INEHONOFCNC LMCLFFLLHKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6AE82F0", Offset = "0x6AE6EF0", VA = "0x186AE82F0")]
		public static INEHONOFCNC KAGMKEBPKMD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8290", Offset = "0x6AE6E90", VA = "0x186AE8290")]
		public static INEHONOFCNC IHCJFMCIOCN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8050", Offset = "0x6AE6C50", VA = "0x186AE8050")]
		public static INEHONOFCNC BEPGGPDIGBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6AE84D0", Offset = "0x6AE70D0", VA = "0x186AE84D0")]
		public static INEHONOFCNC NKPEDFNEONH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6AE80B0", Offset = "0x6AE6CB0", VA = "0x186AE80B0")]
		public static INEHONOFCNC CKJBBIPHIHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8530", Offset = "0x6AE7130", VA = "0x186AE8530")]
		public static INEHONOFCNC OEMMDDGKCNK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8350", Offset = "0x6AE6F50", VA = "0x186AE8350")]
		public static INEHONOFCNC LBBLLMHFFLA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class LFHFAJLICLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6AE7880", Offset = "0x6AE6480", VA = "0x186AE7880")]
		public static INEHONOFCNC GJIHICPDJBA(long EPGJLNEAJPA, long DMLJPKIDBPD, bool EOAKNLHPNPC, string EIJOHECMODB, string JJBBHCEPEAL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class ACAEBGLBODJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2070", Offset = "0x6AE0C70", VA = "0x186AE2070")]
		public static INEHONOFCNC CPHPNBBMNFA(string PAPJGOHIOPF, string GLDNAAMGMFE, bool MGOHIMNCJDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6AE21E0", Offset = "0x6AE0DE0", VA = "0x186AE21E0")]
		public static INEHONOFCNC OKDJFIKEDFJ(string HJIAOGEIAJO, string GNNHLOLFEAO, string HHEPOPEFOGM, [Optional] int? GALBCIIPJEK, [Optional] double[] NHKJEKEOOPP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class AOBDDKGMFDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2AA0", Offset = "0x6AE16A0", VA = "0x186AE2AA0")]
		public static INEHONOFCNC KCDDLJNCBPB(string EFANCGIMGGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2B80", Offset = "0x6AE1780", VA = "0x186AE2B80")]
		public static INEHONOFCNC KPELLHKEFLO(string BNBLBPPDHED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2CC0", Offset = "0x6AE18C0", VA = "0x186AE2CC0")]
		public static INEHONOFCNC OIPNEHPNENC(int HOGOECIJPMO, string BGKKCEGMOKH, string HGEMPDBGGBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2C60", Offset = "0x6AE1860", VA = "0x186AE2C60")]
		public static INEHONOFCNC NELJOKDBBBC(int HOGOECIJPMO, string BGKKCEGMOKH, string HGEMPDBGGBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2A40", Offset = "0x6AE1640", VA = "0x186AE2A40")]
		public static INEHONOFCNC HDJBKPACGDI(int HOGOECIJPMO, string BGKKCEGMOKH, string HGEMPDBGGBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6AE29E0", Offset = "0x6AE15E0", VA = "0x186AE29E0")]
		public static INEHONOFCNC CKAHCPNJFDH(int HOGOECIJPMO, string BGKKCEGMOKH, string HGEMPDBGGBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2620", Offset = "0x6AE1220", VA = "0x186AE2620")]
		public static INEHONOFCNC BFFBDFPJPCF(string BGKKCEGMOKH, string HGEMPDBGGBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2770", Offset = "0x6AE1370", VA = "0x186AE2770")]
		private static INEHONOFCNC BMGDIAIMNEO(string OOLGKGAAMHG, int HOGOECIJPMO, string KNILEKCKPGD, string DBLDPMGIHOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6AE28B0", Offset = "0x6AE14B0", VA = "0x186AE28B0")]
		private static INEHONOFCNC BMGDIAIMNEO(string OOLGKGAAMHG, string KNILEKCKPGD, string DBLDPMGIHOH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly NDNFAPMFFIF HBFNBGCENOB;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static BJLGAMNMGNO GLOGAFIJIKA;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static MHFAMGHACND PGCAKJKAMFL;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<INEHONOFCNC> JFAAJCINIOE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long JADIMCPHKLC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6AE3620", Offset = "0x6AE2220", VA = "0x186AE3620")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3410", Offset = "0x6AE2010", VA = "0x186AE3410")]
	[DCPAEAFJNOM.MNANKELNNCD]
	internal static void IPDLJBOPGNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3350", Offset = "0x6AE1F50", VA = "0x186AE3350")]
	private static void DNKJGNCIOBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6AE31C0", Offset = "0x6AE1DC0", VA = "0x186AE31C0")]
	public static INEHONOFCNC BGBMIEFMAON(string BBNMPEGFDHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3240", Offset = "0x6AE1E40", VA = "0x186AE3240")]
	public static INEHONOFCNC BGBMIEFMAON(string BBNMPEGFDHI, int HOGOECIJPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3500", Offset = "0x6AE2100", VA = "0x186AE3500")]
	[DCPAEAFJNOM.MNANKELNNCD]
	internal static void JPNPCDBGNNL()
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
