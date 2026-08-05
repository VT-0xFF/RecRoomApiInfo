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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72AB920", Offset = "0x72AA720", VA = "0x1872AB920")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA34390", Offset = "0xA33190", VA = "0x180A34390")]
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
		[Cpp2IlInjected.Address(RVA = "0xA343D0", Offset = "0xA331D0", VA = "0x180A343D0")]
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
	public class LogRegistrationIndex : FNHPAIPGMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72A9A40", Offset = "0x72A8840", VA = "0x1872A9A40", Slot = "4")]
		public override void KEMEJJLNDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72AD550", Offset = "0x72AC350", VA = "0x1872AD550", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x26D4E40", Offset = "0x26D3C40", VA = "0x1826D4E40")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NHKFJHLCNDG
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> IMFEIJODHPP();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HGJGGMDLLEL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x72A6CC0", Offset = "0x72A5AC0", VA = "0x1872A6CC0")]
	public static void AJCMDPEHEFG(this CCCIFPADPNE.LFGAOKKGEDL KILKKEDADPK, string CABIGHMOLFB, string OCFAEJPMOOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x72A6B30", Offset = "0x72A5930", VA = "0x1872A6B30")]
	public static void AJCMDPEHEFG(this CCCIFPADPNE.LFGAOKKGEDL KILKKEDADPK, string CABIGHMOLFB, bool OCFAEJPMOOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x72A6BC0", Offset = "0x72A59C0", VA = "0x1872A6BC0")]
	public static void AJCMDPEHEFG(this CCCIFPADPNE.LFGAOKKGEDL KILKKEDADPK, string CABIGHMOLFB, float OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x72A6D30", Offset = "0x72A5B30", VA = "0x1872A6D30")]
	public static void AJCMDPEHEFG(this CCCIFPADPNE.LFGAOKKGEDL KILKKEDADPK, string CABIGHMOLFB, GNDOAOEBOOF OCFAEJPMOOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CCCIFPADPNE
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface LLHGDODAPFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		LFGAOKKGEDL ALMGMAOMMIE(Guid BBAEOJCMCPP, string HHEKICDDKMA, [Optional] string GDOIEHBMHFL, [Optional] long? CDLAIGKCEFI, [Optional] string DBCOPINAGKK, [Optional] string FHOBLGBBIOL);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class JMPOGEIMEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x72A7560", Offset = "0x72A6360", VA = "0x1872A7560")]
		public static LFGAOKKGEDL DMKBEAJMMGD(Guid BBAEOJCMCPP, string HHEKICDDKMA, string GDOIEHBMHFL, [Optional] long? CDLAIGKCEFI, [Optional] string DBCOPINAGKK, [Optional] string FHOBLGBBIOL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class LFGAOKKGEDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected PJMADGOILAJ FELHJOMEEAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly IDictionary<string, IDictionary<string, object>> MGOIFNBOLCD;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool LFHJDDDDDOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x72A96B0", Offset = "0x72A84B0", VA = "0x1872A96B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string AIIGFDAMABA
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x116D810", Offset = "0x116C610", VA = "0x18116D810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x72A9960", Offset = "0x72A8760", VA = "0x1872A9960")]
		public LFGAOKKGEDL(PJMADGOILAJ FELHJOMEEAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x72A91E0", Offset = "0x72A7FE0", VA = "0x1872A91E0")]
		public LFGAOKKGEDL BKFPPFNACDA(string FEMKAJANBPA, string OAIIHELJHLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x72A9520", Offset = "0x72A8320", VA = "0x1872A9520")]
		public LFGAOKKGEDL GHAFFLPAEMI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x404FE70", Offset = "0x404EC70", VA = "0x18404FE70")]
		public LFGAOKKGEDL BKFPPFNACDA<T>(string FEMKAJANBPA, T OAIIHELJHLG) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x72A9850", Offset = "0x72A8650", VA = "0x1872A9850")]
		public LFGAOKKGEDL OFLNEEPJPJB(string FEMKAJANBPA, object OAIIHELJHLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x40502A0", Offset = "0x404F0A0", VA = "0x1840502A0")]
		public LFGAOKKGEDL OHLCLPJLPPJ<T>(string FEMKAJANBPA, T? OAIIHELJHLG) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x72A98D0", Offset = "0x72A86D0", VA = "0x1872A98D0")]
		public LFGAOKKGEDL OHLCLPJLPPJ(string FEMKAJANBPA, string OAIIHELJHLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x72A8FB0", Offset = "0x72A7DB0", VA = "0x1872A8FB0")]
		public LFGAOKKGEDL AIECOKGKOPH(string DPOMLDJKCBL, string MAKJJJECHHB, object FFEMKICJPKP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x72A9100", Offset = "0x72A7F00", VA = "0x1872A9100")]
		public LFGAOKKGEDL AIECOKGKOPH(string DPOMLDJKCBL, IDictionary<string, object> HMGJLPMKAIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x72A97F0", Offset = "0x72A85F0", VA = "0x1872A97F0")]
		private static IDictionary<string, object> KIMPJAAFNEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x72A9260", Offset = "0x72A8060", VA = "0x1872A9260")]
		public void FCCFPCOFODJ(bool EFIOMDGIPDA, string OOODDENHKAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x72A96F0", Offset = "0x72A84F0", VA = "0x1872A96F0")]
		public Task JLOKOIMAMOB([Optional] CancellationToken GHKBKDKNIOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2807B10", Offset = "0x2806910", VA = "0x182807B10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PJMADGOILAJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct DLEKNAHOMKB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public PJMADGOILAJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x72A41F0", Offset = "0x72A2FF0", VA = "0x1872A41F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x72A4670", Offset = "0x72A3470", VA = "0x1872A4670", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static Action<PJMADGOILAJ> MKKMDFPANIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly string GFCALFFADOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<string, object> NNHGFFCICBJ;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string AIIGFDAMABA
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x72ACEF0", Offset = "0x72ABCF0", VA = "0x1872ACEF0")]
		private PJMADGOILAJ(string GFCALFFADOM, int OEBMJHLGKIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x72A35E0", Offset = "0x72A23E0", VA = "0x1872A35E0")]
		public static LFGAOKKGEDL BHEMCOAOOEF(string GFCALFFADOM, int OEBMJHLGKIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x72ACCD0", Offset = "0x72ABAD0", VA = "0x1872ACCD0")]
		[AsyncStateMachine(typeof(DLEKNAHOMKB))]
		public Task JLOKOIMAMOB([Optional] CancellationToken GHKBKDKNIOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x72ACE80", Offset = "0x72ABC80", VA = "0x1872ACE80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x36A6530", Offset = "0x36A5330", VA = "0x1836A6530")]
		internal void NEDIJHBOHKB<T>(string FEMKAJANBPA, T OAIIHELJHLG) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x72ACDC0", Offset = "0x72ABBC0", VA = "0x1872ACDC0")]
		internal void NAOFAIOEKOH(string FEMKAJANBPA, object OAIIHELJHLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x72ACE20", Offset = "0x72ABC20", VA = "0x1872ACE20")]
		internal void NEDIJHBOHKB(string FEMKAJANBPA, string OAIIHELJHLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4051E10", Offset = "0x4050C10", VA = "0x184051E10")]
		private void DOCFPGLGCNO<T>(string FEMKAJANBPA, T OAIIHELJHLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct LLDNKEBKNME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string KHDNAAOHCNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly long? FBNGFADIKHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly short? FLDBFGMOLFI;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x72A9A00", Offset = "0x72A8800", VA = "0x1872A9A00")]
		public LLDNKEBKNME(string JNNGLDIJLCB, [Optional] long? CEACGIDOODJ, [Optional] short? FBBDNEJPGJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct GDJIFKBCJIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly int KHGBDIOBNJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly string KIDBBBDGAJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly short BDBJEMKCKAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly string AIIIDAHCPBJ;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x72A6AE0", Offset = "0x72A58E0", VA = "0x1872A6AE0")]
		public GDJIFKBCJIH(int JHMCFJAKFJL, string NNHHIKDOBPP, short LGGBNPOGJAO, string GHBNCOOFIEJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class FOGILECAKLI : MAGJGDIHDAA<HKOENFNFOIG, GDJIFKBCJIH, LLDNKEBKNME>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string NNHHIKDOBPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private short LGGBNPOGJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private string GHBNCOOFIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Dictionary<short, int> ICMNKPFHECD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int HOONKBFHCMH;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x72A6A60", Offset = "0x72A5860", VA = "0x1872A6A60")]
		public FOGILECAKLI(string DKLCKHOLDNA, Guid NDBMELDDHCD, long LHCFJOFMAJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x72A55F0", Offset = "0x72A43F0", VA = "0x1872A55F0", Slot = "4")]
		public override void JEJMNEEIEDK(GDJIFKBCJIH HCLHBPGAHON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x72A6980", Offset = "0x72A5780", VA = "0x1872A6980")]
		public void OGBEOLCOABM(short LGGBNPOGJAO, bool HLLNFOKHIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4A34280", Offset = "0x4A33080", VA = "0x184A34280")]
		public void KPNAGCOFMIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA0CFD0", Offset = "0xA0BDD0", VA = "0x180A0CFD0")]
		public void CMEBDMEGIDO(string NJIMCPEPFMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x72A58E0", Offset = "0x72A46E0", VA = "0x1872A58E0", Slot = "5")]
		public override void KCLMNNJJEFC(bool AGMPPCMOKCG, LLDNKEBKNME LHBLFPLIOMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x72A66C0", Offset = "0x72A54C0", VA = "0x1872A66C0", Slot = "6")]
		public override FKMPKELLBKD KMGBECOLPFG(HKOENFNFOIG APCJGFMILJK, int GLAOLHCPLLG, string EMAMFJDABJL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class MOKBAEGEFLJ : FKMPKELLBKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private string NNHHIKDOBPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly short LGGBNPOGJAO;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x72AB830", Offset = "0x72AA630", VA = "0x1872AB830")]
		public MOKBAEGEFLJ(long BPLOOBBHEML, int JHMCFJAKFJL, string GDOIEHBMHFL, long LHCFJOFMAJL, int BAHPLOJDMHF, string DBCOPINAGKK, short LGGBNPOGJAO, string NNHHIKDOBPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x72AB7A0", Offset = "0x72AA5A0", VA = "0x1872AB7A0")]
		public void NANANNDGBNK(int JHMCFJAKFJL, string NNHHIKDOBPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x72AB670", Offset = "0x72AA470", VA = "0x1872AB670", Slot = "5")]
		public override LFGAOKKGEDL ALMGMAOMMIE(Guid BBAEOJCMCPP, string HHEKICDDKMA, [Optional] string GDOIEHBMHFL, [Optional] long? CDLAIGKCEFI, [Optional] string DBCOPINAGKK, [Optional] string FHOBLGBBIOL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class KOBFCALMEHP
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class DFNFKGCPEEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float nextEventSendTime;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public DFNFKGCPEEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x72A4150", Offset = "0x72A2F50", VA = "0x1872A4150")]
			internal bool GHDAHKOBABA()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct OEJJPKFLDEP : IAsyncStateMachine
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
			private DFNFKGCPEEF <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TimeSpan <delayPollingInterval>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x72AB9A0", Offset = "0x72AA7A0", VA = "0x1872AB9A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x72AC680", Offset = "0x72AB480", VA = "0x1872AC680", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct PBCEAPPECJI : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x72AC6E0", Offset = "0x72AB4E0", VA = "0x1872AC6E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x72ACC70", Offset = "0x72ABA70", VA = "0x1872ACC70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly float ODCIKIEGGOM;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static IPJEPIMCHKK FMBEDHKNIIH;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static CancellationTokenSource AFMALIENJFI;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static bool JODDCGBBFEH;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static int MJOEOHKOPBL;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly DPJKFCBILHL<LFGAOKKGEDL, bool> NHOBJENGHDK;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static BMBFOKPPNEL<LFGAOKKGEDL, bool> ADNNMPOABPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x72A88B0", Offset = "0x72A76B0", VA = "0x1872A88B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static bool IEGCPDKHHHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x72A8660", Offset = "0x72A7460", VA = "0x1872A8660")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x72A8400", Offset = "0x72A7200", VA = "0x1872A8400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private static bool PIDCIFMIBNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x72A8900", Offset = "0x72A7700", VA = "0x1872A8900")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x72A8E40", Offset = "0x72A7C40", VA = "0x1872A8E40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private static float COEMKCGAFND
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x72A7CC0", Offset = "0x72A6AC0", VA = "0x1872A7CC0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x72A7ED0", Offset = "0x72A6CD0", VA = "0x1872A7ED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x72A8790", Offset = "0x72A7590", VA = "0x1872A8790")]
		[EKIJCKMDHHI.FMCMFJEHLNM]
		internal static void LEFIBIPABED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x72A8460", Offset = "0x72A7260", VA = "0x1872A8460")]
		internal static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x72A7D10", Offset = "0x72A6B10", VA = "0x1872A7D10")]
		internal static void BPDAHNLNAAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x72A8390", Offset = "0x72A7190", VA = "0x1872A8390")]
		internal static void DKGLDMOKBIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x72A8A30", Offset = "0x72A7830", VA = "0x1872A8A30")]
		public static void PDLDFILINAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x72A7F30", Offset = "0x72A6D30", VA = "0x1872A7F30")]
		private static void DIAPJLGJBFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x72A8B50", Offset = "0x72A7950", VA = "0x1872A8B50")]
		private static void PGBEFHGNFAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x72A8A80", Offset = "0x72A7880", VA = "0x1872A8A80")]
		[AsyncStateMachine(typeof(OEJJPKFLDEP))]
		private static Task PEACEJKNPIH(CancellationToken GHKBKDKNIOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x72A86B0", Offset = "0x72A74B0", VA = "0x1872A86B0")]
		private static void LDKKCMCAAII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x72A8950", Offset = "0x72A7750", VA = "0x1872A8950")]
		[AsyncStateMachine(typeof(PBCEAPPECJI))]
		private static Task MLBODCKNMFF(bool DINPGABEGMK, [Optional] CancellationToken GHKBKDKNIOM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class CDNLOFDLOMO<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class NDLDKNIBOAD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public CDNLOFDLOMO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public NDLDKNIBOAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x54A1210", Offset = "0x54A0010", VA = "0x1854A1210")]
			internal object GJBKCGGMGFF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class KAPEKGPELOK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public CDNLOFDLOMO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public KAPEKGPELOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x50946A0", Offset = "0x50934A0", VA = "0x1850946A0")]
			internal object GBOCAIFJGAH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class INPHBPMHKBD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public CDNLOFDLOMO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public INPHBPMHKBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x4D54840", Offset = "0x4D53640", VA = "0x184D54840")]
			internal object GFCNCKBEEGF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class FNMCOPHNENC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public CDNLOFDLOMO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public FNMCOPHNENC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x4ADA3B0", Offset = "0x4AD91B0", VA = "0x184ADA3B0")]
			internal object ONMNJDKLLNO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class KIAOALGHKNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public CDNLOFDLOMO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public KIAOALGHKNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x50AB920", Offset = "0x50AA720", VA = "0x1850AB920")]
			internal object GFDDBOPIFHN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class IDDCFIDHIKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public CDNLOFDLOMO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public IDDCFIDHIKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x4D2E080", Offset = "0x4D2CE80", VA = "0x184D2E080")]
			internal object AJIKCFLLLLD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class FIEFOINEHLL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public CDNLOFDLOMO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public FIEFOINEHLL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x4ACE970", Offset = "0x4ACD770", VA = "0x184ACE970")]
			internal object EEBBPDOBGEM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const float LPFDNGDBFFG = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Guid BBAEOJCMCPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly Guid BAPDPLEOLBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly string DBCOPINAGKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string KJFLKLDLNKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private string OAJMGAFGLIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private string FHOBLGBBIOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private string NCJKLLAEEAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private string LPNBKPOHCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private string PBJLMMGEPMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private string CCJBEFJBFLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private string ICIAPPMOGIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private string CJAMGOLGEHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private string FIFLJBBKOEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Guid? CKDEGAPOLOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private (int, int)? LCHFAPPPCOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly HashSet<T> KDIMFPNBIIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Dictionary<(T, int), string> JMDPIPENMBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Dictionary<(T, int), float> IFJKEBOJNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Dictionary<T, string> PEPBKPFMDLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly Dictionary<T, string> EEECBPNOPPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<T, string> DKPPPJHIGJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly Dictionary<T, string[]> JONHKKAEADH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private string JKJIDDNMEBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool PEMLOONDLIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private Task PGFECOBJLFM;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x65568E0", Offset = "0x65556E0", VA = "0x1865568E0")]
		public CDNLOFDLOMO(Guid BBAEOJCMCPP, Guid BAPDPLEOLBE, string KJFLKLDLNKE, string DBCOPINAGKK, string OAJMGAFGLIJ, [Optional] string FHOBLGBBIOL, [Optional] string NCJKLLAEEAK, [Optional] string LPNBKPOHCIG, [Optional] string ICIAPPMOGIM, [Optional] string JKJIDDNMEBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA0DA00", Offset = "0xA0C800", VA = "0x180A0DA00")]
		public void GOFFNGNHABN(string FHOBLGBBIOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBF0", Offset = "0xA0D9F0", VA = "0x180A0EBF0")]
		public void OECHMEBDCKO(string OAJMGAFGLIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xBCF790", Offset = "0xBCE590", VA = "0x180BCF790")]
		public void OABKPMABADE(string JKJIDDNMEBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA0CFE0", Offset = "0xA0BDE0", VA = "0x180A0CFE0")]
		public void GDAKHHGHPNE(string PBJLMMGEPMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA0D8E0", Offset = "0xA0C6E0", VA = "0x180A0D8E0")]
		public void CCDCLPCAACL(string CJAMGOLGEHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA0D960", Offset = "0xA0C760", VA = "0x180A0D960")]
		public void ADCGHGGCJFK(string FIFLJBBKOEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6551780", Offset = "0x6550580", VA = "0x186551780")]
		public void HBPHAPIKACF(Guid? BBAEOJCMCPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1724DD0", Offset = "0x1723BD0", VA = "0x181724DD0")]
		public void LDBFCHEPBMI((int, int)? LCHFAPPPCOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA0CFD0", Offset = "0xA0BDD0", VA = "0x180A0CFD0")]
		public void OJBOEJOFHHK(string CCJBEFJBFLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6555DF0", Offset = "0x6554BF0", VA = "0x186555DF0")]
		public void LPKKCFHJCLO(T CDLAIGKCEFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x654FEB0", Offset = "0x654ECB0", VA = "0x18654FEB0")]
		public void DIFNLCFDPOP(T CDLAIGKCEFI, int EEOIFKDEOOL, float NFGIPBFMCLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6556140", Offset = "0x6554F40", VA = "0x186556140")]
		public void PGELFANLPHL(T CDLAIGKCEFI, int EEOIFKDEOOL, string JJPOHFOMDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6551AF0", Offset = "0x65508F0", VA = "0x186551AF0")]
		public void HOBPLKEIIMO(T CDLAIGKCEFI, string CHAHFAHCPBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6551E40", Offset = "0x6550C40", VA = "0x186551E40")]
		public void IGMFLFMBPCF(T CDLAIGKCEFI, string JOOOKIJNKHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6555740", Offset = "0x6554540", VA = "0x186555740")]
		public void JPMGIDECNNG(T CDLAIGKCEFI, bool HHGHOBMMLOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6551430", Offset = "0x6550230", VA = "0x186551430")]
		public void GMPOCOLIHJA(T CDLAIGKCEFI, string[] ABLIGBLACIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6553250", Offset = "0x6552050", VA = "0x186553250")]
		public Task JLOKOIMAMOB(bool PGBCKJJIOAA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x654F070", Offset = "0x654DE70", VA = "0x18654F070")]
		private (IEnumerable<T>, string) BFGNPOHDEML()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x65506C0", Offset = "0x654F4C0", VA = "0x1865506C0")]
		public static LFGAOKKGEDL FHCDEKGAMMM(Guid BBAEOJCMCPP, Guid BAPDPLEOLBE, string KJFLKLDLNKE, T CDLAIGKCEFI, string DBCOPINAGKK, string OIEGLGFNBGG, string FHOBLGBBIOL, int? GLAOLHCPLLG, [Optional] string KNDGFGEOKNA, [Optional] string CHAHFAHCPBF, [Optional] int? AJBKDOMAGBG, [Optional] Guid? CKDEGAPOLOP, [Optional] string JKJIDDNMEBI, [Optional] string GDOIEHBMHFL, [Optional] (int, int)? LCHFAPPPCOI, [Optional] string LKALJJIPPMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6556020", Offset = "0x6554E20", VA = "0x186556020")]
		[CompilerGenerated]
		private string OEIMCGBLNPC(T FONJFDCCINO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6555910", Offset = "0x6554710", VA = "0x186555910")]
		[CompilerGenerated]
		private string LHKBMIEOCHL(T FONJFDCCINO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6551010", Offset = "0x654FE10", VA = "0x186551010")]
		[CompilerGenerated]
		private string GMEODKJDNJO(T FONJFDCCINO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x654F730", Offset = "0x654E530", VA = "0x18654F730")]
		[CompilerGenerated]
		private string DDKNALGBLAO(T FONJFDCCINO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public abstract class MAGJGDIHDAA<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		protected readonly string DKLCKHOLDNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		protected readonly Guid NDBMELDDHCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		protected readonly long LHCFJOFMAJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		protected int JHMCFJAKFJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		protected int HOHBOOHDLCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		protected DateTime JIAECILBGFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		protected bool JFNCGMFMKMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		protected Dictionary<long, FKMPKELLBKD> HPNDGNBDMAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		protected bool OOBPOFOIOPO;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool JOMBMMHEOJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xC3A4D0", Offset = "0xC392D0", VA = "0x180C3A4D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HGFEOPEGNAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xC904C0", Offset = "0xC8F2C0", VA = "0x180C904C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x538C7F0", Offset = "0x538B5F0", VA = "0x18538C7F0")]
		public MAGJGDIHDAA(string DKLCKHOLDNA, Guid NDBMELDDHCD, long LHCFJOFMAJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void JEJMNEEIEDK(TListSessionStartParams HCLHBPGAHON);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x4DBF840", Offset = "0x4DBE640", VA = "0x184DBF840")]
		public void FMNMMLCKJPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void KCLMNNJJEFC(bool AGMPPCMOKCG, TListSessionLogParams LHBLFPLIOMG);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x538C4E0", Offset = "0x538B2E0", VA = "0x18538C4E0")]
		public void CGDBIALMODD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x538C650", Offset = "0x538B450", VA = "0x18538C650")]
		public void MBEALPGJIAL(long BPLOOBBHEML, int GLAOLHCPLLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x538C530", Offset = "0x538B330", VA = "0x18538C530")]
		public void KAJNGFBNDEM(long BPLOOBBHEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract FKMPKELLBKD KMGBECOLPFG(TItem HHHFHHLBBIL, int GLAOLHCPLLG, string EMAMFJDABJL);
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class FKMPKELLBKD : LLHGDODAPFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private int JHMCFJAKFJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private long BPLOOBBHEML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private long LHCFJOFMAJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly string ILEGBMMMIKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly string IABMKBAKPFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly int BAHPLOJDMHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private DateTime KKEGEHDJCFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private double ODNKCIENMGN;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool OBHGJIFFHCI
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xE52870", Offset = "0xE51670", VA = "0x180E52870")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xE52140", Offset = "0xE50F40", VA = "0x180E52140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x72A5520", Offset = "0x72A4320", VA = "0x1872A5520")]
		public FKMPKELLBKD(long BPLOOBBHEML, int JHMCFJAKFJL, string GDOIEHBMHFL, long LHCFJOFMAJL, int BAHPLOJDMHF, [Optional] string DBCOPINAGKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x72A5330", Offset = "0x72A4130", VA = "0x1872A5330")]
		public void ILPLLJAHEBL(int JHMCFJAKFJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x72A4E30", Offset = "0x72A3C30", VA = "0x1872A4E30")]
		public void AACGHMHICKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x72A5410", Offset = "0x72A4210", VA = "0x1872A5410")]
		public void PHHNJCNKEGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x72A53A0", Offset = "0x72A41A0", VA = "0x1872A53A0")]
		private void OKGNOLOJOJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x72A4E80", Offset = "0x72A3C80", VA = "0x1872A4E80", Slot = "5")]
		public virtual LFGAOKKGEDL ALMGMAOMMIE(Guid BBAEOJCMCPP, string HHEKICDDKMA, [Optional] string GDOIEHBMHFL, [Optional] long? CDLAIGKCEFI, [Optional] string DBCOPINAGKK, [Optional] string FHOBLGBBIOL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class MGICKNACIMK
	{
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static Dictionary<string, Dictionary<string, object>> JNEBELHJLJK;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static string JGHMFODPIMH;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static int NPIGHPCJMAP;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly Dictionary<string, NHKFJHLCNDG> CCBCOFMHECP;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static string IIENFLJMFKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x72AA810", Offset = "0x72A9610", VA = "0x1872AA810")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x72AA860", Offset = "0x72A9660", VA = "0x1872AA860")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool GFHOHCNKMLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x72AB310", Offset = "0x72AA110", VA = "0x1872AB310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static Dictionary<string, Dictionary<string, object>> PEKCFLBNCAO
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x72AB4C0", Offset = "0x72AA2C0", VA = "0x1872AB4C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static Guid? LELNGEEBJIF
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x72A9FB0", Offset = "0x72A8DB0", VA = "0x1872A9FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x72AA3C0", Offset = "0x72A91C0", VA = "0x1872AA3C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static Guid? JAAKLFCDJBH
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x72AA420", Offset = "0x72A9220", VA = "0x1872AA420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x72AA0A0", Offset = "0x72A8EA0", VA = "0x1872AA0A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x72AA570", Offset = "0x72A9370", VA = "0x1872AA570")]
		public static void IDECMODPEGN(string AKMJMGJJIPC, NHKFJHLCNDG LGIMLAHNNLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x72AA490", Offset = "0x72A9290", VA = "0x1872AA490")]
		internal static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x72A9ED0", Offset = "0x72A8CD0", VA = "0x1872A9ED0")]
		internal static void BPDAHNLNAAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x72AA020", Offset = "0x72A8E20", VA = "0x1872AA020")]
		internal static void DKGLDMOKBIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x72AA9C0", Offset = "0x72A97C0", VA = "0x1872AA9C0")]
		public static Guid JEJMNEEIEDK(string AKMJMGJJIPC, [Optional] string? BKNAPIJEONI, [Optional] Dictionary<string, object>? CBOGDPLKMHI)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x72AA920", Offset = "0x72A9720", VA = "0x1872AA920")]
		public static Guid JEJMNEEIEDK(string AKMJMGJJIPC, long BKNAPIJEONI, [Optional] Dictionary<string, object>? CBOGDPLKMHI)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x72AA100", Offset = "0x72A8F00", VA = "0x1872AA100")]
		public static void FMNMMLCKJPD(string AKMJMGJJIPC, [Optional] Guid? PDFBNFKDLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x72AA600", Offset = "0x72A9400", VA = "0x1872AA600")]
		public static void IELEPFJLDME(string AKMJMGJJIPC, string DPOMLDJKCBL, object OGAHDIKLMGK, bool JODDCGBBFEH = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x72AAFA0", Offset = "0x72A9DA0", VA = "0x1872AAFA0")]
		public static bool MNICBABDGLE(string AKMJMGJJIPC, [Optional] string? BKNAPIJEONI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x72AB190", Offset = "0x72A9F90", VA = "0x1872AB190")]
		private static void NFOFGNIHJJH(bool LDIBACDBHKE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x72AA360", Offset = "0x72A9160", VA = "0x1872AA360")]
		public static void GKILLFBLBHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x72AB3A0", Offset = "0x72AA1A0", VA = "0x1872AB3A0")]
		private static void PGBEFHGNFAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x72A9AD0", Offset = "0x72A88D0", VA = "0x1872A9AD0")]
		private static void AHKGOAAFFIO(string AKMJMGJJIPC, Guid BBAEOJCMCPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class HMGKPCALIIE
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public struct IJMPGAPCNNI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public bool FHEDCABKFLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public string PEIFKAPFPCB;

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xC3B360", Offset = "0xC3A160", VA = "0x180C3B360")]
			public IJMPGAPCNNI(bool FHEDCABKFLG, string PEIFKAPFPCB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x72A7240", Offset = "0x72A6040", VA = "0x1872A7240")]
		public static IJMPGAPCNNI NDLHJECGFPL(LFGAOKKGEDL KILKKEDADPK)
		{
			return default(IJMPGAPCNNI);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x72A7140", Offset = "0x72A5F40", VA = "0x1872A7140")]
		private static void JJDGBFCMAMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x72A7080", Offset = "0x72A5E80", VA = "0x1872A7080")]
		private static void IGJFEGDFKOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class FAKNHDKIPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x72A4DD0", Offset = "0x72A3BD0", VA = "0x1872A4DD0")]
		public static LFGAOKKGEDL LMBLINLJIHP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class DAABADCBAIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x72A3FD0", Offset = "0x72A2DD0", VA = "0x1872A3FD0")]
		public static LFGAOKKGEDL OKNFJIADDNI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x72A3F10", Offset = "0x72A2D10", VA = "0x1872A3F10")]
		public static LFGAOKKGEDL NFBMLLNCLKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x72A3C10", Offset = "0x72A2A10", VA = "0x1872A3C10")]
		public static LFGAOKKGEDL BPADBILBFGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x72A40F0", Offset = "0x72A2EF0", VA = "0x1872A40F0")]
		public static LFGAOKKGEDL PEEFGLJOCFL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x72A3D30", Offset = "0x72A2B30", VA = "0x1872A3D30")]
		public static LFGAOKKGEDL DHHBOCOGBAA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x72A3C70", Offset = "0x72A2A70", VA = "0x1872A3C70")]
		public static LFGAOKKGEDL DBPBDOCLCGB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x72A3DF0", Offset = "0x72A2BF0", VA = "0x1872A3DF0")]
		public static LFGAOKKGEDL EENHOIIHDAE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x72A4030", Offset = "0x72A2E30", VA = "0x1872A4030")]
		public static LFGAOKKGEDL OMCLHJHHENF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x72A4090", Offset = "0x72A2E90", VA = "0x1872A4090")]
		public static LFGAOKKGEDL PDJAEPFANCB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x72A3BB0", Offset = "0x72A29B0", VA = "0x1872A3BB0")]
		public static LFGAOKKGEDL AEDHKPPGLHG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x72A3E50", Offset = "0x72A2C50", VA = "0x1872A3E50")]
		public static LFGAOKKGEDL ENFNKNNGJNP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x72A3D90", Offset = "0x72A2B90", VA = "0x1872A3D90")]
		public static LFGAOKKGEDL DJGJIODJLKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x72A3F70", Offset = "0x72A2D70", VA = "0x1872A3F70")]
		public static LFGAOKKGEDL NODOOMHMIOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x72A3EB0", Offset = "0x72A2CB0", VA = "0x1872A3EB0")]
		public static LFGAOKKGEDL GMCPPCGCGMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x72A3CD0", Offset = "0x72A2AD0", VA = "0x1872A3CD0")]
		public static LFGAOKKGEDL DHELAJGAHHH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class BCNOCLIAOFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x72A3380", Offset = "0x72A2180", VA = "0x1872A3380")]
		public static LFGAOKKGEDL BDIKEJAHDCI(long CEACGIDOODJ, long DPMNLDKPNGD, bool LLPFGBBCMPI, string DNPKACFMIPM, string PLLHENJHDOK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KBKGODJOEDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x72A78A0", Offset = "0x72A66A0", VA = "0x1872A78A0")]
		public static LFGAOKKGEDL KBONPIHBCAJ(string MNCGNHFDCHH, string JFDHCGHKEHM, bool KLOMKCPPOON)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x72A7A10", Offset = "0x72A6810", VA = "0x1872A7A10")]
		public static LFGAOKKGEDL NPAHKOAPOBP(Guid BAPDPLEOLBE, string JAPGNGDBBIF, string EFDOJKJCFHA, string PMEIDMNEMIC, [Optional] int? BKKBOLGNBFH, [Optional] double[] KFDNIHDAPAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x72A7770", Offset = "0x72A6570", VA = "0x1872A7770")]
		public static LFGAOKKGEDL HPJICMAMOCE(Guid BAPDPLEOLBE, Guid HHKOFELPAJD, bool CHJHDFNODGE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class ELDPCIPAIGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x72A4930", Offset = "0x72A3730", VA = "0x1872A4930")]
		public static LFGAOKKGEDL IGLACPLLIED(string AEFEJDEJJMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x72A46D0", Offset = "0x72A34D0", VA = "0x1872A46D0")]
		public static LFGAOKKGEDL DDGODIKNFEA(string DHKHDCBMOPC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x72A4870", Offset = "0x72A3670", VA = "0x1872A4870")]
		public static LFGAOKKGEDL FFMFPHDGDNG(int OEBMJHLGKIE, string IHGFMOMOADA, string FONJFDCCINO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x72A4810", Offset = "0x72A3610", VA = "0x1872A4810")]
		public static LFGAOKKGEDL DNAEEAAPMFJ(int OEBMJHLGKIE, string IHGFMOMOADA, string FONJFDCCINO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x72A48D0", Offset = "0x72A36D0", VA = "0x1872A48D0")]
		public static LFGAOKKGEDL GOPPLMBDPIK(int OEBMJHLGKIE, string IHGFMOMOADA, string FONJFDCCINO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x72A47B0", Offset = "0x72A35B0", VA = "0x1872A47B0")]
		public static LFGAOKKGEDL DMNDMILHKHC(int OEBMJHLGKIE, string IHGFMOMOADA, string FONJFDCCINO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x72A4A10", Offset = "0x72A3810", VA = "0x1872A4A10")]
		public static LFGAOKKGEDL LJDOEDKOIJA(string IHGFMOMOADA, string FONJFDCCINO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x72A4B60", Offset = "0x72A3960", VA = "0x1872A4B60")]
		private static LFGAOKKGEDL NEDMFAFDCHF(string DKLCKHOLDNA, int OEBMJHLGKIE, string GMNMENDFHPE, string ONNNAIIPBMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x72A4CA0", Offset = "0x72A3AA0", VA = "0x1872A4CA0")]
		private static LFGAOKKGEDL NEDMFAFDCHF(string DKLCKHOLDNA, string GMNMENDFHPE, string ONNNAIIPBMN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly IEBEPMGFCGH NDLHJECGFPL;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ADELEBJGBKL MDIFEFFKFAD;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static KOOJGNHMNBC EEKHGABDJFE;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<LFGAOKKGEDL> KKKFBPEIGKK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long HOILPIHFGOP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x72A36F0", Offset = "0x72A24F0", VA = "0x1872A36F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x72A3A40", Offset = "0x72A2840", VA = "0x1872A3A40")]
	[EKIJCKMDHHI.FMCMFJEHLNM]
	internal static void PCBFJLIEDAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x72A3970", Offset = "0x72A2770", VA = "0x1872A3970")]
	private static void KMOBKKEOCDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x72A3560", Offset = "0x72A2360", VA = "0x1872A3560")]
	public static LFGAOKKGEDL DOKFBCPJHAE(string GFCALFFADOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x72A35E0", Offset = "0x72A23E0", VA = "0x1872A35E0")]
	public static LFGAOKKGEDL DOKFBCPJHAE(string GFCALFFADOM, int OEBMJHLGKIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x72A37E0", Offset = "0x72A25E0", VA = "0x1872A37E0")]
	public static bool GAFPMCOIAFP(this IPJEPIMCHKK NHPBAKKHNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x72A3850", Offset = "0x72A2650", VA = "0x1872A3850")]
	[EKIJCKMDHHI.FMCMFJEHLNM]
	internal static void IOPHMHLJGAB()
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
