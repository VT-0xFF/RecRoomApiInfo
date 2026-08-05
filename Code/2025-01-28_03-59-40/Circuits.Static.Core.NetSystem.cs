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
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x25394D0", Offset = "0x25386D0", VA = "0x1825394D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x91E490", Offset = "0x91D690", VA = "0x18091E490")]
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
		[Cpp2IlInjected.Address(RVA = "0x91E4D0", Offset = "0x91D6D0", VA = "0x18091E4D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class PDECIGDLOIJ : ODKGPKGHBED
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2539550", Offset = "0x2538750", VA = "0x182539550", Slot = "7")]
	public override string OEJBHPKDIJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x25394C0", Offset = "0x25386C0", VA = "0x1825394C0")]
	private PDECIGDLOIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2539580", Offset = "0x2538780", VA = "0x182539580")]
	public static PDECIGDLOIJ PAJOIGLPBMN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct KBCKNICHPFB<TPartialAction, TPartialActionId, TFullAction, TDeps> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull where TDeps : notnull, CFEDDCLOBJC.CFPENBFLDIP<TPartialAction, TPartialActionId, TFullAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class CIHLILIPPOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly TPartialAction?[] DAEHDCOIHOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int MIOPOMJPGGE;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xFA8980", Offset = "0xFA7B80", VA = "0x180FA8980")]
		private CIHLILIPPOC(TPartialAction[] BBMEOAKBMBD, int JDCHMJFBIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5797ED0", Offset = "0x57970D0", VA = "0x185797ED0")]
		public static KBCKNICHPFB<TPartialAction, TPartialActionId, TFullAction, TDeps>.CIHLILIPPOC PAJOIGLPBMN(int APIKKMDIGIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5797B70", Offset = "0x5796D70", VA = "0x185797B70")]
		public IIKGGOMPAPK<TFullAction> APEJGCLIJLH(TPartialAction LOFGLLJCJAF, TDeps KHICLIFOGCP)
		{
			return default(IIKGGOMPAPK<TFullAction>);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<TPartialActionId, CIHLILIPPOC>? MOGEDFAKCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TDeps PHOHCHAEDED;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Dictionary<TPartialActionId, CIHLILIPPOC> HPJBMCMIOID
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4917590", Offset = "0x4916790", VA = "0x184917590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4917730", Offset = "0x4916930", VA = "0x184917730")]
	private KBCKNICHPFB(Dictionary<TPartialActionId, CIHLILIPPOC>? OLCIBCHMGLJ, TDeps KHICLIFOGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x49176E0", Offset = "0x49168E0", VA = "0x1849176E0")]
	public static KBCKNICHPFB<TPartialAction, TPartialActionId, TFullAction, TDeps> PAJOIGLPBMN(TDeps KHICLIFOGCP)
	{
		return default(KBCKNICHPFB<TPartialAction, TPartialActionId, TFullAction, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4916EF0", Offset = "0x49160F0", VA = "0x184916EF0")]
	public EBOICGKKPAM<IIKGGOMPAPK<TFullAction>, LKEBDJCDIFL> APEJGCLIJLH(TPartialAction LOFGLLJCJAF)
	{
		return default(EBOICGKKPAM<IIKGGOMPAPK<TFullAction>, LKEBDJCDIFL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4916610", Offset = "0x4915810", VA = "0x184916610")]
	public void AIBAOMCFHAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CFEDDCLOBJC
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface CFPENBFLDIP<TPartialAction, out TPartialActionId, out TFullAction> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int IBPKJJILNNA([In] TPartialAction LOFGLLJCJAF);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int KCGGEJMJGBK([In] TPartialAction LOFGLLJCJAF);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TPartialActionId PEMKHMIOCGO([In] TPartialAction LOFGLLJCJAF);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TFullAction FFHLKJGHGNP(TPartialAction[] JJGGCJKJBGL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct NHJEFOOFDDM<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : HHLPFDIAPLP.FEFNKGKBFKF<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal TPartialSnapshot[] HKGDKAIOAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal int MDPAHOCCDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal TDeps PHOHCHAEDED;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4C7A8F0", Offset = "0x4C79AF0", VA = "0x184C7A8F0")]
	internal NHJEFOOFDDM(TPartialSnapshot[] AEDMBNNBCHH, int FAFKOBIIEKJ, TDeps KHICLIFOGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4C7A890", Offset = "0x4C79A90", VA = "0x184C7A890")]
	public static NHJEFOOFDDM<TPartialSnapshot, TFullSnapshot, TDeps> PAJOIGLPBMN(TDeps KHICLIFOGCP)
	{
		return default(NHJEFOOFDDM<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class HHLPFDIAPLP
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface FEFNKGKBFKF<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int NMKOKFLDMMB([In] TPartialSnapshot BDCMLPFJHGM);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot IAGBNNGHCGD(TPartialSnapshot[] CHEFBECCHOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x328E0B0", Offset = "0x328D2B0", VA = "0x18328E0B0")]
	public static IIKGGOMPAPK<TFullSnapshot> APEJGCLIJLH<TFullSnapshot, TPartialSnapshot, TDeps>(this NHJEFOOFDDM<TPartialSnapshot, TFullSnapshot, TDeps> MLNFAKCEGNM, TPartialSnapshot BDCMLPFJHGM) where TDeps : FEFNKGKBFKF<TPartialSnapshot, TFullSnapshot>
	{
		return default(IIKGGOMPAPK<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x328E4A0", Offset = "0x328D6A0", VA = "0x18328E4A0")]
	public static bool HEGDBIODOAH<TPartialSnapshot, TFullSnapshot, TDeps>(this NHJEFOOFDDM<TPartialSnapshot, TFullSnapshot, TDeps> MLNFAKCEGNM, TPartialSnapshot BDCMLPFJHGM) where TDeps : FEFNKGKBFKF<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class DNIOABNJKFK : ODKGPKGHBED
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2539490", Offset = "0x2538690", VA = "0x182539490", Slot = "7")]
	public override string OEJBHPKDIJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x25394C0", Offset = "0x25386C0", VA = "0x1825394C0")]
	public DNIOABNJKFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class OGJEMOCGNGN<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : FHADEGJBDFM.MFDCCLJBDBF<TAction, TNetSys> where TReceiverDeps : FHADEGJBDFM.MNBEIFBBPMF<TAction, TReceiver> where TRootDeps : FHADEGJBDFM.OLNONLDMPAO<TMRequest, TAction, TRoot> where TDeps : FHADEGJBDFM.CBKGAJAAJLD<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private interface JGIEMOIDBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DBINKAEFGBH([In] EBOICGKKPAM<object, LKEBDJCDIFL> NJFLHCEDIDN);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PMBEJFHNNBK();

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		EBOICGKKPAM<object, LKEBDJCDIFL> EGNPNFOBMJA();

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LHLOCLEMMKL(Exception ANJHEGDKNFP);
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class PDDKKGDOCKE : JGIEMOIDBOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly TaskCompletionSource<EBOICGKKPAM<object, LKEBDJCDIFL>> NKHMGDHLELL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly List<EBOICGKKPAM<object, MNCKOMAJMKB>> LOOMGKFBGCP;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4F230C0", Offset = "0x4F222C0", VA = "0x184F230C0")]
		private PDDKKGDOCKE(TaskCompletionSource<EBOICGKKPAM<object, LKEBDJCDIFL>> CKCFPDNENEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x44DFF90", Offset = "0x44DF190", VA = "0x1844DFF90")]
		public static PDDKKGDOCKE PAJOIGLPBMN(TaskCompletionSource<EBOICGKKPAM<object, LKEBDJCDIFL>> CKCFPDNENEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4F22A00", Offset = "0x4F21C00", VA = "0x184F22A00")]
		public void DBINKAEFGBH([In] EBOICGKKPAM<object, LKEBDJCDIFL> NJFLHCEDIDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4F22F40", Offset = "0x4F22140", VA = "0x184F22F40", Slot = "5")]
		public void PMBEJFHNNBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4F22C40", Offset = "0x4F21E40", VA = "0x184F22C40", Slot = "6")]
		public EBOICGKKPAM<object, LKEBDJCDIFL> EGNPNFOBMJA()
		{
			return default(EBOICGKKPAM<object, LKEBDJCDIFL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4F22DA0", Offset = "0x4F21FA0", VA = "0x184F22DA0", Slot = "7")]
		public void LHLOCLEMMKL(Exception ANJHEGDKNFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x466ABE0", Offset = "0x4669DE0", VA = "0x18466ABE0", Slot = "4")]
		private void PMIPOJIKFHP([In] EBOICGKKPAM<object, LKEBDJCDIFL> NJFLHCEDIDN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class IPJLAPEKCNA : JGIEMOIDBOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly TaskCompletionSource<EBOICGKKPAM<object, LKEBDJCDIFL>> NKHMGDHLELL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private EBOICGKKPAM<object, LKEBDJCDIFL> HLNOMAKBAID;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
		private IPJLAPEKCNA(TaskCompletionSource<EBOICGKKPAM<object, LKEBDJCDIFL>> CKCFPDNENEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x44DFF90", Offset = "0x44DF190", VA = "0x1844DFF90")]
		public static IPJLAPEKCNA PAJOIGLPBMN(TaskCompletionSource<EBOICGKKPAM<object, LKEBDJCDIFL>> CKCFPDNENEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x466AA40", Offset = "0x4669C40", VA = "0x18466AA40")]
		public void DBINKAEFGBH([In] EBOICGKKPAM<object, LKEBDJCDIFL> NJFLHCEDIDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x466AB80", Offset = "0x4669D80", VA = "0x18466AB80", Slot = "5")]
		public void PMBEJFHNNBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAAB970", Offset = "0xAAAB70", VA = "0x180AAB970", Slot = "6")]
		public EBOICGKKPAM<object, LKEBDJCDIFL> EGNPNFOBMJA()
		{
			return default(EBOICGKKPAM<object, LKEBDJCDIFL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x466AAC0", Offset = "0x4669CC0", VA = "0x18466AAC0", Slot = "7")]
		public void LHLOCLEMMKL(Exception ANJHEGDKNFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x466ABE0", Offset = "0x4669DE0", VA = "0x18466ABE0", Slot = "4")]
		private void PMIPOJIKFHP([In] EBOICGKKPAM<object, LKEBDJCDIFL> NJFLHCEDIDN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class NNOHPJKNKDD : JGIEMOIDBOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<EBOICGKKPAM<object, LKEBDJCDIFL>> LOOMGKFBGCP;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4CA8480", Offset = "0x4CA7680", VA = "0x184CA8480")]
		private NNOHPJKNKDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4A10C60", Offset = "0x4A0FE60", VA = "0x184A10C60")]
		public static NNOHPJKNKDD PAJOIGLPBMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4CA80D0", Offset = "0x4CA72D0", VA = "0x184CA80D0")]
		public void DBINKAEFGBH([In] EBOICGKKPAM<object, LKEBDJCDIFL> NJFLHCEDIDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		public void PMBEJFHNNBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4CA8290", Offset = "0x4CA7490", VA = "0x184CA8290", Slot = "6")]
		public EBOICGKKPAM<object, LKEBDJCDIFL> EGNPNFOBMJA()
		{
			return default(EBOICGKKPAM<object, LKEBDJCDIFL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4CA83A0", Offset = "0x4CA75A0", VA = "0x184CA83A0", Slot = "7")]
		[CKOGIBPDLCN("This may be terminal and should probably do more than discarding the exception.")]
		public void LHLOCLEMMKL(Exception ANJHEGDKNFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x466ABE0", Offset = "0x4669DE0", VA = "0x18466ABE0", Slot = "4")]
		private void PMIPOJIKFHP([In] EBOICGKKPAM<object, LKEBDJCDIFL> NJFLHCEDIDN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class LPLIGMFJNOH : JGIEMOIDBOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private EBOICGKKPAM<object, LKEBDJCDIFL> HLNOMAKBAID;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		private LPLIGMFJNOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4A10C60", Offset = "0x4A0FE60", VA = "0x184A10C60")]
		public static LPLIGMFJNOH PAJOIGLPBMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x20413F0", Offset = "0x20405F0", VA = "0x1820413F0")]
		public void DBINKAEFGBH([In] EBOICGKKPAM<object, LKEBDJCDIFL> NJFLHCEDIDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		public void PMBEJFHNNBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xB00AB0", Offset = "0xAFFCB0", VA = "0x180B00AB0", Slot = "6")]
		public EBOICGKKPAM<object, LKEBDJCDIFL> EGNPNFOBMJA()
		{
			return default(EBOICGKKPAM<object, LKEBDJCDIFL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4A10BC0", Offset = "0x4A0FDC0", VA = "0x184A10BC0", Slot = "7")]
		[CKOGIBPDLCN("This may be terminal and should probably do more than discarding the exception.")]
		public void LHLOCLEMMKL(Exception ANJHEGDKNFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x466ABE0", Offset = "0x4669DE0", VA = "0x18466ABE0", Slot = "4")]
		private void PMIPOJIKFHP([In] EBOICGKKPAM<object, LKEBDJCDIFL> NJFLHCEDIDN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct JGJJCDAPKDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<object, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public OGJEMOCGNGN<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public ANHNAJIBLBK<AKJMODAIHHM> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskCompletionSource<EBOICGKKPAM<object, LKEBDJCDIFL>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private TaskAwaiter<EBOICGKKPAM<object, LKEBDJCDIFL>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4827DA0", Offset = "0x4826FA0", VA = "0x184827DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4828870", Offset = "0x4827A70", VA = "0x184828870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct BCCHJGKJDEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<object, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public OGJEMOCGNGN<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public ANHNAJIBLBK<AKJMODAIHHM> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<EBOICGKKPAM<object, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5631DD0", Offset = "0x5630FD0", VA = "0x185631DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5632700", Offset = "0x5631900", VA = "0x185632700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct OFJILAEIPOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<object, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public OGJEMOCGNGN<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public ANHNAJIBLBK<AKJMODAIHHM> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public ANHNAJIBLBK<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<EBOICGKKPAM<object, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4DAB570", Offset = "0x4DAA770", VA = "0x184DAB570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4DAB8E0", Offset = "0x4DAAAE0", VA = "0x184DAB8E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct DOCDDPFHIDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<object, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public OGJEMOCGNGN<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public ANHNAJIBLBK<AKJMODAIHHM> senderId;

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
		public ANHNAJIBLBK<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JGIEMOIDBOJ <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6085CB0", Offset = "0x6084EB0", VA = "0x186085CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6087690", Offset = "0x6086890", VA = "0x186087690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct BFEDKAGLEEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public OGJEMOCGNGN<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public JGIEMOIDBOJ completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private JGIEMOIDBOJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<EBOICGKKPAM<object?, LKEBDJCDIFL>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5643DB0", Offset = "0x5642FB0", VA = "0x185643DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5647D60", Offset = "0x5646F60", VA = "0x185647D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct FPKBCMBPICA : IAsyncStateMachine
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
		public OGJEMOCGNGN<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public ANHNAJIBLBK<AKJMODAIHHM> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x43042A0", Offset = "0x43034A0", VA = "0x1843042A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4304680", Offset = "0x4303880", VA = "0x184304680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly TDeps PHOHCHAEDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<ANHNAJIBLBK<TMRequest>, TaskCompletionSource<EBOICGKKPAM<object, LKEBDJCDIFL>>> FJHHCHPPKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EBFKDPKADHA<TMRequest> IDAMPGMMKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool AHJNCJAPKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int PDEFHIBHHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Task PNGNAPIIADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private int DCADNCNGDGK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TActionDeps BHHDAMKOAPL
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4DB0CC0", Offset = "0x4DAFEC0", VA = "0x184DB0CC0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TRootDeps LPHCJPNLFDK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4DB06A0", Offset = "0x4DAF8A0", VA = "0x184DB06A0")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private TReceiverDeps MJBHCICKEBC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4DB0FD0", Offset = "0x4DB01D0", VA = "0x184DB0FD0")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool JHFJEBIBGDG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xBC2170", Offset = "0xBC1370", VA = "0x180BC2170")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xBC2510", Offset = "0xBC1710", VA = "0x180BC2510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HPLJCIKPHBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8F5470", Offset = "0x8F4670", VA = "0x1808F5470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int FPAHOLHBKGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x911450", Offset = "0x910650", VA = "0x180911450")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4DB2AE0", Offset = "0x4DB1CE0", VA = "0x184DB2AE0")]
	public OGJEMOCGNGN(TDeps KHICLIFOGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4DB1720", Offset = "0x4DB0920", VA = "0x184DB1720")]
	public Task<EBOICGKKPAM<object, LKEBDJCDIFL>> KLHCENHFAPI(TRoot DONMCNODAED, TNetSys IKHNGLILPHL, ANHNAJIBLBK<AKJMODAIHHM> APDDGNGPBHM, TAction KOMGLJOLBFC, bool MMLBLFDFKKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4DB1B30", Offset = "0x4DB0D30", VA = "0x184DB1B30")]
	[AsyncStateMachine(typeof(OGJEMOCGNGN<, , , , , , , , >.JGJJCDAPKDC))]
	private Task<EBOICGKKPAM<object, LKEBDJCDIFL>> KLHCENHFAPI(TRoot DONMCNODAED, ANHNAJIBLBK<AKJMODAIHHM> APDDGNGPBHM, TAction KOMGLJOLBFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4DB0880", Offset = "0x4DAFA80", VA = "0x184DB0880")]
	[AsyncStateMachine(typeof(OGJEMOCGNGN<, , , , , , , , >.BCCHJGKJDEJ))]
	private Task<EBOICGKKPAM<object, LKEBDJCDIFL>> CBBMEIGMECL(TRoot DONMCNODAED, ANHNAJIBLBK<AKJMODAIHHM> APDDGNGPBHM, TAction[] MPDFABPCMPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4DB0E60", Offset = "0x4DB0060", VA = "0x184DB0E60")]
	[AsyncStateMachine(typeof(OGJEMOCGNGN<, , , , , , , , >.OFJILAEIPOI))]
	public Task<EBOICGKKPAM<object, LKEBDJCDIFL>> GKHIPAFGJIF(TRoot DONMCNODAED, TNetSys FJAELENBHMI, TReceiver LFLGFFHCMEJ, ANHNAJIBLBK<AKJMODAIHHM> APDDGNGPBHM, ANHNAJIBLBK<TMRequest> JKNLDJANAJD, TAction KOMGLJOLBFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4DB23A0", Offset = "0x4DB15A0", VA = "0x184DB23A0")]
	[AsyncStateMachine(typeof(OGJEMOCGNGN<, , , , , , , , >.DOCDDPFHIDJ))]
	private Task<EBOICGKKPAM<object, LKEBDJCDIFL>> LIFIHELACAE(TRoot DONMCNODAED, TNetSys FJAELENBHMI, TReceiver LFLGFFHCMEJ, ANHNAJIBLBK<AKJMODAIHHM> APDDGNGPBHM, ANHNAJIBLBK<TMRequest> JKNLDJANAJD, TAction KOMGLJOLBFC, Task DMIMJBAHFLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4DB2810", Offset = "0x4DB1A10", VA = "0x184DB2810")]
	[AsyncStateMachine(typeof(OGJEMOCGNGN<, , , , , , , , >.BFEDKAGLEEF))]
	private Task NEDHFHMIOEF(TRoot DONMCNODAED, TNetSys FJAELENBHMI, TReceiver LFLGFFHCMEJ, TAction KOMGLJOLBFC, JGIEMOIDBOJ AMDOEMFLCJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4DB0570", Offset = "0x4DAF770", VA = "0x184DB0570")]
	private void ALJGHECJLAP(TReceiver LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4DB1460", Offset = "0x4DB0660", VA = "0x184DB1460")]
	private void JMFKLIDMJCC(TRoot DONMCNODAED, TNetSys FJAELENBHMI, TReceiver LFLGFFHCMEJ, ANHNAJIBLBK<AKJMODAIHHM> APDDGNGPBHM, TAction KOMGLJOLBFC, bool OCLNPIPONGN, bool OMBBKGFHLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4DB0B30", Offset = "0x4DAFD30", VA = "0x184DB0B30")]
	[AsyncStateMachine(typeof(OGJEMOCGNGN<, , , , , , , , >.FPKBCMBPICA))]
	public Task FOMPDABBLPE(TRoot DONMCNODAED, TNetSys FJAELENBHMI, ANHNAJIBLBK<AKJMODAIHHM> APDDGNGPBHM, TAction[] MFFCHHFKDEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class FHADEGJBDFM
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface MFDCCLJBDBF<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int OBMGHINPMMA(TNetSys MCKMDFNNJAO, TAction KOMGLJOLBFC);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction FMHNLBIJCID(TNetSys MCKMDFNNJAO, TAction KOMGLJOLBFC);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction OAPPIJMPIOC(TNetSys MCKMDFNNJAO, TAction KOMGLJOLBFC);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> MNKMLKAENBA(TNetSys MCKMDFNNJAO, TAction KOMGLJOLBFC);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] PLEKHILGIEK(TNetSys MCKMDFNNJAO, TAction KOMGLJOLBFC, int JGGMFAOHDMH);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool MPHGHCMPDFK(TNetSys MCKMDFNNJAO, TAction KOMGLJOLBFC);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool HFLMCELKABM(TNetSys MCKMDFNNJAO, TAction KOMGLJOLBFC);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool EFNNOHFJNOH(TNetSys MCKMDFNNJAO, TAction KOMGLJOLBFC);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool CJCJMDKOFBF(TNetSys MCKMDFNNJAO, TAction KOMGLJOLBFC);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool PKONFMBJMIA(TNetSys MCKMDFNNJAO, TAction KOMGLJOLBFC);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool AIENDFOFIKC(TNetSys MCKMDFNNJAO, TAction KOMGLJOLBFC);
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface CBKGAJAAJLD<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TActionDeps BHHDAMKOAPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TReceiverDeps MJBHCICKEBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		TRootDeps LPHCJPNLFDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface MNBEIFBBPMF<TAction, TReceiver> where TAction : notnull where TReceiver : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ANHNAJIBLBK<AKJMODAIHHM> BBDMMLDCEOJ(TReceiver LFLGFFHCMEJ);

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ENKIEPGDJHE(TReceiver LFLGFFHCMEJ);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<EBOICGKKPAM<object, LKEBDJCDIFL>> GKHIPAFGJIF(TReceiver LFLGFFHCMEJ, TAction KOMGLJOLBFC);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TAction[] GPPEHGEIEDL(TReceiver LFLGFFHCMEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface OLNONLDMPAO<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int KKFLKOAHPGL(TRoot DONMCNODAED);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int GBELDLFAILN(TRoot DONMCNODAED);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int JOPHCFGCDCI(TRoot DONMCNODAED);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int ACJLGMBNHHH(TRoot DONMCNODAED);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void FIJLBGINNCI(TRoot DONMCNODAED);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool GOLDGCIGJME(TRoot DONMCNODAED, ANHNAJIBLBK<AKJMODAIHHM> APDDGNGPBHM, TAction[] MPDFABPCMPJ);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task KLHCENHFAPI(TRoot DONMCNODAED, ANHNAJIBLBK<AKJMODAIHHM> APDDGNGPBHM, ANHNAJIBLBK<TMRequest> JKNLDJANAJD, TAction KOMGLJOLBFC, bool HFPCNJDJLDD = true);
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
