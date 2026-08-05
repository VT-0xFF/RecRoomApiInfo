using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x269F9C0", Offset = "0x269EDC0", VA = "0x18269F9C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D5490", Offset = "0x9D4890", VA = "0x1809D5490")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9D54D0", Offset = "0x9D48D0", VA = "0x1809D54D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class APCPJDGBPBB : IOLFOONCHKI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x269F950", Offset = "0x269ED50", VA = "0x18269F950", Slot = "7")]
	public override string JIBLDGHIHFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x269F980", Offset = "0x269ED80", VA = "0x18269F980")]
	private APCPJDGBPBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x269F900", Offset = "0x269ED00", VA = "0x18269F900")]
	public static APCPJDGBPBB HBLBJMFGHFK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct JPPHAFNKKAO<TPartialAction, TPartialActionId, TFullAction, TDeps> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull where TDeps : notnull, IHDKDPPJGOC.JCDJHCMIHCG<TPartialAction, TPartialActionId, TFullAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class CJOHPLAOGLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly TPartialAction?[] PADHHBGADFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int FCMJGDCPJLM;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1092500", Offset = "0x1091900", VA = "0x181092500")]
		private CJOHPLAOGLB(TPartialAction[] DLHOECMLEEB, int AHLIIIOALOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x63F7DA0", Offset = "0x63F71A0", VA = "0x1863F7DA0")]
		public static JPPHAFNKKAO<TPartialAction, TPartialActionId, TFullAction, TDeps>.CJOHPLAOGLB HBLBJMFGHFK(int HHEJMJDDDBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x63F7C60", Offset = "0x63F7060", VA = "0x1863F7C60")]
		public NPOJFHOGAHB<TFullAction> FKABPLOOHNF(TPartialAction CAJLIMDCMCK, TDeps OHJFEHDLOHB)
		{
			return default(NPOJFHOGAHB<TFullAction>);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<TPartialActionId, CJOHPLAOGLB>? ENHNLNFDIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TDeps AMCNMNPOCHO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Dictionary<TPartialActionId, CJOHPLAOGLB> ACGPBCOPENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4CC2B10", Offset = "0x4CC1F10", VA = "0x184CC2B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4CC2C00", Offset = "0x4CC2000", VA = "0x184CC2C00")]
	private JPPHAFNKKAO(Dictionary<TPartialActionId, CJOHPLAOGLB>? AOAGADIBPLF, TDeps OHJFEHDLOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4CC2A60", Offset = "0x4CC1E60", VA = "0x184CC2A60")]
	public static JPPHAFNKKAO<TPartialAction, TPartialActionId, TFullAction, TDeps> HBLBJMFGHFK(TDeps OHJFEHDLOHB)
	{
		return default(JPPHAFNKKAO<TPartialAction, TPartialActionId, TFullAction, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4CC1BA0", Offset = "0x4CC0FA0", VA = "0x184CC1BA0")]
	public KGPHFOFOMPJ<NPOJFHOGAHB<TFullAction>, HEGOEPNOLEN> FKABPLOOHNF(TPartialAction CAJLIMDCMCK)
	{
		return default(KGPHFOFOMPJ<NPOJFHOGAHB<TFullAction>, HEGOEPNOLEN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4CC1AE0", Offset = "0x4CC0EE0", VA = "0x184CC1AE0")]
	public void EFFBMOHPAJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class IHDKDPPJGOC
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface JCDJHCMIHCG<TPartialAction, out TPartialActionId, out TFullAction> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int FGCDMNNJGIP([In] TPartialAction CAJLIMDCMCK);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int MFJKGNLENLL([In] TPartialAction CAJLIMDCMCK);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TPartialActionId IFGFNIEEFOB([In] TPartialAction CAJLIMDCMCK);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TFullAction FFEMOCBPAOD(TPartialAction[] DMDJMOGKIMI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct PMONINADFJH<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : IGKIMLADGNK.JNBCFGFBPAP<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal TPartialSnapshot[] DDHAJKBPDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal int CGBDALIMNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal TDeps AMCNMNPOCHO;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5357300", Offset = "0x5356700", VA = "0x185357300")]
	internal PMONINADFJH(TPartialSnapshot[] ANNLKOLPJDB, int FOIPCPIHMIC, TDeps OHJFEHDLOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x53571E0", Offset = "0x53565E0", VA = "0x1853571E0")]
	public static PMONINADFJH<TPartialSnapshot, TFullSnapshot, TDeps> HBLBJMFGHFK(TDeps OHJFEHDLOHB)
	{
		return default(PMONINADFJH<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class IGKIMLADGNK
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface JNBCFGFBPAP<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int HBGADFGMKEB([In] TPartialSnapshot IKLIIHCLINL);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot OGFIEDCFBLB(TPartialSnapshot[] POJKCIPMBFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x365B960", Offset = "0x365AD60", VA = "0x18365B960")]
	public static NPOJFHOGAHB<TFullSnapshot> FKABPLOOHNF<TFullSnapshot, TPartialSnapshot, TDeps>(this PMONINADFJH<TPartialSnapshot, TFullSnapshot, TDeps> JOCJBPPJMJJ, TPartialSnapshot IKLIIHCLINL) where TDeps : JNBCFGFBPAP<TPartialSnapshot, TFullSnapshot>
	{
		return default(NPOJFHOGAHB<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x365BD50", Offset = "0x365B150", VA = "0x18365BD50")]
	public static bool LFKFKKKMHBP<TPartialSnapshot, TFullSnapshot, TDeps>(this PMONINADFJH<TPartialSnapshot, TFullSnapshot, TDeps> JOCJBPPJMJJ, TPartialSnapshot IKLIIHCLINL) where TDeps : JNBCFGFBPAP<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class IGHKHEHOLJP : IOLFOONCHKI
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x269F990", Offset = "0x269ED90", VA = "0x18269F990", Slot = "7")]
	public override string JIBLDGHIHFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x269F980", Offset = "0x269ED80", VA = "0x18269F980")]
	public IGHKHEHOLJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class GKGEAMFEMMC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : BLPDKENIACC.MALNAOAIKGH<TAction, TNetSys> where TReceiverDeps : BLPDKENIACC.DDAGMBHGIHA<TAction, TReceiver> where TRootDeps : BLPDKENIACC.NKGENKBBEID<TMRequest, TAction, TRoot> where TDeps : BLPDKENIACC.MGBBBOHKMNB<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private interface NKCJNMCBPOD
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GFOBHJKKKJJ([In] KGPHFOFOMPJ<object, HEGOEPNOLEN> HBALBIOOGIJ);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MJPANBGIFGL();

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		KGPHFOFOMPJ<object, HEGOEPNOLEN> GFMACFEEFAD();

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void FCPOOLJGNBA(Exception BLCFGIAFKHH);
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class ANHJOGCBIOB : NKCJNMCBPOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly TaskCompletionSource<KGPHFOFOMPJ<object, HEGOEPNOLEN>> GINCBGCJLKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly List<KGPHFOFOMPJ<object, ALOCPDILHNE>> NKJDFAAMBMP;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x49FC920", Offset = "0x49FBD20", VA = "0x1849FC920")]
		private ANHJOGCBIOB(TaskCompletionSource<KGPHFOFOMPJ<object, HEGOEPNOLEN>> BBMIIIIDLPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4874520", Offset = "0x4873920", VA = "0x184874520")]
		public static ANHJOGCBIOB HBLBJMFGHFK(TaskCompletionSource<KGPHFOFOMPJ<object, HEGOEPNOLEN>> BBMIIIIDLPN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x49FC520", Offset = "0x49FB920", VA = "0x1849FC520")]
		public void GFOBHJKKKJJ([In] KGPHFOFOMPJ<object, HEGOEPNOLEN> HBALBIOOGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x49FC840", Offset = "0x49FBC40", VA = "0x1849FC840", Slot = "5")]
		public void MJPANBGIFGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x49FC3C0", Offset = "0x49FB7C0", VA = "0x1849FC3C0", Slot = "6")]
		public KGPHFOFOMPJ<object, HEGOEPNOLEN> GFMACFEEFAD()
		{
			return default(KGPHFOFOMPJ<object, HEGOEPNOLEN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x49FC2C0", Offset = "0x49FB6C0", VA = "0x1849FC2C0", Slot = "7")]
		public void FCPOOLJGNBA(Exception BLCFGIAFKHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x49FC380", Offset = "0x49FB780", VA = "0x1849FC380", Slot = "4")]
		private void GCJNDDMNNNA([In] KGPHFOFOMPJ<object, HEGOEPNOLEN> HBALBIOOGIJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class MGAEBFHBEMD : NKCJNMCBPOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly TaskCompletionSource<KGPHFOFOMPJ<object, HEGOEPNOLEN>> GINCBGCJLKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private KGPHFOFOMPJ<object, HEGOEPNOLEN> IKGHOCHMJFP;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9B2970", Offset = "0x9B1D70", VA = "0x1809B2970")]
		private MGAEBFHBEMD(TaskCompletionSource<KGPHFOFOMPJ<object, HEGOEPNOLEN>> BBMIIIIDLPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4874520", Offset = "0x4873920", VA = "0x184874520")]
		public static MGAEBFHBEMD HBLBJMFGHFK(TaskCompletionSource<KGPHFOFOMPJ<object, HEGOEPNOLEN>> BBMIIIIDLPN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xD0E790", Offset = "0xD0DB90", VA = "0x180D0E790")]
		public void GFOBHJKKKJJ([In] KGPHFOFOMPJ<object, HEGOEPNOLEN> HBALBIOOGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5058F20", Offset = "0x5058320", VA = "0x185058F20", Slot = "5")]
		public void MJPANBGIFGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xB52830", Offset = "0xB51C30", VA = "0x180B52830", Slot = "6")]
		public KGPHFOFOMPJ<object, HEGOEPNOLEN> GFMACFEEFAD()
		{
			return default(KGPHFOFOMPJ<object, HEGOEPNOLEN>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5058E60", Offset = "0x5058260", VA = "0x185058E60", Slot = "7")]
		public void FCPOOLJGNBA(Exception BLCFGIAFKHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x49FC380", Offset = "0x49FB780", VA = "0x1849FC380", Slot = "4")]
		private void GCJNDDMNNNA([In] KGPHFOFOMPJ<object, HEGOEPNOLEN> HBALBIOOGIJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class BOEALCOGLNB : NKCJNMCBPOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<KGPHFOFOMPJ<object, HEGOEPNOLEN>> NKJDFAAMBMP;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6017690", Offset = "0x6016A90", VA = "0x186017690")]
		private BOEALCOGLNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4C0CCE0", Offset = "0x4C0C0E0", VA = "0x184C0CCE0")]
		public static BOEALCOGLNB HBLBJMFGHFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x60174D0", Offset = "0x60168D0", VA = "0x1860174D0")]
		public void GFOBHJKKKJJ([In] KGPHFOFOMPJ<object, HEGOEPNOLEN> HBALBIOOGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		public void MJPANBGIFGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6017410", Offset = "0x6016810", VA = "0x186017410", Slot = "6")]
		public KGPHFOFOMPJ<object, HEGOEPNOLEN> GFMACFEEFAD()
		{
			return default(KGPHFOFOMPJ<object, HEGOEPNOLEN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6017370", Offset = "0x6016770", VA = "0x186017370", Slot = "7")]
		[DGBLOAGKOKD("This may be terminal and should probably do more than discarding the exception.")]
		public void FCPOOLJGNBA(Exception BLCFGIAFKHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x49FC380", Offset = "0x49FB780", VA = "0x1849FC380", Slot = "4")]
		private void GCJNDDMNNNA([In] KGPHFOFOMPJ<object, HEGOEPNOLEN> HBALBIOOGIJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class JHKIILIJFID : NKCJNMCBPOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private KGPHFOFOMPJ<object, HEGOEPNOLEN> IKGHOCHMJFP;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		private JHKIILIJFID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4C0CCE0", Offset = "0x4C0C0E0", VA = "0x184C0CCE0")]
		public static JHKIILIJFID HBLBJMFGHFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x21FF9D0", Offset = "0x21FEDD0", VA = "0x1821FF9D0")]
		public void GFOBHJKKKJJ([In] KGPHFOFOMPJ<object, HEGOEPNOLEN> HBALBIOOGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		public void MJPANBGIFGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xBA3F00", Offset = "0xBA3300", VA = "0x180BA3F00", Slot = "6")]
		public KGPHFOFOMPJ<object, HEGOEPNOLEN> GFMACFEEFAD()
		{
			return default(KGPHFOFOMPJ<object, HEGOEPNOLEN>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4C0CC40", Offset = "0x4C0C040", VA = "0x184C0CC40", Slot = "7")]
		[DGBLOAGKOKD("This may be terminal and should probably do more than discarding the exception.")]
		public void FCPOOLJGNBA(Exception BLCFGIAFKHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x49FC380", Offset = "0x49FB780", VA = "0x1849FC380", Slot = "4")]
		private void GCJNDDMNNNA([In] KGPHFOFOMPJ<object, HEGOEPNOLEN> HBALBIOOGIJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct ABFGPDLPAGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<object, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public GKGEAMFEMMC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public IJOGBJOFPED<BKOCDGICELM> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskCompletionSource<KGPHFOFOMPJ<object, HEGOEPNOLEN>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private TaskAwaiter<KGPHFOFOMPJ<object, HEGOEPNOLEN>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x47F8EB0", Offset = "0x47F82B0", VA = "0x1847F8EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x47F9920", Offset = "0x47F8D20", VA = "0x1847F9920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct AEGEPJPJIIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<object, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public GKGEAMFEMMC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public IJOGBJOFPED<BKOCDGICELM> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<KGPHFOFOMPJ<object, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4809D60", Offset = "0x4809160", VA = "0x184809D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x480A620", Offset = "0x4809A20", VA = "0x18480A620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct IPMDPAPELJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<object, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public GKGEAMFEMMC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IJOGBJOFPED<BKOCDGICELM> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public IJOGBJOFPED<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<KGPHFOFOMPJ<object, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4A32F40", Offset = "0x4A32340", VA = "0x184A32F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4A33320", Offset = "0x4A32720", VA = "0x184A33320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct LJODCGADMIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<object, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public GKGEAMFEMMC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public IJOGBJOFPED<BKOCDGICELM> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public IJOGBJOFPED<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private NKCJNMCBPOD <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4E6ACA0", Offset = "0x4E6A0A0", VA = "0x184E6ACA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4E6C670", Offset = "0x4E6BA70", VA = "0x184E6C670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct FLPOKIFKOEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public GKGEAMFEMMC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NKCJNMCBPOD completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private NKCJNMCBPOD <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<KGPHFOFOMPJ<object?, HEGOEPNOLEN>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x477B030", Offset = "0x477A430", VA = "0x18477B030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x477EEA0", Offset = "0x477E2A0", VA = "0x18477EEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct EEIAICHEBAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public TAction[] snapshotActions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public GKGEAMFEMMC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IJOGBJOFPED<BKOCDGICELM> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x42D4AA0", Offset = "0x42D3EA0", VA = "0x1842D4AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x42D5180", Offset = "0x42D4580", VA = "0x1842D5180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly TDeps AMCNMNPOCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<IJOGBJOFPED<TMRequest>, TaskCompletionSource<KGPHFOFOMPJ<object, HEGOEPNOLEN>>> JCCPAIOKGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private PIIMICIGMMJ<TMRequest> HMHCCFNDCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool KJIFPAKBBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int CKCMIIGFDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Task AAEMGDBGODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private int AMCDGOLHGCA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TActionDeps OPHFJBPPODA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x48644D0", Offset = "0x48638D0", VA = "0x1848644D0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TRootDeps IHDLKNKOEHF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x48629B0", Offset = "0x4861DB0", VA = "0x1848629B0")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private TReceiverDeps LKBCIIOBLBO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4864550", Offset = "0x4863950", VA = "0x184864550")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool OCOMEPIKPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xC5C590", Offset = "0xC5B990", VA = "0x180C5C590")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xC5D120", Offset = "0xC5C520", VA = "0x180C5D120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MIADGBBFINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9A9220", Offset = "0x9A8620", VA = "0x1809A9220")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int NBENMCLLFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9C86A0", Offset = "0x9C7AA0", VA = "0x1809C86A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4864810", Offset = "0x4863C10", VA = "0x184864810")]
	public GKGEAMFEMMC(TDeps OHJFEHDLOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4863150", Offset = "0x4862550", VA = "0x184863150")]
	public Task<KGPHFOFOMPJ<object, HEGOEPNOLEN>> FEBNAMCNFMD(TRoot BKHMOJGGBFN, TNetSys OEAKNALPJLF, IJOGBJOFPED<BKOCDGICELM> PBDEPMNBOEB, TAction IOPCFKOHPBF, bool FHAKEDFMMAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4862FF0", Offset = "0x48623F0", VA = "0x184862FF0")]
	[AsyncStateMachine(typeof(GKGEAMFEMMC<, , , , , , , , >.ABFGPDLPAGC))]
	private Task<KGPHFOFOMPJ<object, HEGOEPNOLEN>> FEBNAMCNFMD(TRoot BKHMOJGGBFN, IJOGBJOFPED<BKOCDGICELM> PBDEPMNBOEB, TAction IOPCFKOHPBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4862570", Offset = "0x4861970", VA = "0x184862570")]
	[AsyncStateMachine(typeof(GKGEAMFEMMC<, , , , , , , , >.AEGEPJPJIIG))]
	private Task<KGPHFOFOMPJ<object, HEGOEPNOLEN>> APJFLBADBLE(TRoot BKHMOJGGBFN, IJOGBJOFPED<BKOCDGICELM> PBDEPMNBOEB, TAction[] NBIPNPJJADG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4862840", Offset = "0x4861C40", VA = "0x184862840")]
	[AsyncStateMachine(typeof(GKGEAMFEMMC<, , , , , , , , >.IPMDPAPELJO))]
	public Task<KGPHFOFOMPJ<object, HEGOEPNOLEN>> BPOIKDACAIF(TRoot BKHMOJGGBFN, TNetSys NEIHHCNHJAP, TReceiver IIOEMENEBDK, IJOGBJOFPED<BKOCDGICELM> PBDEPMNBOEB, IJOGBJOFPED<TMRequest> KFIDAOBPDOI, TAction IOPCFKOHPBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4863850", Offset = "0x4862C50", VA = "0x184863850")]
	[AsyncStateMachine(typeof(GKGEAMFEMMC<, , , , , , , , >.LJODCGADMIC))]
	private Task<KGPHFOFOMPJ<object, HEGOEPNOLEN>> FENMONMNDJO(TRoot BKHMOJGGBFN, TNetSys NEIHHCNHJAP, TReceiver IIOEMENEBDK, IJOGBJOFPED<BKOCDGICELM> PBDEPMNBOEB, IJOGBJOFPED<TMRequest> KFIDAOBPDOI, TAction IOPCFKOHPBF, Task KCDONMCBFGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x48639D0", Offset = "0x4862DD0", VA = "0x1848639D0")]
	[AsyncStateMachine(typeof(GKGEAMFEMMC<, , , , , , , , >.FLPOKIFKOEJ))]
	private Task GFGFENFHOIH(TRoot BKHMOJGGBFN, TNetSys NEIHHCNHJAP, TReceiver IIOEMENEBDK, TAction IOPCFKOHPBF, NKCJNMCBPOD FCJBEHOIKFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4864350", Offset = "0x4863750", VA = "0x184864350")]
	private void HDMNJBGPPNJ(TReceiver IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4863C80", Offset = "0x4863080", VA = "0x184863C80")]
	private void HBFGMOFHGAA(TRoot BKHMOJGGBFN, TNetSys NEIHHCNHJAP, TReceiver IIOEMENEBDK, IJOGBJOFPED<BKOCDGICELM> PBDEPMNBOEB, TAction IOPCFKOHPBF, bool MGKPFAOGPOJ, bool HKLNKGJHBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4864580", Offset = "0x4863980", VA = "0x184864580")]
	[AsyncStateMachine(typeof(GKGEAMFEMMC<, , , , , , , , >.EEIAICHEBAF))]
	public Task ONMHHOHHAIA(TRoot BKHMOJGGBFN, TNetSys NEIHHCNHJAP, IJOGBJOFPED<BKOCDGICELM> PBDEPMNBOEB, TAction[] HJHOENLNCCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class BLPDKENIACC
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface MALNAOAIKGH<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int HFNJFKFGCOJ(TNetSys LFCHBABPELB, TAction IOPCFKOHPBF);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction LGNAHAJBMJP(TNetSys LFCHBABPELB, TAction IOPCFKOHPBF);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction HPCPLLLCPAG(TNetSys LFCHBABPELB, TAction IOPCFKOHPBF);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> ACCLKFPKHBP(TNetSys LFCHBABPELB, TAction IOPCFKOHPBF);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] JNFEKMMHBHO(TNetSys LFCHBABPELB, TAction IOPCFKOHPBF, int DAKBPMOHLBK);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool IMACMADCOJN(TNetSys LFCHBABPELB, TAction IOPCFKOHPBF);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool EHBKMALFMJE(TNetSys LFCHBABPELB, TAction IOPCFKOHPBF);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool DOHDGMFHEPN(TNetSys LFCHBABPELB, TAction IOPCFKOHPBF);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool LLBIAAGPGFD(TNetSys LFCHBABPELB, TAction IOPCFKOHPBF);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool ELEOBBOHDDH(TNetSys LFCHBABPELB, TAction IOPCFKOHPBF);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool GKEEKMFIBMG(TNetSys LFCHBABPELB, TAction IOPCFKOHPBF);
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface MGBBBOHKMNB<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TActionDeps OPHFJBPPODA
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TReceiverDeps LKBCIIOBLBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		TRootDeps IHDLKNKOEHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface DDAGMBHGIHA<TAction, TReceiver> where TAction : notnull where TReceiver : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IJOGBJOFPED<BKOCDGICELM> MCMHJEBGCFG(TReceiver IIOEMENEBDK);

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AGDLLMIKMDN(TReceiver IIOEMENEBDK);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<KGPHFOFOMPJ<object, HEGOEPNOLEN>> BPOIKDACAIF(TReceiver IIOEMENEBDK, TAction IOPCFKOHPBF);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TAction[] FJOENDHLANH(TReceiver IIOEMENEBDK);
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface NKGENKBBEID<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int BMBIDEGHNCE(TRoot BKHMOJGGBFN);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int LLDFLAMBIMC(TRoot BKHMOJGGBFN);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int FFLNDBGHNEP(TRoot BKHMOJGGBFN);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int JFBHBKPHIJP(TRoot BKHMOJGGBFN);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ELFEKOGEHAK(TRoot BKHMOJGGBFN);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool FMCCJDPKDOD(TRoot BKHMOJGGBFN, IJOGBJOFPED<BKOCDGICELM> PBDEPMNBOEB, TAction[] NBIPNPJJADG);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task FEBNAMCNFMD(TRoot BKHMOJGGBFN, IJOGBJOFPED<BKOCDGICELM> PBDEPMNBOEB, IJOGBJOFPED<TMRequest> KFIDAOBPDOI, TAction IOPCFKOHPBF, bool BAIJPLDIIGO = true);
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
