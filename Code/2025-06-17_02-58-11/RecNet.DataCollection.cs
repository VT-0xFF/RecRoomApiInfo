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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x7235210", Offset = "0x7233C10", VA = "0x187235210")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA35A80", Offset = "0xA34480", VA = "0x180A35A80")]
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
		[Cpp2IlInjected.Address(RVA = "0xA35AC0", Offset = "0xA344C0", VA = "0x180A35AC0")]
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
	public class LogRegistrationIndex : GIIBELOIOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7232DF0", Offset = "0x72317F0", VA = "0x187232DF0", Slot = "4")]
		public override void EPIAMCEAEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x7236F30", Offset = "0x7235930", VA = "0x187236F30", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2796C60", Offset = "0x2795660", VA = "0x182796C60")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KBJAAONKBCC
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> IKJIIKJOFPN();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EGNDMFHCLHL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x722EB70", Offset = "0x722D570", VA = "0x18722EB70")]
	public static void BIFLAFPFPII(this KFDINHAAMME.FHDFLJDPDCA GEGIBFPNNFB, string AJHCGEAOFOF, string BBKFJOODDPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x722EBE0", Offset = "0x722D5E0", VA = "0x18722EBE0")]
	public static void BIFLAFPFPII(this KFDINHAAMME.FHDFLJDPDCA GEGIBFPNNFB, string AJHCGEAOFOF, bool BBKFJOODDPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x722E710", Offset = "0x722D110", VA = "0x18722E710")]
	public static void BIFLAFPFPII(this KFDINHAAMME.FHDFLJDPDCA GEGIBFPNNFB, string AJHCGEAOFOF, float PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x722E810", Offset = "0x722D210", VA = "0x18722E810")]
	public static void BIFLAFPFPII(this KFDINHAAMME.FHDFLJDPDCA GEGIBFPNNFB, string AJHCGEAOFOF, OINNELMACJI BBKFJOODDPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class KFDINHAAMME
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface JKNJDKFGLBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		FHDFLJDPDCA JJCCMBPBJDL(Guid AFFBGADOFHN, string FJOKIDGICOJ, [Optional] string LPDHEGMKENN, [Optional] long? JFFABGJAPFM, [Optional] string HHDNBKMKDLM, [Optional] string CMGKBDDPBBD);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class HHOMHHJNLIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x722F700", Offset = "0x722E100", VA = "0x18722F700")]
		public static FHDFLJDPDCA NCHGEHMADCN(Guid AFFBGADOFHN, string FJOKIDGICOJ, string LPDHEGMKENN, [Optional] long? JFFABGJAPFM, [Optional] string HHDNBKMKDLM, [Optional] string CMGKBDDPBBD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FHDFLJDPDCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected DEJECLDENJF JEMDJIEKJFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly IDictionary<string, IDictionary<string, object>> CHDNKPNHBAC;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool DEOBHAJABPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x722ECF0", Offset = "0x722D6F0", VA = "0x18722ECF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string EGPABEKMCFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x1153380", Offset = "0x1151D80", VA = "0x181153380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x722F660", Offset = "0x722E060", VA = "0x18722F660")]
		public FHDFLJDPDCA(DEJECLDENJF JEMDJIEKJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x722EC70", Offset = "0x722D670", VA = "0x18722EC70")]
		public FHDFLJDPDCA BCIABGNDJKM(string MLCOAPMDJJE, string PCDAHJCDHHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x722ED90", Offset = "0x722D790", VA = "0x18722ED90")]
		public FHDFLJDPDCA DKGJEHFGJPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4185C50", Offset = "0x4184650", VA = "0x184185C50")]
		public FHDFLJDPDCA BCIABGNDJKM<T>(string MLCOAPMDJJE, T PCDAHJCDHHF) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x722F480", Offset = "0x722DE80", VA = "0x18722F480")]
		public FHDFLJDPDCA KCLLELOHKNH(string MLCOAPMDJJE, object PCDAHJCDHHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4185FF0", Offset = "0x41849F0", VA = "0x184185FF0")]
		public FHDFLJDPDCA GOJDIKFPBPE<T>(string MLCOAPMDJJE, T? PCDAHJCDHHF) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x722EF20", Offset = "0x722D920", VA = "0x18722EF20")]
		public FHDFLJDPDCA GOJDIKFPBPE(string MLCOAPMDJJE, string PCDAHJCDHHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x722ED30", Offset = "0x722D730", VA = "0x18722ED30")]
		public FHDFLJDPDCA BMIMNFJFOAP(string MLCOAPMDJJE, string PCDAHJCDHHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x722F090", Offset = "0x722DA90", VA = "0x18722F090")]
		public FHDFLJDPDCA JFDFAHHPDMJ(string EKGMFHICMFC, string KJNEHANBOBO, object HPGIDELCODH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x722EFB0", Offset = "0x722D9B0", VA = "0x18722EFB0")]
		public FHDFLJDPDCA JFDFAHHPDMJ(string EKGMFHICMFC, IDictionary<string, object> NBOIKFLACJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x722F600", Offset = "0x722E000", VA = "0x18722F600")]
		private static IDictionary<string, object> PCEFLCJJFPL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x722F1D0", Offset = "0x722DBD0", VA = "0x18722F1D0")]
		public void JKNDENLGNNM(bool DKHPDJNBLDH, string EPHPPKDGCNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x722F500", Offset = "0x722DF00", VA = "0x18722F500")]
		public Task PANOHMMCDBA([Optional] CancellationToken JKPNCAGHEDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x28C8E90", Offset = "0x28C7890", VA = "0x1828C8E90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class DEJECLDENJF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct CBECBOGCJAE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public DEJECLDENJF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x722D670", Offset = "0x722C070", VA = "0x18722D670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x722DAF0", Offset = "0x722C4F0", VA = "0x18722DAF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static Action<DEJECLDENJF> OFIDOFHIHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly string NHLGJCILFKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<string, object> IOJDEGJFHEM;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string EGPABEKMCFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x722E3D0", Offset = "0x722CDD0", VA = "0x18722E3D0")]
		private DEJECLDENJF(string NHLGJCILFKP, int LIEFHLCIOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x722E0A0", Offset = "0x722CAA0", VA = "0x18722E0A0")]
		public static FHDFLJDPDCA JEBOFNEMEAN(string NHLGJCILFKP, int LIEFHLCIOCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x722E270", Offset = "0x722CC70", VA = "0x18722E270")]
		[AsyncStateMachine(typeof(CBECBOGCJAE))]
		public Task PANOHMMCDBA([Optional] CancellationToken JKPNCAGHEDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x722E360", Offset = "0x722CD60", VA = "0x18722E360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2FF1D10", Offset = "0x2FF0710", VA = "0x182FF1D10")]
		internal void NPBCFPHFFGC<T>(string MLCOAPMDJJE, T PCDAHJCDHHF) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x722E1B0", Offset = "0x722CBB0", VA = "0x18722E1B0")]
		internal void KDLEDAOEKLD(string MLCOAPMDJJE, object PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x722E210", Offset = "0x722CC10", VA = "0x18722E210")]
		internal void NPBCFPHFFGC(string MLCOAPMDJJE, string PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4185430", Offset = "0x4183E30", VA = "0x184185430")]
		private void AIHJFKBGGJF<T>(string MLCOAPMDJJE, T PCDAHJCDHHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct NFNIBMIGKAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string PGIODJNGAJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly long? LNPPHIAKEOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly short? JLAANHIBFCI;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x72351D0", Offset = "0x7233BD0", VA = "0x1872351D0")]
		public NFNIBMIGKAE(string DJJGMEOHNKM, [Optional] long? FHOIPEIAACP, [Optional] short? CEMMEIJCIHC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct IGMDEHGLKLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly int AAPJKDJIBLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly string BEPJPPMJDIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly short CAIPKAJNCJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly string GMAEGELCHKM;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x722FEF0", Offset = "0x722E8F0", VA = "0x18722FEF0")]
		public IGMDEHGLKLL(int OEFDEBNGHIC, string JMOEELLLCFE, short FEJHFKHEEKH, string HCHECPAHOCG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class KJFCBMEMIFO : ILNDLHFFGLA<DIDABALFFIO, IGMDEHGLKLL, NFNIBMIGKAE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string JMOEELLLCFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private short FEJHFKHEEKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private string HCHECPAHOCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Dictionary<short, int> ABABDIEIKHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int GHOKIEBNIBB;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7231E70", Offset = "0x7230870", VA = "0x187231E70")]
		public KJFCBMEMIFO(string NDNNFECKMEJ, Guid BIFFGKOGGBL, long AIJBEMKBLNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7230A00", Offset = "0x722F400", VA = "0x187230A00", Slot = "4")]
		public override void BFOIJGPENHH(IGMDEHGLKLL IKHHAEDCFBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7231AE0", Offset = "0x72304E0", VA = "0x187231AE0")]
		public void DLOPPMFLKLJ(short FEJHFKHEEKH, bool DMIPLGPHIFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4B233B0", Offset = "0x4B21DB0", VA = "0x184B233B0")]
		public void OLNOEBKKFIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA10500", Offset = "0xA0EF00", VA = "0x180A10500")]
		public void LGMAMKADLBO(string IDNCOPNFGHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7230CF0", Offset = "0x722F6F0", VA = "0x187230CF0", Slot = "5")]
		public override void BLJKHEDANME(bool HDAEEGBHBJH, NFNIBMIGKAE BLICODGJHAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7231BC0", Offset = "0x72305C0", VA = "0x187231BC0", Slot = "6")]
		public override MDECOICANGA NJDPFLJMAGA(DIDABALFFIO BBAMLPPCALM, int MNFHMLCLFEB, string MBPDMFKLIJB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class PIEEINFKKLD : MDECOICANGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private string JMOEELLLCFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly short FEJHFKHEEKH;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7236B50", Offset = "0x7235550", VA = "0x187236B50")]
		public PIEEINFKKLD(long FOLIMMBLOPB, int OEFDEBNGHIC, string LPDHEGMKENN, long AIJBEMKBLNM, int JFJIANOPCLH, string HHDNBKMKDLM, short FEJHFKHEEKH, string JMOEELLLCFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x72369A0", Offset = "0x72353A0", VA = "0x1872369A0")]
		public void CKLPPJDNGLJ(int OEFDEBNGHIC, string JMOEELLLCFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7236A20", Offset = "0x7235420", VA = "0x187236A20", Slot = "5")]
		public override FHDFLJDPDCA JJCCMBPBJDL(Guid AFFBGADOFHN, string FJOKIDGICOJ, [Optional] string LPDHEGMKENN, [Optional] long? JFFABGJAPFM, [Optional] string HHDNBKMKDLM, [Optional] string CMGKBDDPBBD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class PDFAEAEIHLG
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class MPBFAEJMAOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float nextEventSendTime;

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public MPBFAEJMAOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7233630", Offset = "0x7232030", VA = "0x187233630")]
			internal bool EDLLEDLHHIB()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct LLOCBDCJCCK : IAsyncStateMachine
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
			private MPBFAEJMAOG <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TimeSpan <delayPollingInterval>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x72320D0", Offset = "0x7230AD0", VA = "0x1872320D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7232D90", Offset = "0x7231790", VA = "0x187232D90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct HMDOLGKHKJM : IAsyncStateMachine
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

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x722F910", Offset = "0x722E310", VA = "0x18722F910", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x722FE90", Offset = "0x722E890", VA = "0x18722FE90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly float NGFJIIDEKAC;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static JJPMOJNHOLC CCEMKGCMKEF;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static CancellationTokenSource JENDGOIHDMB;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static bool LFDCKDFDFIO;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static int LKJADEIENEN;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly KGOFKGCFJHJ<FHDFLJDPDCA, bool> HNEDMLNEEAP;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static DPLNOICGEPO<FHDFLJDPDCA, bool> KLHHNEJHBHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7235A40", Offset = "0x7234440", VA = "0x187235A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static bool GBKOJOBFHGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7235C00", Offset = "0x7234600", VA = "0x187235C00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7235B50", Offset = "0x7234550", VA = "0x187235B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private static bool DOFMOFGKOAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x72361A0", Offset = "0x7234BA0", VA = "0x1872361A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7235830", Offset = "0x7234230", VA = "0x187235830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private static float OPAKIOFHIPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x72361F0", Offset = "0x7234BF0", VA = "0x1872361F0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7235A90", Offset = "0x7234490", VA = "0x187235A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7235C50", Offset = "0x7234650", VA = "0x187235C50")]
		[HHPMDADMJLL.MBALOIBONAL]
		internal static void KMIAILGDIFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7235650", Offset = "0x7234050", VA = "0x187235650")]
		internal static void DBILOAODCDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7235890", Offset = "0x7234290", VA = "0x187235890")]
		internal static void DLJIAJAKIEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7235AF0", Offset = "0x72344F0", VA = "0x187235AF0")]
		internal static void GMFBFHNHNCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7235BB0", Offset = "0x72345B0", VA = "0x187235BB0")]
		public static void HMDOCBBKKOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7235D70", Offset = "0x7234770", VA = "0x187235D70")]
		private static void LHNGDELNOPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7235290", Offset = "0x7233C90", VA = "0x187235290")]
		private static void ABCFPMPODPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7236240", Offset = "0x7234C40", VA = "0x187236240")]
		[AsyncStateMachine(typeof(LLOCBDCJCCK))]
		private static Task PDBBBECPIFL(CancellationToken JKPNCAGHEDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7236310", Offset = "0x7234D10", VA = "0x187236310")]
		private static void PHDHKFAKOGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7235570", Offset = "0x7233F70", VA = "0x187235570")]
		[AsyncStateMachine(typeof(HMDOLGKHKJM))]
		private static Task CDIJCMNFFJP(bool IAEJFPHFMJF, [Optional] CancellationToken JKPNCAGHEDI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class MKANDNPMBEA<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class IIBEGHFMLPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public MKANDNPMBEA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public IIBEGHFMLPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x4E5E250", Offset = "0x4E5CC50", VA = "0x184E5E250")]
			internal object NOFJLBOHAJH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class LMEHKEKANMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public MKANDNPMBEA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public LMEHKEKANMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x5295670", Offset = "0x5294070", VA = "0x185295670")]
			internal object LGNHKPPEDMA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class LCEMLNEMJHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public MKANDNPMBEA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public LCEMLNEMJHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x5274E00", Offset = "0x5273800", VA = "0x185274E00")]
			internal object EJLIBMMAPDJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class HJPGMDCAPEP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public MKANDNPMBEA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public HJPGMDCAPEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x4D01C10", Offset = "0x4D00610", VA = "0x184D01C10")]
			internal object LLONFFJDCHC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class KKOGHDOKLIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public MKANDNPMBEA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public KKOGHDOKLIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x51CFE20", Offset = "0x51CE820", VA = "0x1851CFE20")]
			internal object DFLFPFJEGHM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class FFGOOIKKAFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public MKANDNPMBEA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public FFGOOIKKAFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x4B3A650", Offset = "0x4B39050", VA = "0x184B3A650")]
			internal object DELLAHLGLHN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class OHMEBKAAMCK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public MKANDNPMBEA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public OHMEBKAAMCK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x565EF00", Offset = "0x565D900", VA = "0x18565EF00")]
			internal object LONGFGDDMCE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const float JFABEDBCGEB = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Guid AFFBGADOFHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly Guid HGGGPMHMEMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly string HHDNBKMKDLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string MGDOHLBFAHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private string PMFBECBNILJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private string CMGKBDDPBBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private string FNAHELANLNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private string EIJMIDAGIGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private string KCDHPGPKEDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private string EGHOOJLLOEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private string DEIAKKMIOPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private string DDNLFAADKOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private string OJEPGHIEFIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Guid? AOPGMDGCLEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private (int, int)? OMHMJKEEOBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly HashSet<T> DOJFGNLILCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Dictionary<(T, int), string> OGBEEKGHKAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Dictionary<(T, int), float> OOJGJGDJKNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Dictionary<T, string> MPGNIPBKMGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly Dictionary<T, string> PPINJFGDNPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<T, string> IBFMCDDCMMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly Dictionary<T, string[]> BGKBBIJCIAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private string EKHAEPADDOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool BMNIDJBIDJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private Task MOCHDMMPIDF;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5492280", Offset = "0x5490C80", VA = "0x185492280")]
		public MKANDNPMBEA(Guid AFFBGADOFHN, Guid HGGGPMHMEMG, string MGDOHLBFAHP, string HHDNBKMKDLM, string PMFBECBNILJ, [Optional] string CMGKBDDPBBD, [Optional] string FNAHELANLNB, [Optional] string EIJMIDAGIGI, [Optional] string DEIAKKMIOPM, [Optional] string EKHAEPADDOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA09180", Offset = "0xA07B80", VA = "0x180A09180")]
		public void ADLEEPPKNLO(string CMGKBDDPBBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7D0", Offset = "0xA091D0", VA = "0x180A0A7D0")]
		public void FGAKDAIFOJL(string PMFBECBNILJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA73C50", Offset = "0xA72650", VA = "0x180A73C50")]
		public void DKHCCAADMPI(string EKHAEPADDOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA10510", Offset = "0xA0EF10", VA = "0x180A10510")]
		public void GOKCBFMDIHJ(string KCDHPGPKEDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA09160", Offset = "0xA07B60", VA = "0x180A09160")]
		public void CMLLJHMACOB(string DDNLFAADKOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA09280", Offset = "0xA07C80", VA = "0x180A09280")]
		public void CKOJCNINEGA(string OJEPGHIEFIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x548E460", Offset = "0x548CE60", VA = "0x18548E460")]
		public void JIBFBJHGDNM(Guid? AFFBGADOFHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x17FE570", Offset = "0x17FCF70", VA = "0x1817FE570")]
		public void HBJMBNBIEMC((int, int)? OMHMJKEEOBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA10500", Offset = "0xA0EF00", VA = "0x180A10500")]
		public void JOPDOBJPEKC(string EGHOOJLLOEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x548C0F0", Offset = "0x548AAF0", VA = "0x18548C0F0")]
		public void DPMBMJLHILM(T JFFABGJAPFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x548BA20", Offset = "0x548A420", VA = "0x18548BA20")]
		public void DIMPFPAPHEA(T JFFABGJAPFM, int NAPENKNBAFB, float IDDLOIFGNLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x548AB20", Offset = "0x5489520", VA = "0x18548AB20")]
		public void AMMJKIMDKDM(T JFFABGJAPFM, int NAPENKNBAFB, string OPAMODOADDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x548E760", Offset = "0x548D160", VA = "0x18548E760")]
		public void MDLAJKOCHOJ(T JFFABGJAPFM, string ILGDOAFDNEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x548EA40", Offset = "0x548D440", VA = "0x18548EA40")]
		public void MJJLEELGKHJ(T JFFABGJAPFM, string EHHKBHOFNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x548F050", Offset = "0x548DA50", VA = "0x18548F050")]
		public void NHFGPCDKLHP(T JFFABGJAPFM, bool HKHGCCANMNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5492110", Offset = "0x5490B10", VA = "0x185492110")]
		public void PJGLJFAADLP(T JFFABGJAPFM, string[] KHOLDPDNEOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x548F1F0", Offset = "0x548DBF0", VA = "0x18548F1F0")]
		public Task PANOHMMCDBA(bool BOOINJJDCOC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x548C3A0", Offset = "0x548ADA0", VA = "0x18548C3A0")]
		private (IEnumerable<T>, string) ELFBNOLJHPD()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x548DB40", Offset = "0x548C540", VA = "0x18548DB40")]
		public static FHDFLJDPDCA JFLNMCMMOAC(Guid AFFBGADOFHN, Guid HGGGPMHMEMG, string MGDOHLBFAHP, T JFFABGJAPFM, string HHDNBKMKDLM, string IJGGHMFNLFA, string CMGKBDDPBBD, int? MNFHMLCLFEB, [Optional] string NMDLLJCJAKD, [Optional] string ILGDOAFDNEL, [Optional] int? HBHHCAJEANI, [Optional] Guid? AOPGMDGCLEG, [Optional] string EKHAEPADDOE, [Optional] string LPDHEGMKENN, [Optional] (int, int)? OMHMJKEEOBH, [Optional] string HOGPGHLMCDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x548B2F0", Offset = "0x5489CF0", VA = "0x18548B2F0")]
		[CompilerGenerated]
		private string BDAEJACHEAP(T KHNIMGKFPOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x548D5B0", Offset = "0x548BFB0", VA = "0x18548D5B0")]
		[CompilerGenerated]
		private string FJBLFAJJPOA(T KHNIMGKFPOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x548B4F0", Offset = "0x5489EF0", VA = "0x18548B4F0")]
		[CompilerGenerated]
		private string BKGKMEHEHOM(T KHNIMGKFPOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x548B6B0", Offset = "0x548A0B0", VA = "0x18548B6B0")]
		[CompilerGenerated]
		private string CLPPKFBCJHA(T KHNIMGKFPOO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public abstract class ILNDLHFFGLA<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		protected readonly string NDNNFECKMEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		protected readonly Guid BIFFGKOGGBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		protected readonly long AIJBEMKBLNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		protected int OEFDEBNGHIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		protected int MPICBDCFPPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		protected DateTime KNLLCJNENHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		protected bool IAJOGCLGPMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		protected Dictionary<long, MDECOICANGA> LHPNPNDNDIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		protected bool KMIBBHJHPCI;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool GPPPGPEDKMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xCA7120", Offset = "0xCA5B20", VA = "0x180CA7120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool PGOFHHKBGEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xCF5530", Offset = "0xCF3F30", VA = "0x180CF5530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4E6EDB0", Offset = "0x4E6D7B0", VA = "0x184E6EDB0")]
		public ILNDLHFFGLA(string NDNNFECKMEJ, Guid BIFFGKOGGBL, long AIJBEMKBLNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void BFOIJGPENHH(TListSessionStartParams IKHHAEDCFBA);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4E6EDA0", Offset = "0x4E6D7A0", VA = "0x184E6EDA0")]
		public void JGKEBAOFHJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void BLJKHEDANME(bool HDAEEGBHBJH, TListSessionLogParams BLICODGJHAB);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4E6ED50", Offset = "0x4E6D750", VA = "0x184E6ED50")]
		public void HIOHEHBIKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4E6EB60", Offset = "0x4E6D560", VA = "0x184E6EB60")]
		public void DNLJOKOEFMO(long FOLIMMBLOPB, int MNFHMLCLFEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x4E6EA40", Offset = "0x4E6D440", VA = "0x184E6EA40")]
		public void BHKHKPGBDLC(long FOLIMMBLOPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract MDECOICANGA NJDPFLJMAGA(TItem HMJJODPHKCG, int MNFHMLCLFEB, string MBPDMFKLIJB);
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class MDECOICANGA : JKNJDKFGLBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private int OEFDEBNGHIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private long FOLIMMBLOPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private long AIJBEMKBLNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly string KNKGPBIGJAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly string FJKHOLDDECP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly int JFJIANOPCLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private DateTime KDCPJMPAEFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private double HOHKPMNDHEC;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PJHMHOLBDNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xED7A00", Offset = "0xED6400", VA = "0x180ED7A00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xED76A0", Offset = "0xED60A0", VA = "0x180ED76A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7233560", Offset = "0x7231F60", VA = "0x187233560")]
		public MDECOICANGA(long FOLIMMBLOPB, int OEFDEBNGHIC, string LPDHEGMKENN, long AIJBEMKBLNM, int JFJIANOPCLH, [Optional] string HHDNBKMKDLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7232EE0", Offset = "0x72318E0", VA = "0x187232EE0")]
		public void JBPNJGALHJL(int OEFDEBNGHIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7233510", Offset = "0x7231F10", VA = "0x187233510")]
		public void PJFHHJCBDMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7233400", Offset = "0x7231E00", VA = "0x187233400")]
		public void NELLLEINJFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7232E80", Offset = "0x7231880", VA = "0x187232E80")]
		private void CJEGFNBLMOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7232F50", Offset = "0x7231950", VA = "0x187232F50", Slot = "5")]
		public virtual FHDFLJDPDCA JJCCMBPBJDL(Guid AFFBGADOFHN, string FJOKIDGICOJ, [Optional] string LPDHEGMKENN, [Optional] long? JFFABGJAPFM, [Optional] string HHDNBKMKDLM, [Optional] string CMGKBDDPBBD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class NEHCCMCDIBL
	{
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static Dictionary<string, Dictionary<string, object>> PPJLBJNMJCI;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static string HGFMPBLGDFP;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static int AFANDNNNCIK;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly Dictionary<string, KBJAAONKBCC> IKFFKIKBGGH;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static string PEFBPGAALKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x7234680", Offset = "0x7233080", VA = "0x187234680")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x7233F90", Offset = "0x7232990", VA = "0x187233F90")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool AJNJDBMBNPH
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7233E50", Offset = "0x7232850", VA = "0x187233E50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static Dictionary<string, Dictionary<string, object>> OBGBAIGIKAA
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7233F40", Offset = "0x7232940", VA = "0x187233F40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static Guid? ICHOJELIFBL
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7233EE0", Offset = "0x72328E0", VA = "0x187233EE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x7234DC0", Offset = "0x72337C0", VA = "0x187234DC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static Guid? CHMFKINHHIL
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x7235030", Offset = "0x7233A30", VA = "0x187235030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7234840", Offset = "0x7233240", VA = "0x187234840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x72347B0", Offset = "0x72331B0", VA = "0x1872347B0")]
		public static void FKNGJFPIKKI(string BKPJPBDDGJA, KBJAAONKBCC FDHFAHHFPJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7234040", Offset = "0x7232A40", VA = "0x187234040")]
		internal static void DBILOAODCDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x72346D0", Offset = "0x72330D0", VA = "0x1872346D0")]
		internal static void DLJIAJAKIEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x72348A0", Offset = "0x72332A0", VA = "0x1872348A0")]
		internal static void GMFBFHNHNCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7233880", Offset = "0x7232280", VA = "0x187233880")]
		public static Guid BFOIJGPENHH(string BKPJPBDDGJA, [Optional] string? IBGCIOLOFOC, [Optional] Dictionary<string, object>? FCMKIGLLBDG)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x72337E0", Offset = "0x72321E0", VA = "0x1872337E0")]
		public static Guid BFOIJGPENHH(string BKPJPBDDGJA, long IBGCIOLOFOC, [Optional] Dictionary<string, object>? FCMKIGLLBDG)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7234970", Offset = "0x7233370", VA = "0x187234970")]
		public static void JGKEBAOFHJB(string BKPJPBDDGJA, [Optional] Guid? FNKCCICOAII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7234E20", Offset = "0x7233820", VA = "0x187234E20")]
		public static void NLLJJIANBEB(string BKPJPBDDGJA, string EKGMFHICMFC, object HGINNAIDIDA, bool LFDCKDFDFIO = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7234BD0", Offset = "0x72335D0", VA = "0x187234BD0")]
		public static bool LONCCGAGMCJ(string BKPJPBDDGJA, [Optional] string? IBGCIOLOFOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7234120", Offset = "0x7232B20", VA = "0x187234120")]
		private static void DBMAFPBGBFN(bool OLKLIIGNEPK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7234920", Offset = "0x7233320", VA = "0x187234920")]
		public static void IKAFMCLAMKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x72336D0", Offset = "0x72320D0", VA = "0x1872336D0")]
		private static void ABCFPMPODPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7234290", Offset = "0x7232C90", VA = "0x187234290")]
		private static void DEDNBMICGGH(string BKPJPBDDGJA, Guid AFFBGADOFHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class PHJMNMOJLKB
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public struct PMIIMLKOKGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public bool CACGHLMLDCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public string DJGLMHAPDBP;

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xCA8C90", Offset = "0xCA7690", VA = "0x180CA8C90")]
			public PMIIMLKOKGO(bool CACGHLMLDCI, string DJGLMHAPDBP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7236690", Offset = "0x7235090", VA = "0x187236690")]
		public static PMIIMLKOKGO NLLEOCMFOCP(FHDFLJDPDCA GEGIBFPNNFB)
		{
			return default(PMIIMLKOKGO);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x72364D0", Offset = "0x7234ED0", VA = "0x1872364D0")]
		private static void CHHDBNPJGFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x72365D0", Offset = "0x7234FD0", VA = "0x1872365D0")]
		private static void MOFGOPKHNCF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class BPJEFPGCHBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x722D610", Offset = "0x722C010", VA = "0x18722D610")]
		public static FHDFLJDPDCA MFDOEIGOOHF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class IICNFAMOFJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7230060", Offset = "0x722EA60", VA = "0x187230060")]
		public static FHDFLJDPDCA DNPDOPCMINB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7230240", Offset = "0x722EC40", VA = "0x187230240")]
		public static FHDFLJDPDCA KPMMLBIGFPH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x722FFA0", Offset = "0x722E9A0", VA = "0x18722FFA0")]
		public static FHDFLJDPDCA DDNOIMBLGNJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x72300C0", Offset = "0x722EAC0", VA = "0x1872300C0")]
		public static FHDFLJDPDCA GCBIAFJICIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x72302A0", Offset = "0x722ECA0", VA = "0x1872302A0")]
		public static FHDFLJDPDCA LGHKECOEALP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x72303C0", Offset = "0x722EDC0", VA = "0x1872303C0")]
		public static FHDFLJDPDCA MNFJFNDBNAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7230480", Offset = "0x722EE80", VA = "0x187230480")]
		public static FHDFLJDPDCA ONLPNCMEINN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7230180", Offset = "0x722EB80", VA = "0x187230180")]
		public static FHDFLJDPDCA KGIBOBPMFHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7230360", Offset = "0x722ED60", VA = "0x187230360")]
		public static FHDFLJDPDCA MMBJPLLNHFL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x72301E0", Offset = "0x722EBE0", VA = "0x1872301E0")]
		public static FHDFLJDPDCA KOBAEKODAOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7230000", Offset = "0x722EA00", VA = "0x187230000")]
		public static FHDFLJDPDCA DLEBLBDJICJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x722FF40", Offset = "0x722E940", VA = "0x18722FF40")]
		public static FHDFLJDPDCA CGBNFIOAPDF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7230120", Offset = "0x722EB20", VA = "0x187230120")]
		public static FHDFLJDPDCA HGHOJEOOKOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7230420", Offset = "0x722EE20", VA = "0x187230420")]
		public static FHDFLJDPDCA OLNBJEFBMJJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7230300", Offset = "0x722ED00", VA = "0x187230300")]
		public static FHDFLJDPDCA LGLLMKMGIJN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class KKHMHLMJGFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7231EF0", Offset = "0x72308F0", VA = "0x187231EF0")]
		public static FHDFLJDPDCA JMGFLKPIDEF(long FHOIPEIAACP, long HDLFBPMKPAB, bool DMLELMHNGCP, string IFBEAICDELD, string NFHJHCCNEPP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class CEPBFPJAIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x722DB50", Offset = "0x722C550", VA = "0x18722DB50")]
		public static FHDFLJDPDCA DKFLJFGLFMK(string LMIFBFBEBFC, string OKACACHEEPO, bool FHCFDDLGGMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x722DDF0", Offset = "0x722C7F0", VA = "0x18722DDF0")]
		public static FHDFLJDPDCA FHEPKNFFBGL(Guid HGGGPMHMEMG, string GJIMIGJJJKI, string CONNOCAAAFH, string NIPONGFDCDI, [Optional] int? FOLFOKPHJFH, [Optional] double[] OBOAIDHEKIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x722DCC0", Offset = "0x722C6C0", VA = "0x18722DCC0")]
		public static FHDFLJDPDCA EBJDCKKMAGI(Guid HGGGPMHMEMG, Guid CCBJEGOAHFF, bool FLEONLDNKFL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class AMHFOLAIBNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x722D060", Offset = "0x722BA60", VA = "0x18722D060")]
		public static FHDFLJDPDCA BCOKKINCHCL(string DBGHIJBFIBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x722D410", Offset = "0x722BE10", VA = "0x18722D410")]
		public static FHDFLJDPDCA JJMOOFHPGLD(string IBBFHCFFPCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x722D4F0", Offset = "0x722BEF0", VA = "0x18722D4F0")]
		public static FHDFLJDPDCA KAHGCKILBDA(int LIEFHLCIOCG, string GBCFHNGPBLM, string KHNIMGKFPOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x722D5B0", Offset = "0x722BFB0", VA = "0x18722D5B0")]
		public static FHDFLJDPDCA PIEFJMIOCJE(int LIEFHLCIOCG, string GBCFHNGPBLM, string KHNIMGKFPOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x722D550", Offset = "0x722BF50", VA = "0x18722D550")]
		public static FHDFLJDPDCA NMAPDOJFPJM(int LIEFHLCIOCG, string GBCFHNGPBLM, string KHNIMGKFPOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x722D3B0", Offset = "0x722BDB0", VA = "0x18722D3B0")]
		public static FHDFLJDPDCA DCKFIGMEMJL(int LIEFHLCIOCG, string GBCFHNGPBLM, string KHNIMGKFPOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x722CF10", Offset = "0x722B910", VA = "0x18722CF10")]
		public static FHDFLJDPDCA BBMNBDOOGOG(string GBCFHNGPBLM, string KHNIMGKFPOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x722D270", Offset = "0x722BC70", VA = "0x18722D270")]
		private static FHDFLJDPDCA CMPLNGLINKK(string NDNNFECKMEJ, int LIEFHLCIOCG, string IKCBICLPHFF, string HHGKGNEJKOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x722D140", Offset = "0x722BB40", VA = "0x18722D140")]
		private static FHDFLJDPDCA CMPLNGLINKK(string NDNNFECKMEJ, string IKCBICLPHFF, string HHGKGNEJKOM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly COJJKFBGGKB NLLEOCMFOCP;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static IECMHFBIMFA FADPPBNPFNA;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static CKMOJMBJJND KFHADNFCNHK;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<FHDFLJDPDCA> IJFPJIAAEMD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long JFMDNGJCMFK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7230620", Offset = "0x722F020", VA = "0x187230620")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7230710", Offset = "0x722F110", VA = "0x187230710")]
	[HHPMDADMJLL.MBALOIBONAL]
	internal static void MCCNGCNNCFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x72304E0", Offset = "0x722EEE0", VA = "0x1872304E0")]
	private static void DIHOKKOMGNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x72305A0", Offset = "0x722EFA0", VA = "0x1872305A0")]
	public static FHDFLJDPDCA GIIKFFNEAIC(string NHLGJCILFKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x722E0A0", Offset = "0x722CAA0", VA = "0x18722E0A0")]
	public static FHDFLJDPDCA GIIKFFNEAIC(string NHLGJCILFKP, int LIEFHLCIOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7230800", Offset = "0x722F200", VA = "0x187230800")]
	public static bool NBDFPNKMENB(this JJPMOJNHOLC DCOMIILDBPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7230870", Offset = "0x722F270", VA = "0x187230870")]
	[HHPMDADMJLL.MBALOIBONAL]
	internal static void PDPGONHAIDJ()
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
