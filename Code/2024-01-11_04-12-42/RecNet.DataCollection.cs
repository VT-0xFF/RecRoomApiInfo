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
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5751C40", Offset = "0x5750640", VA = "0x185751C40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BA560", Offset = "0x7B8F60", VA = "0x1807BA560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BA5A0", Offset = "0x7B8FA0", VA = "0x1807BA5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface AJIANANAMBL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> ANKNJNNBPFO();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class PDJMBBAGANJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface OEKMANDJMBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		AJOAFJONIAF KGEFGCHLENA(Guid CGALJLIIABC, string HEEJLIPGKCO, [Optional] string AHMEMLPJJAB, [Optional] long? CCICBAOJPBB, [Optional] string MEGLIPCBHOK, [Optional] string GNCPHJFKBEN);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class FLABOAHDAHG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x574E820", Offset = "0x574D220", VA = "0x18574E820")]
		public static AJOAFJONIAF EKPOLCDDEMK(Guid CGALJLIIABC, string HEEJLIPGKCO, string AHMEMLPJJAB, [Optional] long? CCICBAOJPBB, [Optional] string MEGLIPCBHOK, [Optional] string GNCPHJFKBEN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class AJOAFJONIAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected CNFMMMMHDKA KMDMCPBDECK;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7904D0", Offset = "0x78EED0", VA = "0x1807904D0")]
		public AJOAFJONIAF(CNFMMMMHDKA KMDMCPBDECK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x574D470", Offset = "0x574BE70", VA = "0x18574D470")]
		public AJOAFJONIAF BCKNEAHEIEP(string NPDAMELJOLL, string BEEGCHJLJFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2BEFE10", Offset = "0x2BEE810", VA = "0x182BEFE10")]
		public AJOAFJONIAF BCKNEAHEIEP<T>(string NPDAMELJOLL, T BEEGCHJLJFC) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2BEFD10", Offset = "0x2BEE710", VA = "0x182BEFD10")]
		public AJOAFJONIAF ADHIPCOMOFK<T>(string NPDAMELJOLL, T? BEEGCHJLJFC) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x574D3E0", Offset = "0x574BDE0", VA = "0x18574D3E0")]
		public AJOAFJONIAF ADHIPCOMOFK(string NPDAMELJOLL, string BEEGCHJLJFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x574D4F0", Offset = "0x574BEF0", VA = "0x18574D4F0")]
		public GOACJHIODHI JHFNKBOAPKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1D0B710", Offset = "0x1D0A110", VA = "0x181D0B710", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class CNFMMMMHDKA
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static Action<CNFMMMMHDKA> JINPCNFJLOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly string NKPOFBALEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<string, object> CEAOENGMFGJ;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x574DC50", Offset = "0x574C650", VA = "0x18574DC50")]
		private CNFMMMMHDKA(string NKPOFBALEFL, int JHCPMDFIMFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x574D8B0", Offset = "0x574C2B0", VA = "0x18574D8B0")]
		public static AJOAFJONIAF CMMJGECCMDN(string NKPOFBALEFL, int JHCPMDFIMFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x574D960", Offset = "0x574C360", VA = "0x18574D960")]
		public GOACJHIODHI JHFNKBOAPKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x574DBE0", Offset = "0x574C5E0", VA = "0x18574DBE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x23AC730", Offset = "0x23AB130", VA = "0x1823AC730")]
		internal void NDOMHJFFAJE<T>(string NPDAMELJOLL, T BEEGCHJLJFC) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x574DB80", Offset = "0x574C580", VA = "0x18574DB80")]
		internal void NDOMHJFFAJE(string NPDAMELJOLL, string BEEGCHJLJFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2BF0780", Offset = "0x2BEF180", VA = "0x182BF0780")]
		private void JFOFBIMLPOB<T>(string NPDAMELJOLL, T BEEGCHJLJFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct LDEEPBCJMLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly string MLHCNFBIHGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly long? IFMPGLDOIFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly short? BNJJFLIJKNI;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5750890", Offset = "0x574F290", VA = "0x185750890")]
		public LDEEPBCJMLO(string JGINFGINFDH, [Optional] long? FKNNHALPBIJ, [Optional] short? LJAOKFGNBIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct GJKLPAEPLAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly int KPLAGJCLFCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly string OFCMILOHONB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly short KEGPGCFIFCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string ADIDMEJNKHL;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x574FC50", Offset = "0x574E650", VA = "0x18574FC50")]
		public GJKLPAEPLAD(int KCEPNJAPLPE, string OGEJNLKMDGK, short NEKENJKALGM, string LBKEACDBGDF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class OEAEICGNLAN : GGMDOLLFFIE<JJLJBPLFLJM, GJKLPAEPLAD, LDEEPBCJMLO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private string OGEJNLKMDGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private short NEKENJKALGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private string LBKEACDBGDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private Dictionary<short, int> DOPMNPKIPCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int CIJCBCEFGFB;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5753140", Offset = "0x5751B40", VA = "0x185753140")]
		public OEAEICGNLAN(string HHDAKFCMDBN, Guid LEPLIGHAENK, long CECOAMKIDGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5751F80", Offset = "0x5750980", VA = "0x185751F80", Slot = "4")]
		public override void KPIPFHGLGCM(GJKLPAEPLAD HOFGCONGCBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5752270", Offset = "0x5750C70", VA = "0x185752270")]
		public void NOEFMPIAOIF(short NEKENJKALGM, bool HDFGGNAICIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x359C210", Offset = "0x359AC10", VA = "0x18359C210")]
		public void JBEBMIEDIJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x78FCE0", Offset = "0x78E6E0", VA = "0x18078FCE0")]
		public void LNIPBBHEFAG(string BLCDBMGJMLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5752350", Offset = "0x5750D50", VA = "0x185752350", Slot = "5")]
		public override void PIPOHGFJGMD(bool FNDJLJBLBJC, LDEEPBCJMLO JGGJLMAKFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5751CC0", Offset = "0x57506C0", VA = "0x185751CC0", Slot = "6")]
		public override MDLLGGMFLEF IIFJFHFNMBK(JJLJBPLFLJM DLBFECEIPAD, int BNALCEABILL, string DKFFFJFJNNK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class LCGCAENEFIM : MDLLGGMFLEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private string OGEJNLKMDGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly short NEKENJKALGM;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x57507A0", Offset = "0x574F1A0", VA = "0x1857507A0")]
		public LCGCAENEFIM(long ICJIFJJJIEE, int KCEPNJAPLPE, string AHMEMLPJJAB, long CECOAMKIDGD, int JNBFNLMKLLA, string MEGLIPCBHOK, short NEKENJKALGM, string OGEJNLKMDGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5750710", Offset = "0x574F110", VA = "0x185750710")]
		public void OEHFBCPDDJC(int KCEPNJAPLPE, string OGEJNLKMDGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x57505E0", Offset = "0x574EFE0", VA = "0x1857505E0", Slot = "5")]
		public override AJOAFJONIAF KGEFGCHLENA(Guid CGALJLIIABC, string HEEJLIPGKCO, [Optional] string AHMEMLPJJAB, [Optional] long? CCICBAOJPBB, [Optional] string MEGLIPCBHOK, [Optional] string GNCPHJFKBEN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class LINFJAADBHG
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public readonly struct FBNHDJHLFLJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly int FCHKILNFKBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly int LMFLAMEGHII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly int IMMLDBNGOGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly int FANOBHPHILK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly int HNLJHICLPGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public readonly int FEABKLILFFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public readonly int AOLHPJMFHBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public readonly int HLMGHACAAHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public readonly int HFAHDKFAIIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public readonly int IBCMJACIDDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public readonly int GGBKBFJKPAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public readonly int BLEOLCIKEIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public readonly int HKDGAFNDPIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public readonly int HNIGHEMFCJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public readonly int AFDJOBOJGFN;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x574E7B0", Offset = "0x574D1B0", VA = "0x18574E7B0")]
			public FBNHDJHLFLJ(int ELPONCPCGNB, int MPIAOOALFMB, int BFCLPHCCMJJ, int KCDJAHCODGI, int GLKPGPDJLJK, int HFPFEKAFHIN, int PIPFGEEENOL, int AGHEMKDJCJN, int DHOKBIIKDHO, int KPNNENGMAFN, int EIAAAEGOPID, int JGHJDKKAAJB, int CEMFHBBPIAF, int NCMIAMADLNB, int HLNLCDLGEFL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Dictionary<string, object>? BKAJCKKJHDP;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private static Dictionary<string, object> LPEHHDHLMLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5750930", Offset = "0x574F330", VA = "0x185750930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x57509F0", Offset = "0x574F3F0", VA = "0x1857509F0")]
		public static void BBKGMEIEJHA(FBNHDJHLFLJ LNNLOIBMEAB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class MAAEHMNFADN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x57511F0", Offset = "0x574FBF0", VA = "0x1857511F0")]
		public static void AAGJCBGBKNN(string FHLJKJHFEEK, object JHMGGBJMFCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5751260", Offset = "0x574FC60", VA = "0x185751260")]
		public static void AAGJCBGBKNN(string FHLJKJHFEEK, KKMFNFNBDPH JHMGGBJMFCH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class EEECAHAMEOK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x574E6A0", Offset = "0x574D0A0", VA = "0x18574E6A0")]
		public static void BPJGFLGJLBO(float3 CJONGNPPIAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class JMBJJFOPFML<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class AHINCMEEEJG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public JMBJJFOPFML<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
			public AHINCMEEEJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x3677B40", Offset = "0x3676540", VA = "0x183677B40")]
			internal object MIFMFIGBJLE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class JEIHCBDPJHL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public JMBJJFOPFML<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
			public JEIHCBDPJHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x39FCFA0", Offset = "0x39FB9A0", VA = "0x1839FCFA0")]
			internal object FOCHBBBKPPG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class FJDADBNINAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public JMBJJFOPFML<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
			public FJDADBNINAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x35C2CE0", Offset = "0x35C16E0", VA = "0x1835C2CE0")]
			internal object MDMOAFLMDLO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class PGMHKIMKALC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public JMBJJFOPFML<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public long elementId;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
			public PGMHKIMKALC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4093A80", Offset = "0x4092480", VA = "0x184093A80")]
			internal object BOGECOFIOMC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private const float EMBOOMIMPJF = 0.01f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly Guid CGALJLIIABC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly string MEGLIPCBHOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly string DGNKFLNILBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private string AMACOBMEHFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private string GNCPHJFKBEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private string DIFCMOBBEGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private string MBFFIHBACDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private string HIOFCHFNGPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private string ILOLLMJMPDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private string HOFELEPEDPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private IEnumerable<int?> ODHFDICLNOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly HashSet<T> NGJDPEGOOGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly Dictionary<(T, int), string> BDFFDMMIBAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly Dictionary<(T, int), float> KEMEDKFPEHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Dictionary<long, string> OHIIHJABANF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool OMCDBDNEFEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private GOACJHIODHI CBGCGONGJFO;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3A541C0", Offset = "0x3A52BC0", VA = "0x183A541C0")]
		public JMBJJFOPFML(Guid CGALJLIIABC, string DGNKFLNILBA, string MEGLIPCBHOK, string AMACOBMEHFI, [Optional] string GNCPHJFKBEN, [Optional] string DIFCMOBBEGJ, [Optional] string MBFFIHBACDJ, [Optional] string HOFELEPEDPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x799100", Offset = "0x797B00", VA = "0x180799100")]
		public void IKEEGLIDBOE(string GNCPHJFKBEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x79A7B0", Offset = "0x7991B0", VA = "0x18079A7B0")]
		public void JCHNDEIPIFI(string AMACOBMEHFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x78FCA0", Offset = "0x78E6A0", VA = "0x18078FCA0")]
		public void DIGJKBBLGHD(string HIOFCHFNGPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x78FCD0", Offset = "0x78E6D0", VA = "0x18078FCD0")]
		public void LEGAFNJKDPA(string ILOLLMJMPDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3A4F890", Offset = "0x3A4E290", VA = "0x183A4F890")]
		public void DCNMKKBPKFM(T CCICBAOJPBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3A4F570", Offset = "0x3A4DF70", VA = "0x183A4F570")]
		public void CNEKPOCOHNG(T CCICBAOJPBB, int KNGAHLPNNIH, float IIALIFABDOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3A4EB20", Offset = "0x3A4D520", VA = "0x183A4EB20")]
		public void AFLPFKCFEJM(T CCICBAOJPBB, int KNGAHLPNNIH, string KEGLEPICKHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3A4FFB0", Offset = "0x3A4E9B0", VA = "0x183A4FFB0")]
		public void DPIENACFBJM(long CCICBAOJPBB, string KBDDNHEBLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3A50130", Offset = "0x3A4EB30", VA = "0x183A50130")]
		public void ELMKPDELOPG(IEnumerable<int?> EADKMEACGLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3A52130", Offset = "0x3A50B30", VA = "0x183A52130")]
		public GOACJHIODHI JHFNKBOAPKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3A50910", Offset = "0x3A4F310", VA = "0x183A50910")]
		private (string, string) HMGMONHKGCO()
		{
			return default((string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3A53F00", Offset = "0x3A52900", VA = "0x183A53F00")]
		public static AJOAFJONIAF MGKGLGNAFFC(Guid CGALJLIIABC, string DGNKFLNILBA, T CCICBAOJPBB, string MEGLIPCBHOK, string HGFGNPCGMHB, string GNCPHJFKBEN, int? BNALCEABILL, [Optional] string HDFPMGAKOJC, [Optional] string KBDDNHEBLPE, [Optional] int? MHPPBHPMHCM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class GGMDOLLFFIE<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		protected readonly string HHDAKFCMDBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		protected readonly Guid LEPLIGHAENK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		protected readonly long CECOAMKIDGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		protected int KCEPNJAPLPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		protected int PIHCHOFFHDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		protected DateTime KJONHIOJNFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		protected bool LMMLMKNLJBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		protected Dictionary<long, MDLLGGMFLEF> OKMKMEJJFOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		protected bool LBPIJKKAFBM;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool ILFJJNBKGKA
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x825380", Offset = "0x823D80", VA = "0x180825380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool CBGKGENPNED
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xCC0CD0", Offset = "0xCBF6D0", VA = "0x180CC0CD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x36AA160", Offset = "0x36A8B60", VA = "0x1836AA160")]
		public GGMDOLLFFIE(string HHDAKFCMDBN, Guid LEPLIGHAENK, long CECOAMKIDGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void KPIPFHGLGCM(TListSessionStartParams HOFGCONGCBA);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x35D7A10", Offset = "0x35D6410", VA = "0x1835D7A10")]
		public void DCLKFJDLNNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void PIPOHGFJGMD(bool FNDJLJBLBJC, TListSessionLogParams JGGJLMAKFCP);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x36A9D80", Offset = "0x36A8780", VA = "0x1836A9D80")]
		public void HHJGBNHIOED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x36A9FC0", Offset = "0x36A89C0", VA = "0x1836A9FC0")]
		public void OKMAHABIFBM(long ICJIFJJJIEE, int BNALCEABILL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x36A9DD0", Offset = "0x36A87D0", VA = "0x1836A9DD0")]
		public void NDGJHPGHJNC(long ICJIFJJJIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract MDLLGGMFLEF IIFJFHFNMBK(TItem PPIDKPHGGGP, int BNALCEABILL, string DKFFFJFJNNK);
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class MDLLGGMFLEF : OEKMANDJMBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int KCEPNJAPLPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private long ICJIFJJJIEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private long CECOAMKIDGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly string HEDMNMNAEBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly string PJLHMMEKKCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly int JNBFNLMKLLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private DateTime NJICCOEMAAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private double ONMAGJKDHDO;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool OEPOONNGOJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xC5CB80", Offset = "0xC5B580", VA = "0x180C5CB80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xC5C850", Offset = "0xC5B250", VA = "0x180C5C850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5751B70", Offset = "0x5750570", VA = "0x185751B70")]
		public MDLLGGMFLEF(long ICJIFJJJIEE, int KCEPNJAPLPE, string AHMEMLPJJAB, long CECOAMKIDGD, int JNBFNLMKLLA, [Optional] string MEGLIPCBHOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5751480", Offset = "0x574FE80", VA = "0x185751480")]
		public void FGDKACEMFHM(int KCEPNJAPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5751B20", Offset = "0x5750520", VA = "0x185751B20")]
		public void PIPKLIAPPGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5751560", Offset = "0x574FF60", VA = "0x185751560")]
		public void HNLMOJGIGGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x57514F0", Offset = "0x574FEF0", VA = "0x1857514F0")]
		private void GNIFNFEFLEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5751670", Offset = "0x5750070", VA = "0x185751670", Slot = "5")]
		public virtual AJOAFJONIAF KGEFGCHLENA(Guid CGALJLIIABC, string HEEJLIPGKCO, [Optional] string AHMEMLPJJAB, [Optional] long? CCICBAOJPBB, [Optional] string MEGLIPCBHOK, [Optional] string GNCPHJFKBEN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class PLFJMPJCGKG
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class IEAIOGIBJFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public float nextHeartbeatSendTime;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
			public IEAIOGIBJFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x5750540", Offset = "0x574EF40", VA = "0x185750540")]
			internal bool BIPGGPJKPIE()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private struct FLMGIBGALAH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private IEAIOGIBJFO <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TimeSpan <delayPollingInterval>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x574EA30", Offset = "0x574D430", VA = "0x18574EA30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x574FBF0", Offset = "0x574E5F0", VA = "0x18574FBF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public static readonly float NGOHHBIAHCG;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static Dictionary<string, Dictionary<string, object>> OJKBAPLMKKE;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static Dictionary<string, Dictionary<string, object>> LAGLNNHCGCE;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static string OKJNOKLLIKB;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static CancellationTokenSource? LBKAPMPPIOL;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static int PMMHCAKNICM;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static bool HIHNPCICLPI;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly Dictionary<string, AJIANANAMBL> NBOCOPPEPNA;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly BCNLEBGHOIF DJOHBIGBLBA;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static PCCCLLDKGBH? IFEKFDBGENH;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static string HMMLJJIIGKD
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5755F70", Offset = "0x5754970", VA = "0x185755F70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x57546D0", Offset = "0x57530D0", VA = "0x1857546D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static Guid? FEIANFGDIGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x5754CF0", Offset = "0x57536F0", VA = "0x185754CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5754F30", Offset = "0x5753930", VA = "0x185754F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static NAOOHBNKKFF KKJFILDJGFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5755E90", Offset = "0x5754890", VA = "0x185755E90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private static bool FILKOEGNJIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5754790", Offset = "0x5753190", VA = "0x185754790")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5755E30", Offset = "0x5754830", VA = "0x185755E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private static bool EAMAKCEBOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x57545D0", Offset = "0x5752FD0", VA = "0x1857545D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x57551F0", Offset = "0x5753BF0", VA = "0x1857551F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private static float CILLPPBOKPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x57543C0", Offset = "0x5752DC0", VA = "0x1857543C0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5753830", Offset = "0x5752230", VA = "0x185753830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5755EE0", Offset = "0x57548E0", VA = "0x185755EE0")]
		public static void PKMCBKNGEKJ(string MIIMHHAHAIB, AJIANANAMBL PODBMCJHHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5753910", Offset = "0x5752310", VA = "0x185753910")]
		private static void CBBDADNAOMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5754D60", Offset = "0x5753760", VA = "0x185754D60")]
		internal static void IAMMEFBKIFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5754410", Offset = "0x5752E10", VA = "0x185754410")]
		internal static void DHJJKFMPLIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5754620", Offset = "0x5753020", VA = "0x185754620")]
		internal static void EDBGECBAFNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x57552F0", Offset = "0x5753CF0", VA = "0x1857552F0")]
		public static Guid KPIPFHGLGCM(string MIIMHHAHAIB, [Optional] string? DNDPPCFOEFM, [Optional] Dictionary<string, object>? JBOPBHEBIBC)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5755250", Offset = "0x5753C50", VA = "0x185755250")]
		public static Guid KPIPFHGLGCM(string MIIMHHAHAIB, long DNDPPCFOEFM, [Optional] Dictionary<string, object>? JBOPBHEBIBC)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x57541E0", Offset = "0x5752BE0", VA = "0x1857541E0")]
		public static void DCLKFJDLNNE(string MIIMHHAHAIB, [Optional] Guid? DMMBGEACBPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5755910", Offset = "0x5754310", VA = "0x185755910")]
		public static void MNFLFALOGCO(string MIIMHHAHAIB, string NLIPJMPPHCC, object IKAHFBJACGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x57547E0", Offset = "0x57531E0", VA = "0x1857547E0")]
		public static bool FCBGBCICNJL(string MIIMHHAHAIB, [Optional] string? DNDPPCFOEFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x57550B0", Offset = "0x5753AB0", VA = "0x1857550B0")]
		private static void KHIOHIFHLNG(bool HOHHJHKOGEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5755CA0", Offset = "0x57546A0", VA = "0x185755CA0")]
		internal static void MPPJKOPLPDM(string AGHGCGMHDAO, string FHLJKJHFEEK, object OBAHLGOPPIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5755B10", Offset = "0x5754510", VA = "0x185755B10")]
		internal static void MPPJKOPLPDM(string AGHGCGMHDAO, Dictionary<string, object> HBAGFCLKGMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5753890", Offset = "0x5752290", VA = "0x185753890")]
		private static void BDOLPIFBNPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5755060", Offset = "0x5753A60", VA = "0x185755060")]
		public static void KDNJELKPEDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x57549D0", Offset = "0x57533D0", VA = "0x1857549D0")]
		private static void FOKDMIPIGEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5755830", Offset = "0x5754230", VA = "0x185755830")]
		private static void LDIJPCKNEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5754F90", Offset = "0x5753990", VA = "0x185754F90")]
		[AsyncStateMachine(typeof(FLMGIBGALAH))]
		private static Task IDIEEPIMCOA(CancellationToken EAPNOLMLMHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5753D70", Offset = "0x5752770", VA = "0x185753D70")]
		private static void CDEDPEMPLFI(string MIIMHHAHAIB, Guid CGALJLIIABC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class HGPOCFAJFKM
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public struct CDDAHIKLNJI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public bool BLMNKHKHBAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public string IHGCNAFBNIC;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x179E710", Offset = "0x179D110", VA = "0x18179E710")]
			public CDDAHIKLNJI(bool BLMNKHKHBAG, string IHGCNAFBNIC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5750060", Offset = "0x574EA60", VA = "0x185750060")]
		public static CDDAHIKLNJI CIBIHDAPBBB(AJOAFJONIAF EKCMGLKKCKF)
		{
			return default(CDDAHIKLNJI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5750440", Offset = "0x574EE40", VA = "0x185750440")]
		private static void GOAPJKPPNCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5750380", Offset = "0x574ED80", VA = "0x185750380")]
		private static void FAIEKNCJPKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class LDNIDGMFNEB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x57508D0", Offset = "0x574F2D0", VA = "0x1857508D0")]
		public static AJOAFJONIAF LNAJPKEAJNB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class HEOJKKLJFOH
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x574FD00", Offset = "0x574E700", VA = "0x18574FD00")]
		public static AJOAFJONIAF CBNIAPBCNIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x574FD60", Offset = "0x574E760", VA = "0x18574FD60")]
		public static AJOAFJONIAF CFEIEGLMMNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x574FEE0", Offset = "0x574E8E0", VA = "0x18574FEE0")]
		public static AJOAFJONIAF KJMHOHJOMII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x574FE20", Offset = "0x574E820", VA = "0x18574FE20")]
		public static AJOAFJONIAF EANMFOPAIHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x574FFA0", Offset = "0x574E9A0", VA = "0x18574FFA0")]
		public static AJOAFJONIAF MPCJOIBMCEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x574FE80", Offset = "0x574E880", VA = "0x18574FE80")]
		public static AJOAFJONIAF GOLEAFCALGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x574FDC0", Offset = "0x574E7C0", VA = "0x18574FDC0")]
		public static AJOAFJONIAF CHMPFFEBCNC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x574FF40", Offset = "0x574E940", VA = "0x18574FF40")]
		public static AJOAFJONIAF MMGMHICIDPM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x574FCA0", Offset = "0x574E6A0", VA = "0x18574FCA0")]
		public static AJOAFJONIAF AFMOIBCKCDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5750000", Offset = "0x574EA00", VA = "0x185750000")]
		public static AJOAFJONIAF NKCCGGAHDEE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class PJKJHDPLLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5753650", Offset = "0x5752050", VA = "0x185753650")]
		public static AJOAFJONIAF PJALKDHAJGJ(long FKNNHALPBIJ, long LCPLCJKEEJE, bool IDGJEHFCDCO, string IONKBICBOJF, string OMJKFBFGELF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class BABEAJBOFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x574D510", Offset = "0x574BF10", VA = "0x18574D510")]
		public static AJOAFJONIAF LKCPOJLEMEG(string ACBHCPNFIIA, string APCBBCEAFGC, bool MFGGEKKMGMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x574D680", Offset = "0x574C080", VA = "0x18574D680")]
		public static AJOAFJONIAF MHEMBGCAOEH(string AGHGCGMHDAO, string LEJNLPLCAEN, string ACJJEGDJIOA, [Optional] int? NHFIPGODAKB, [Optional] double[] FABAKLIAABI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class DFPCAFKFEJE
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x574E350", Offset = "0x574CD50", VA = "0x18574E350")]
		public static AJOAFJONIAF MHMLDENLDDP(string PEEHOAHAFHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x574E1B0", Offset = "0x574CBB0", VA = "0x18574E1B0")]
		public static AJOAFJONIAF GEFJDGDDBII(string DPGBPOCKFLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x574E0F0", Offset = "0x574CAF0", VA = "0x18574E0F0")]
		public static AJOAFJONIAF COCDJJFDGCL(int JHCPMDFIMFL, string CDHDOGOGPME, string KABOEEEDCAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x574E2F0", Offset = "0x574CCF0", VA = "0x18574E2F0")]
		public static AJOAFJONIAF KEMCHNCAEIA(int JHCPMDFIMFL, string CDHDOGOGPME, string KABOEEEDCAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x574E290", Offset = "0x574CC90", VA = "0x18574E290")]
		public static AJOAFJONIAF GHIBIOKPPHM(int JHCPMDFIMFL, string CDHDOGOGPME, string KABOEEEDCAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x574E150", Offset = "0x574CB50", VA = "0x18574E150")]
		public static AJOAFJONIAF ECNJDGPGKHI(int JHCPMDFIMFL, string CDHDOGOGPME, string KABOEEEDCAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x574DFA0", Offset = "0x574C9A0", VA = "0x18574DFA0")]
		public static AJOAFJONIAF AIFPIPHMJCM(string CDHDOGOGPME, string KABOEEEDCAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x574E430", Offset = "0x574CE30", VA = "0x18574E430")]
		private static AJOAFJONIAF NEGAEKGLHOI(string HHDAKFCMDBN, int JHCPMDFIMFL, string CPCKCFJODKM, string CGIGJDCAMKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x574E570", Offset = "0x574CF70", VA = "0x18574E570")]
		private static AJOAFJONIAF NEGAEKGLHOI(string HHDAKFCMDBN, string CPCKCFJODKM, string CGIGJDCAMKK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly EACOFNPIGGG CIBIHDAPBBB;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static IAEJLIPIODJ KMONDNANKBC;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static LLGLDBIBNGB DGECOLLFLDL;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<AJOAFJONIAF> AIJEBCMEBDN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long HIPLHFKENPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x57534F0", Offset = "0x5751EF0", VA = "0x1857534F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5753360", Offset = "0x5751D60", VA = "0x185753360")]
	[DLKEJLMCDAC(LIAHCPEMJMG.Unity_BeforeSceneLoad)]
	private static void FDPBBFHPEHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5753440", Offset = "0x5751E40", VA = "0x185753440")]
	private static void IAMMEFBKIFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x57531C0", Offset = "0x5751BC0", VA = "0x1857531C0")]
	public static AJOAFJONIAF ADFMJFMBHLN(string NKPOFBALEFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x574D8B0", Offset = "0x574C2B0", VA = "0x18574D8B0")]
	public static AJOAFJONIAF ADFMJFMBHLN(string NKPOFBALEFL, int JHCPMDFIMFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5753240", Offset = "0x5751C40", VA = "0x185753240")]
	[DLKEJLMCDAC(LIAHCPEMJMG.Unity_BeforeSceneLoad)]
	private static void FDLLEAMDENF()
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
