using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ObjectModel_Dependencies_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : IHAELNMODEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7E36130", Offset = "0x7E35330", VA = "0x187E36130", Slot = "4")]
		public override void OOCHIMKFMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ObjectModel_Dependencies_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset bitset1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Type[] bindTypeSet3;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7BCB7C0", Offset = "0x7BCA9C0", VA = "0x187BCB7C0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7E36F10", Offset = "0x7E36110", VA = "0x187E36F10")]
		private void NDIKJDPGAHM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7E36BF0", Offset = "0x7E35DF0", VA = "0x187E36BF0")]
		private void BKLJKGOJGMF(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7E372E0", Offset = "0x7E364E0", VA = "0x187E372E0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7E37390", Offset = "0x7E36590", VA = "0x187E37390")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(LPLCOIFICKC), new string[] { "Photon" })]
public class GDBKBJBKMEC : LPLCOIFICKC
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private class FLFKLAHJPGN : GCJJOOFPNCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public KOEIHCIJPPL ELJMGFIBFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public StatusCode ONCDFODJFBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public HACFMHLJKIO LPDOECFMFPI;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public MGLHALCMAGB AFGCMPJBOON
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7E33260", Offset = "0x7E32460", VA = "0x187E33260", Slot = "4")]
			get
			{
				return default(MGLHALCMAGB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public MMNMPKDPAGK APNPGHGIJOF
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7E33700", Offset = "0x7E32900", VA = "0x187E33700", Slot = "5")]
			get
			{
				return default(MMNMPKDPAGK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool KOJAGNDKKAN
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7E332B0", Offset = "0x7E324B0", VA = "0x187E332B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool EOPLPEALPCO
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7E33750", Offset = "0x7E32950", VA = "0x187E33750", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7E335C0", Offset = "0x7E327C0", VA = "0x187E335C0", Slot = "8")]
		public object MGBIBOOCPJO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7E333F0", Offset = "0x7E325F0", VA = "0x187E333F0", Slot = "9")]
		private (MMNMPKDPAGK, Dictionary<object, object>) KDBKFEMDDDK()
		{
			return default((MMNMPKDPAGK, Dictionary<object, object>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7E33610", Offset = "0x7E32810", VA = "0x187E33610", Slot = "10")]
		private (KOAGADGMKNF, MMNMPKDPAGK) MNMLDMPBIJP()
		{
			return default((KOAGADGMKNF, MMNMPKDPAGK));
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7E332C0", Offset = "0x7E324C0", VA = "0x187E332C0", Slot = "11")]
		private IDLBAPNLABP<(KOAGADGMKNF, MMNMPKDPAGK)> JLILKIAJFLC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7E33050", Offset = "0x7E32250", VA = "0x187E33050", Slot = "12")]
		private (NLELEHKBKFK, byte[]) AMMBKMCGGAA()
		{
			return default((NLELEHKBKFK, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7E32E20", Offset = "0x7E32020", VA = "0x187E32E20", Slot = "13")]
		private (MNHOIBJNOFD, byte[]) AFBGBBKAFPN()
		{
			return default((MNHOIBJNOFD, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3F99C60", Offset = "0x3F98E60", VA = "0x183F99C60", Slot = "14")]
		public T PMCPABMNFGK<T>()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7E33910", Offset = "0x7E32B10", VA = "0x187E33910", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public FLFKLAHJPGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DefaultMember("Item")]
	private class HACFMHLJKIO : IDLBAPNLABP<(KOAGADGMKNF, MMNMPKDPAGK)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int[] IELBEELNODB;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int LNJBLGDGPME
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7E343D0", Offset = "0x7E335D0", VA = "0x187E343D0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public (KOAGADGMKNF view, MMNMPKDPAGK newOwner) JCGKBEGFBHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7E34330", Offset = "0x7E33530", VA = "0x187E34330", Slot = "4")]
			get
			{
				return default((KOAGADGMKNF, MMNMPKDPAGK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public HACFMHLJKIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7E341B0", Offset = "0x7E333B0", VA = "0x187E341B0", Slot = "4")]
	public bool ONGMIMEBEHB(object DHAOEHNLNON, GCJJOOFPNCM CJAIDCAJGHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public GDBKBJBKMEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class OKNMKJANFHK
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AlsoBindServiceAs(typeof(DJKCIADAOAD))]
[RegisterService(typeof(OCMHDHDOLBF), new string[] { "Photon" })]
public class DJKCIADAOAD : IELLFNEFJEB, ENCIJMIGADI, OCMHDHDOLBF, BJIBPMDIMDH, GKBPCKLNOCI
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[DependsOn]
	private MILDICDGLJH GBEOAHCNHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[DependsOn]
	private BALMBNJMKBF HAPMAMBFAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Hashtable PPDPHFAEOEG;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7E32140", Offset = "0x7E31340", VA = "0x187E32140", Slot = "4")]
	public void InitReferences(PJPDGGELCKG JIHODFEAJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7E325B0", Offset = "0x7E317B0", VA = "0x187E325B0", Slot = "5")]
	public void MPMPHOFLBEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7E32660", Offset = "0x7E31860", VA = "0x187E32660", Slot = "6")]
	public void NKHHLKHCCDB(MNHOIBJNOFD AGBHGDFILGO, ReadOnlySpan<byte> MGEJNDCFBJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7E32230", Offset = "0x7E31430", VA = "0x187E32230", Slot = "10")]
	public void JKDAACHMBBM(MNHOIBJNOFD LDHCIEFNLHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7E32840", Offset = "0x7E31A40", VA = "0x187E32840", Slot = "7")]
	public void ONKNOGMEPMP(ReadOnlySpan<MNHOIBJNOFD> BFODAAHBHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7E32350", Offset = "0x7E31550", VA = "0x187E32350")]
	private Hashtable MEODJOBLMEJ(Hashtable ALAKBIBIMDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7E320E0", Offset = "0x7E312E0", VA = "0x187E320E0")]
	public void CDHBHDDMNPE(object IMPAKIFFNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7E327D0", Offset = "0x7E319D0", VA = "0x187E327D0", Slot = "8")]
	private void NPKMOIIMNFA(PJPDGGELCKG JIHODFEAJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1170FB0", Offset = "0x11701B0", VA = "0x181170FB0", Slot = "9")]
	private void JNNNBCINACM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7E32A50", Offset = "0x7E31C50", VA = "0x187E32A50")]
	public DJKCIADAOAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[RegisterService(typeof(global::PLNIIBIADBL), new string[] { })]
internal class EILDMOOFLOF : DEAJEEKOMCA, global::PLNIIBIADBL
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly FODGIOKBGBI CPALCMBPKAE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	protected override FODGIOKBGBI[] LFGAPHFCJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7E32D70", Offset = "0x7E31F70", VA = "0x187E32D70")]
	public EILDMOOFLOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DPCOHOLPNHG : DefaultContractResolver
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7E32AD0", Offset = "0x7E31CD0", VA = "0x187E32AD0", Slot = "19")]
	protected override IList<JsonProperty> CreateProperties(Type EDLOHJEBKFM, MemberSerialization MKMLDOPKMBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7E32CD0", Offset = "0x7E31ED0", VA = "0x187E32CD0")]
	public DPCOHOLPNHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class AAGABKKNHPE
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class MLMLGKOJJIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public JsonSerializerSettings serializationSettings;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public MLMLGKOJJIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7E36240", Offset = "0x7E35440", VA = "0x187E36240")]
		internal string JLPPPFFEOHG(KOEIHCIJPPL eventData)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7E31CD0", Offset = "0x7E30ED0", VA = "0x187E31CD0")]
	public static string KCFJPFIOCOG(this KOEIHCIJPPL ELJMGFIBFCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7E31A70", Offset = "0x7E30C70", VA = "0x187E31A70")]
	public static MGLHALCMAGB CIDHCBKAPAC(this KOEIHCIJPPL ELJMGFIBFCP)
	{
		return default(MGLHALCMAGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7E31F30", Offset = "0x7E31130", VA = "0x187E31F30")]
	public static ViewId OMGKLKOEJPB(this KOEIHCIJPPL ELJMGFIBFCP)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7E31CF0", Offset = "0x7E30EF0", VA = "0x187E31CF0")]
	public static string LDPOCPHDBAA(this KOEIHCIJPPL ELJMGFIBFCP, JsonSerializerSettings MKIMLDCBNAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7E31850", Offset = "0x7E30A50", VA = "0x187E31850")]
	private static string AHAJGIFMJNA(KOEIHCIJPPL ELJMGFIBFCP, Func<KOEIHCIJPPL, string> HDKINMMJOHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7E31DC0", Offset = "0x7E30FC0", VA = "0x187E31DC0")]
	public static string LFNAAMGKHGO(this KOEIHCIJPPL ELJMGFIBFCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7E31940", Offset = "0x7E30B40", VA = "0x187E31940")]
	public static ViewId BFAPPOIPMIK(this KOEIHCIJPPL ELJMGFIBFCP)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7E31BB0", Offset = "0x7E30DB0", VA = "0x187E31BB0")]
	public static string FPOMEMKCILF(this KOEIHCIJPPL ELJMGFIBFCP, JsonSerializerSettings MKIMLDCBNAB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class OICKHAICHCC
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class CLPFECJILNL
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static string JONEBDHCFML;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7E36380", Offset = "0x7E35580", VA = "0x187E36380")]
	public static string MACCBAIAKPK(MGLHALCMAGB PIOPNFOBDGK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[RegisterService(typeof(GBBLDBPDNBM), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
internal class GBBLDBPDNBM : DEAJEEKOMCA
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly FODGIOKBGBI DJDHGBBFNPL;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly FODGIOKBGBI LEHCGBOKINI;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly FODGIOKBGBI PHHDJEOEAPK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected override FODGIOKBGBI[] LFGAPHFCJOL
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7E33A00", Offset = "0x7E32C00", VA = "0x187E33A00", Slot = "9")]
	public override void BPGFCOKPKBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7E33DF0", Offset = "0x7E32FF0", VA = "0x187E33DF0", Slot = "10")]
	public override void LDFMGEFGAAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7E33F70", Offset = "0x7E33170", VA = "0x187E33F70")]
	private void LFCAHDOCEIE(KOEIHCIJPPL ELJMGFIBFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7E33DC0", Offset = "0x7E32FC0", VA = "0x187E33DC0")]
	private void IEDLKKOIAGH(KOEIHCIJPPL ELJMGFIBFCP, BKJLKPIDHCH OGDFOLOIAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7E33B80", Offset = "0x7E32D80", VA = "0x187E33B80")]
	public void CLMKJDFNBCP(KOEIHCIJPPL ELJMGFIBFCP, NKGMIBAHLKM JDPNGNEHJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7E33F80", Offset = "0x7E33180", VA = "0x187E33F80")]
	private static FODGIOKBGBI NALAINNBAGB(byte DEBMEFDDEDD)
	{
		return default(FODGIOKBGBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7E340D0", Offset = "0x7E332D0", VA = "0x187E340D0")]
	public GBBLDBPDNBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class JBIIOLAANBA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct JFGJOMIEGCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public byte[] payload;
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly JsonSerializerSettings IEGDKIOEJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7E345D0", Offset = "0x7E337D0", VA = "0x187E345D0")]
	public static HGAFIGENIDF FNLDJPHEDDC([In] this HGAFIGENIDF ALOIKGNLFKN, KOEIHCIJPPL ELJMGFIBFCP, NKGMIBAHLKM JDPNGNEHJDD)
	{
		return default(HGAFIGENIDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7E35C20", Offset = "0x7E34E20", VA = "0x187E35C20")]
	public static HGAFIGENIDF MJMHFJAAMEC([In] this HGAFIGENIDF ALOIKGNLFKN, KOEIHCIJPPL ELJMGFIBFCP)
	{
		return default(HGAFIGENIDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7E343F0", Offset = "0x7E335F0", VA = "0x187E343F0")]
	public static string FBJCHMKFPLM(KOEIHCIJPPL ELJMGFIBFCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7E359C0", Offset = "0x7E34BC0", VA = "0x187E359C0")]
	public static string IMGNNNGJDJL(KOEIHCIJPPL ELJMGFIBFCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7E356C0", Offset = "0x7E348C0", VA = "0x187E356C0")]
	public static string GPAPOLNKNAD(KOEIHCIJPPL ELJMGFIBFCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7E35630", Offset = "0x7E34830", VA = "0x187E35630")]
	[CompilerGenerated]
	internal static bool GEOACGGFILD([Out] string IGGKBIDIAJL, JFGJOMIEGCD P_1)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7E35850", Offset = "0x7E34A50", VA = "0x187E35850")]
	[CompilerGenerated]
	internal static bool IJHKDDLCFEI([Out] string IGGKBIDIAJL, JFGJOMIEGCD P_1)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HKJKGJGAGLN
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public HKJKGJGAGLN()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
