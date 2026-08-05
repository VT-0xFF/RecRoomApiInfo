using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom;
using RecRoom.Components;
using RecRoom.DataLayer;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation.Mathematics;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _LogRegistration.RecRoom_ObjectModel_RendererV1_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : DHBOPDJGFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8710BA0", Offset = "0x870F1A0", VA = "0x188710BA0", Slot = "4")]
		public override void NCEHDCEOICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ObjectModel_RendererV1_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x86C1170", Offset = "0x86BF770", VA = "0x1886C1170", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8719250", Offset = "0x8717850", VA = "0x188719250")]
		private void BFHOJBJGDPP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x87197F0", Offset = "0x8717DF0", VA = "0x1887197F0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8719850", Offset = "0x8717E50", VA = "0x188719850")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class OFGEJEPLMAL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8713C20", Offset = "0x8712220", VA = "0x188713C20")]
	public static Quaternion KOGNJLHKGGB([In] this FOPMNDNHIJK JEDFFEPHGNF, [In] Vector3 JPDMHOCEDGB)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class CIJGMBGBOPO
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x86FB8F0", Offset = "0x86F9EF0", VA = "0x1886FB8F0")]
	public static bool AMADDLNPKAP(this CJNCELCCODB CDGMNFKFLKC, LIJKMCLPLEC NLFMOKELAPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x86FCE50", Offset = "0x86FB450", VA = "0x1886FCE50")]
	public static bool INDAEFODLGM(this CJNCELCCODB CDGMNFKFLKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x86FB8C0", Offset = "0x86F9EC0", VA = "0x1886FB8C0")]
	public static bool AFDODDIHACH(this CJNCELCCODB CDGMNFKFLKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x86FD040", Offset = "0x86FB640", VA = "0x1886FD040")]
	public static void MBPKOPFHOBL(this CJNCELCCODB CDGMNFKFLKC, Vector3 LAIKPFBHJPF, Quaternion BHHKLOGNCDO, float JPNOJNLEGJO, bool BJIOMNMDJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x86FB930", Offset = "0x86F9F30", VA = "0x1886FB930")]
	public static void BFOAOGCIIJN(this CJNCELCCODB CDGMNFKFLKC, Vector3 LAIKPFBHJPF, Quaternion BHHKLOGNCDO, float JPNOJNLEGJO, int BGCKPLECKGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x86FBF70", Offset = "0x86FA570", VA = "0x1886FBF70")]
	public static void FDAJBBLKBEK(this CJNCELCCODB CDGMNFKFLKC, int BGCKPLECKGM, Vector3 LAIKPFBHJPF, Quaternion BHHKLOGNCDO, float JPNOJNLEGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x86FCE00", Offset = "0x86FB400", VA = "0x1886FCE00")]
	public static void IAGDIGCKCHG(this CJNCELCCODB CDGMNFKFLKC, Vector3 JBIIDINIOKF, Quaternion DPLIGKEMLHE, float JPNOJNLEGJO, bool BJIOMNMDJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x86FC090", Offset = "0x86FA690", VA = "0x1886FC090")]
	private static void FHKNGGAKLFE(this CJNCELCCODB CDGMNFKFLKC, Vector3 APHHGJIDDCM, Quaternion LDAEEKEKDJC, float JPNOJNLEGJO, bool BJIOMNMDJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x86FCE80", Offset = "0x86FB480", VA = "0x1886FCE80")]
	private static void KIEONDLLHFO(this CJNCELCCODB CDGMNFKFLKC, Vector3 GDEKJEBPHAB, Quaternion JJIKKLJGABK, float JNGCLPFLICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x86FC9F0", Offset = "0x86FAFF0", VA = "0x1886FC9F0")]
	private static void FOJCOOBFGEF(this CJNCELCCODB CDGMNFKFLKC, int PMIGBJGNLLP, Vector3 GDEKJEBPHAB, Quaternion JJIKKLJGABK, float JNGCLPFLICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x86FD170", Offset = "0x86FB770", VA = "0x1886FD170")]
	private static bool ODJFHHBJOBH(this CJNCELCCODB CDGMNFKFLKC, int PMIGBJGNLLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x86FBBC0", Offset = "0x86FA1C0", VA = "0x1886FBBC0")]
	private static void CDDBJBAJAHM(this CJNCELCCODB CDGMNFKFLKC, int PMIGBJGNLLP, Vector3 GDEKJEBPHAB, Quaternion JJIKKLJGABK, float JNGCLPFLICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x86FD1A0", Offset = "0x86FB7A0", VA = "0x1886FD1A0")]
	public static Vector3 OEFBNPACJDM(this CJNCELCCODB CDGMNFKFLKC, int PMIGBJGNLLP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x86FBE60", Offset = "0x86FA460", VA = "0x1886FBE60")]
	public static Quaternion CEHMIGOHPAM(this CJNCELCCODB CDGMNFKFLKC, int PMIGBJGNLLP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x86FCBE0", Offset = "0x86FB1E0", VA = "0x1886FCBE0")]
	public static Vector3 HEDJNKEMEBC(LIJKMCLPLEC ANBGOGICGFD, Vector3 APHHGJIDDCM, Vector3? PABEGNPLLOD, Vector3 MIFKFCAJJIH)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface HBNMJANEAEH
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AECGNDOAEFI(EntityQuery PHFHKEANJCK, EntityManager OLNPNJLIAFG, JILHBDOFIBK AJLGIFGJLEI, ALJFHENHFCN KMGEPHAACIC);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface JAAHFNPLPFN
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType EIOBNPOBINB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ICEPOCHLJKI(EntityQuery PHFHKEANJCK, DIBJFLJJFNO AMGDJGGJAOG);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void POELBGJNCCA(EntityQuery PHFHKEANJCK, DIBJFLJJFNO AMGDJGGJAOG);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AAPIDKCKIJG(DIBJFLJJFNO AMGDJGGJAOG);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class JALLBKINLEJ : HBNMJANEAEH
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x870E590", Offset = "0x870CB90", VA = "0x18870E590", Slot = "4")]
	public void AECGNDOAEFI(EntityQuery PHFHKEANJCK, EntityManager OLNPNJLIAFG, JILHBDOFIBK AJLGIFGJLEI, ALJFHENHFCN KMGEPHAACIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public JALLBKINLEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class PNANKBOBFKE : HBNMJANEAEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly PDPGAAFEJAL JLKFCEIEICE;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
	public PNANKBOBFKE(PDPGAAFEJAL JLKFCEIEICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8714A60", Offset = "0x8713060", VA = "0x188714A60", Slot = "4")]
	public void AECGNDOAEFI(EntityQuery PHFHKEANJCK, EntityManager OLNPNJLIAFG, JILHBDOFIBK AJLGIFGJLEI, ALJFHENHFCN KMGEPHAACIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class LMNGJOFONMA : HBNMJANEAEH
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8710670", Offset = "0x870EC70", VA = "0x188710670", Slot = "4")]
	public void AECGNDOAEFI(EntityQuery PHFHKEANJCK, EntityManager OLNPNJLIAFG, JILHBDOFIBK AJLGIFGJLEI, ALJFHENHFCN KMGEPHAACIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public LMNGJOFONMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class LGOBBNLKINF : JAAHFNPLPFN
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType EIOBNPOBINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x870FE40", Offset = "0x870E440", VA = "0x18870FE40", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x870FBC0", Offset = "0x870E1C0", VA = "0x18870FBC0", Slot = "5")]
	public void ICEPOCHLJKI(EntityQuery PHFHKEANJCK, DIBJFLJJFNO AMGDJGGJAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x870FE70", Offset = "0x870E470", VA = "0x18870FE70", Slot = "6")]
	public void POELBGJNCCA(EntityQuery PHFHKEANJCK, DIBJFLJJFNO AMGDJGGJAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x870FB70", Offset = "0x870E170", VA = "0x18870FB70", Slot = "7")]
	public void AAPIDKCKIJG(DIBJFLJJFNO AMGDJGGJAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public LGOBBNLKINF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class AJOLJBBFKJN : JAAHFNPLPFN
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType EIOBNPOBINB
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x86FAD90", Offset = "0x86F9390", VA = "0x1886FAD90", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x86FAB10", Offset = "0x86F9110", VA = "0x1886FAB10", Slot = "5")]
	public void ICEPOCHLJKI(EntityQuery PHFHKEANJCK, DIBJFLJJFNO AMGDJGGJAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x86FADC0", Offset = "0x86F93C0", VA = "0x1886FADC0", Slot = "6")]
	public void POELBGJNCCA(EntityQuery PHFHKEANJCK, DIBJFLJJFNO AMGDJGGJAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x86FAAC0", Offset = "0x86F90C0", VA = "0x1886FAAC0", Slot = "7")]
	public void AAPIDKCKIJG(DIBJFLJJFNO AMGDJGGJAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public AJOLJBBFKJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class LKFNLEGGPPC : JAAHFNPLPFN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType EIOBNPOBINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x87103C0", Offset = "0x870E9C0", VA = "0x1887103C0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8710140", Offset = "0x870E740", VA = "0x188710140", Slot = "5")]
	public void ICEPOCHLJKI(EntityQuery PHFHKEANJCK, DIBJFLJJFNO AMGDJGGJAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x87103F0", Offset = "0x870E9F0", VA = "0x1887103F0", Slot = "6")]
	public void POELBGJNCCA(EntityQuery PHFHKEANJCK, DIBJFLJJFNO AMGDJGGJAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x87100F0", Offset = "0x870E6F0", VA = "0x1887100F0", Slot = "7")]
	public void AAPIDKCKIJG(DIBJFLJJFNO AMGDJGGJAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public LKFNLEGGPPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class ONOHEKJAKJD : CJOAGKPBBIM, MOLBKPMFEIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private JILHBDOFIBK AJLGIFGJLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private PMPEPOCCAFE LMJGGGBPHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private ALJFHENHFCN KMGEPHAACIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, HBNMJANEAEH adapter)> POBHILGOOHP;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8713D00", Offset = "0x8712300", VA = "0x188713D00", Slot = "15")]
	public virtual void InitReferences(CNPFBIMHGJN KADNKCJPKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8713EF0", Offset = "0x87124F0", VA = "0x188713EF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8713D90", Offset = "0x8712390", VA = "0x188713D90")]
	private void LNKLLBOHDAO(EntityQueryDesc KJLEAIPIPLJ, HBNMJANEAEH ALFIKHHGDGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8714120", Offset = "0x8712720", VA = "0x188714120", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2E01C10", Offset = "0x2E00210", VA = "0x182E01C10")]
	public ONOHEKJAKJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class HDHKNMMNPKK : CJOAGKPBBIM, MOLBKPMFEIO
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class CEEPEIMJHNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery HACMNIBIJBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery MLFMOHJLEAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery GLLBHLKABGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery AFHCAJHNKJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery AKOGMLHGIMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EntityQuery AACPNICGPOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EntityQuery JCHJBMOHFDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public JAAHFNPLPFN JEHJBKHCOEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ComponentType NGJPNGCAJLG;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public CEEPEIMJHNF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private JILHBDOFIBK AJLGIFGJLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private ALJFHENHFCN KMGEPHAACIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private PMPEPOCCAFE LMJGGGBPHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<CEEPEIMJHNF> POBHILGOOHP;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x870CC00", Offset = "0x870B200", VA = "0x18870CC00", Slot = "14")]
	public void InitReferences(CNPFBIMHGJN KADNKCJPKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x870D3C0", Offset = "0x870B9C0", VA = "0x18870D3C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x870D540", Offset = "0x870BB40", VA = "0x18870D540", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x870C7B0", Offset = "0x870ADB0", VA = "0x18870C7B0")]
	private void FINAJFOHLCD(CEEPEIMJHNF FJOHLHNOGNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x870CC90", Offset = "0x870B290", VA = "0x18870CC90")]
	private void LNKLLBOHDAO(JAAHFNPLPFN JEHJBKHCOEO, ComponentType KEHCIPNLGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2E01C10", Offset = "0x2E00210", VA = "0x182E01C10")]
	public HDHKNMMNPKK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14336554891096525153uL)]
internal struct IOGGIEMOFCI : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(3939343835747908767uL)]
internal struct NEGCPCDIFEE : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(9697228609905595395uL)]
internal struct JCELOHABBCO : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(ALJFHENHFCN), new string[] { })]
public class JKCNKEGFCGC : ALJFHENHFCN
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public POFMKFJLMNC HPOIAHGNKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(POFMKFJLMNC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xAA7130", Offset = "0xAA5730", VA = "0x180AA7130", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public JKCNKEGFCGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(OPLNFCMNMMB), new string[] { })]
public class PNBLPNEKGHH : OPLNFCMNMMB, FPBNALNJMPD, HDIEJMEDAEI, GDKFLICGOLD, DCEPPCNEFDI, HKPOOEHKBFO, PFDHPBBBFAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[DependsOn]
	private EPCIOFAAGGG LGOKMFFDOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[DependsOn]
	private JILHBDOFIBK AJLGIFGJLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[DependsOn]
	private HNBHNOBANOG MIKGDJBNCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private EntityQuery LKIFBNAFCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private EntityQuery DBOHILHGOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private bool OIJPENJFFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Entity HAFBDCLGDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private HELGAKOMGEN LIOMDMMHAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private Entity BKLAOJJFODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private HELGAKOMGEN FGEMCFBMILG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private EntityManager ACKHPMIHGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8714BD0", Offset = "0x87131D0", VA = "0x188714BD0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int NHJDPOJGLIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8714BB0", Offset = "0x87131B0", VA = "0x188714BB0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int DMPLLALCLOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8714C20", Offset = "0x8713220", VA = "0x188714C20", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x87155F0", Offset = "0x8713BF0", VA = "0x1887155F0", Slot = "4")]
	public bool OHBHFCFNDFN(NLPLHJLLGBB BJCKBJFHLNJ, MKIABNBOMIK KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8714CD0", Offset = "0x87132D0", VA = "0x188714CD0", Slot = "5")]
	public HELGAKOMGEN FGGPAOOLICP()
	{
		return default(HELGAKOMGEN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8715150", Offset = "0x8713750", VA = "0x188715150", Slot = "6")]
	public HELGAKOMGEN NAPEIMAPLHI()
	{
		return default(HELGAKOMGEN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8714FD0", Offset = "0x87135D0", VA = "0x188714FD0", Slot = "9")]
	public void InitExternal(CNPFBIMHGJN KADNKCJPKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8714F90", Offset = "0x8713590", VA = "0x188714F90", Slot = "11")]
	public void HDAIJOIMLPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8715410", Offset = "0x8713A10", VA = "0x188715410", Slot = "10")]
	public void NFMEFBHMJAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8714C40", Offset = "0x8713240", VA = "0x188714C40", Slot = "12")]
	private void CMMNFFLCJOL(CNPFBIMHGJN KADNKCJPKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1396E60", Offset = "0x1395460", VA = "0x181396E60", Slot = "13")]
	private void GCOCFFJOAJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public PNBLPNEKGHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(AJKMEGNPKGN), new string[] { })]
public class DNAOEFGBCCD : AJKMEGNPKGN
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x87014D0", Offset = "0x86FFAD0", VA = "0x1887014D0", Slot = "4")]
	public void ADNAAADAJBN(World LGOKMFFDOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8701F20", Offset = "0x8700520", VA = "0x188701F20", Slot = "5")]
	public void IOFOKMOMIKJ(World LGOKMFFDOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8701E70", Offset = "0x8700470", VA = "0x188701E70", Slot = "6")]
	public ComponentSystemBase DCKIEDKKKNH(World LGOKMFFDOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8701EC0", Offset = "0x87004C0", VA = "0x188701EC0", Slot = "7")]
	public void DPLFLGGDFBN(World LGOKMFFDOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8701DB0", Offset = "0x87003B0", VA = "0x188701DB0", Slot = "8")]
	public void AIFNCJAHCEH(World LGOKMFFDOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8701E10", Offset = "0x8700410", VA = "0x188701E10", Slot = "9")]
	public void CDFIIAPBIJP(World LGOKMFFDOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8701F70", Offset = "0x8700570", VA = "0x188701F70", Slot = "10")]
	public void NIDJCHOPLJP(World LGOKMFFDOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8701550", Offset = "0x86FFB50", VA = "0x188701550", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> AFNLJHADIPB()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public DNAOEFGBCCD()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(8022771283198464153uL)]
public struct EBFPLLOIBND : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(7787318400023670087uL)]
public struct BPHDGDCGELI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class HKJKOCGOICD : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public AEDDAMMOMOG EEDNFNHNLGH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x870D850", Offset = "0x870BE50", VA = "0x18870D850", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x870D7E0", Offset = "0x870BDE0", VA = "0x18870D7E0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public HKJKOCGOICD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(9578575130884295287uL)]
public struct IBLOPDEMJHL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public HELGAKOMGEN IDCDANGOGFJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xE29190", Offset = "0xE27790", VA = "0x180E29190")]
	public static IBLOPDEMJHL HNGLNPFKABH(HELGAKOMGEN MNHLJANEAIO)
	{
		return default(IBLOPDEMJHL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class IMGDMOFBEJL : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public BGGCMEGDEOC CDJLDCHGCAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x870E520", Offset = "0x870CB20", VA = "0x18870E520", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public IMGDMOFBEJL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(10815538147163088674uL)]
public struct JBIGFGBMJGL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(10815538147163088675uL)]
public struct IFBAAACLHGG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(10245696125477899514uL)]
public struct EMIHHCFMFJC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public LEFLGOLACFG FGECICEBNAB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xE29190", Offset = "0xE27790", VA = "0x180E29190")]
	public static EMIHHCFMFJC HNGLNPFKABH(LEFLGOLACFG MNHLJANEAIO)
	{
		return default(EMIHHCFMFJC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[TypeManager.ForcedStableTypeHash(10129251117493878592uL)]
public struct LGAOHJKLDBH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public HELGAKOMGEN IDCDANGOGFJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xE29190", Offset = "0xE27790", VA = "0x180E29190")]
	public static LGAOHJKLDBH HNGLNPFKABH(HELGAKOMGEN MNHLJANEAIO)
	{
		return default(LGAOHJKLDBH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class BIDIPKEIOIP : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public GHJEGHHKFLP NIPAOEDAEGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x86FB0B0", Offset = "0x86F96B0", VA = "0x1886FB0B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x86FB040", Offset = "0x86F9640", VA = "0x1886FB040", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public BIDIPKEIOIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class AHACIGOGIPN : KDPIFBOJBIH, AEDDAMMOMOG, EHINNOKAEPA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public CODBDPNCDGJ OMLBHFIFGGM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xEC0BF0", Offset = "0xEBF1F0", VA = "0x180EC0BF0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(CODBDPNCDGJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool JIDHOOOFBDC
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xD841F0", Offset = "0xD827F0", VA = "0x180D841F0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public float3 LBOBHJEFGFF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x12C0AB0", Offset = "0x12BF0B0", VA = "0x1812C0AB0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x86F9B80", Offset = "0x86F8180", VA = "0x1886F9B80")]
	public AHACIGOGIPN(UniformTRS MBPHPALMDGK, CENLKEFEGPJ BEBONNCPGLF, float ALMPJNHAKPD, float3 AJAMNFHAHLE, IDOKBCEFAKB IFGENIMDOCD, FBDPDFJNLFK GILIOJADFHA, CODBDPNCDGJ FAAACGBLHKP, float3 CCJOGIFAANG, bool EHCINKFBHKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x86F9B20", Offset = "0x86F8120", VA = "0x1886F9B20", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class NCLDLJOKOMA : KDPIFBOJBIH, GHJEGHHKFLP, EHINNOKAEPA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeArray<KMFOEBEFONO> KDILADLDOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly OMDLOEFKMLN ENMBHGMENHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly float IJOIECLMJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly int LJFDFBCCDEM;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool NIAIKODDALN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8711A00", Offset = "0x8710000", VA = "0x188711A00", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool BNELHJIHEEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8711A20", Offset = "0x8710020", VA = "0x188711A20", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool ABDJDENNPCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8711A10", Offset = "0x8710010", VA = "0x188711A10", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int GILIKINABOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xC51180", Offset = "0xC4F780", VA = "0x180C51180", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float JFBOACLEGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xE36840", Offset = "0xE34E40", VA = "0x180E36840", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int IDDNLFFCBHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xE3C560", Offset = "0xE3AB60", VA = "0x180E3C560", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8711960", Offset = "0x870FF60", VA = "0x188711960")]
	public NCLDLJOKOMA(UniformTRS MBPHPALMDGK, CENLKEFEGPJ BEBONNCPGLF, float ALMPJNHAKPD, float3 AJAMNFHAHLE, IDOKBCEFAKB IFGENIMDOCD, FBDPDFJNLFK GILIOJADFHA, OMDLOEFKMLN ENMBHGMENHL, float IJOIECLMJLL, int LJFDFBCCDEM, NativeArray<KMFOEBEFONO> KDILADLDOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x12D5680", Offset = "0x12D3C80", VA = "0x1812D5680", Slot = "33")]
	public NativeArray<KMFOEBEFONO> GetNativeCurvePoints()
	{
		return default(NativeArray<KMFOEBEFONO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8711890", Offset = "0x870FE90", VA = "0x188711890", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class DMKBKOEHEAF : LOLDGBCLNDK, AEDDAMMOMOG, EHINNOKAEPA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static readonly Dictionary<PINBFOAJNAG, CODBDPNCDGJ> KCCLJILDPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private CODBDPNCDGJ FAAACGBLHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private bool EHCINKFBHKD;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private CODBDPNCDGJ KPEPOLBJBEE
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAC5000", Offset = "0xAC3600", VA = "0x180AC5000", Slot = "28")]
		get
		{
			return default(CODBDPNCDGJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private bool JFOEBJEECLE
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xFE10B0", Offset = "0xFDF6B0", VA = "0x180FE10B0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public float3 LBOBHJEFGFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8701410", Offset = "0x86FFA10", VA = "0x188701410", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x87013F0", Offset = "0x86FF9F0", VA = "0x1887013F0")]
	public DMKBKOEHEAF(NLPLHJLLGBB IIIJIBCGHEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8700D60", Offset = "0x86FF360", VA = "0x188700D60", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8700DB0", Offset = "0x86FF3B0", VA = "0x188700DB0", Slot = "26")]
	public override void FPGILMIKMIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class PEHLKADMAON : PICOPAAAHHF, BGGCMEGDEOC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private GameObject NMLLILKEPNL;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public GameObject HPNHKENLPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8714490", Offset = "0x8712A90", VA = "0x188714490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ACLDACCHLEI JJKHGJPALLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8714520", Offset = "0x8712B20", VA = "0x188714520", Slot = "15")]
		get
		{
			return default(ACLDACCHLEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public KGLLFOFKIGH HKNCFLALFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8714900", Offset = "0x8712F00", VA = "0x188714900", Slot = "16")]
		get
		{
			return default(KGLLFOFKIGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x87147B0", Offset = "0x8712DB0", VA = "0x1887147B0")]
	public PEHLKADMAON(NLPLHJLLGBB BJCKBJFHLNJ, bool EGIKIDFLOHP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8714620", Offset = "0x8712C20", VA = "0x188714620")]
	public void MLMGKDIFCAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8714520", Offset = "0x8712B20", VA = "0x188714520")]
	protected ACLDACCHLEI HKDJCIOOGCA()
	{
		return default(ACLDACCHLEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8714310", Offset = "0x8712910", VA = "0x188714310")]
	private static bool CEABKNCDIPD(NLPLHJLLGBB CNPIFIIPICN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8714460", Offset = "0x8712A60", VA = "0x188714460", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class NBPMMOGMAGH : LOLDGBCLNDK, GHJEGHHKFLP, EHINNOKAEPA, IDisposable, BBLLJDDJMAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeList<KMFOEBEFONO> KDILADLDOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private bool HGLLBICNOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool GPMECHFIJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private float IJOIECLMJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private int LJFDFBCCDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private bool PNPHMOBGLCO;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool IACJBOFKKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xDB20C0", Offset = "0xDB06C0", VA = "0x180DB20C0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool BCFEEGDKONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAF3190", Offset = "0xAF1790", VA = "0x180AF3190", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private float CMNAMAHHEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xF50410", Offset = "0xF4EA10", VA = "0x180F50410", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int DIDMLIDCGBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xEC0BF0", Offset = "0xEBF1F0", VA = "0x180EC0BF0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private bool BGHAFBJIFJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xD841F0", Offset = "0xD827F0", VA = "0x180D841F0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private int DHMLENLENNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8711680", Offset = "0x870FC80", VA = "0x188711680", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private int MJDDBPFOMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8711090", Offset = "0x870F690", VA = "0x188711090", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8711860", Offset = "0x870FE60", VA = "0x188711860")]
	public NBPMMOGMAGH(NLPLHJLLGBB IIIJIBCGHEO, [Optional] NativeList<KMFOEBEFONO> KDILADLDOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8711290", Offset = "0x870F890", VA = "0x188711290", Slot = "26")]
	public override void FPGILMIKMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8710FA0", Offset = "0x870F5A0", VA = "0x188710FA0", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x87111D0", Offset = "0x870F7D0", VA = "0x1887111D0", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8711170", Offset = "0x870F770", VA = "0x188711170")]
	public void DNFDNBLOFGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x87114B0", Offset = "0x870FAB0", VA = "0x1887114B0", Slot = "34")]
	public NativeArray<KMFOEBEFONO> GetNativeCurvePoints()
	{
		return default(NativeArray<KMFOEBEFONO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8711370", Offset = "0x870F970", VA = "0x188711370", Slot = "35")]
	private Vector3 GPNBMDLFOMD(int IFMKBBDLCHB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x87116A0", Offset = "0x870FCA0", VA = "0x1887116A0", Slot = "36")]
	private Quaternion LPGCBFKBKNL(int IFMKBBDLCHB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x87116D0", Offset = "0x870FCD0", VA = "0x1887116D0", Slot = "37")]
	private float NFCEOLDCDEH(int IFMKBBDLCHB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8711230", Offset = "0x870F830", VA = "0x188711230")]
	private NativeArray<Entity> FIDBNJNEFBE()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class NJDGHNBKIEK : ALHCLOPIKIN
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8711AC0", Offset = "0x87100C0", VA = "0x188711AC0", Slot = "15")]
	protected override ComponentSystemBase AAECNIONPMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8711F30", Offset = "0x8710530", VA = "0x188711F30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8711F40", Offset = "0x8710540", VA = "0x188711F40")]
	public NJDGHNBKIEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[HFDKPBJCCLL]
public sealed class JFENELNKGCL : FNBFBEOHNGB
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private EntityQuery KPKMOPKMOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery JLIJLKJOICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityQuery EOEMALILIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private EntityQuery HHNJNNBJMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private EntityQuery LJNPPLMDHGC;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x870F180", Offset = "0x870D780", VA = "0x18870F180", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x870F4E0", Offset = "0x870DAE0", VA = "0x18870F4E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x870EAC0", Offset = "0x870D0C0", VA = "0x18870EAC0")]
	private void AGDNIPLPFLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x870ED50", Offset = "0x870D350", VA = "0x18870ED50")]
	private void GFBFOCDDHMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x870EF60", Offset = "0x870D560", VA = "0x18870EF60")]
	private void JJLIFCFFKMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x870F520", Offset = "0x870DB20", VA = "0x18870F520")]
	private void POPFHIMELLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x870EE60", Offset = "0x870D460", VA = "0x18870EE60")]
	private void JDNGPIHNOND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x870ED00", Offset = "0x870D300", VA = "0x18870ED00")]
	private NativeList<Entity> EHLPPOCIEKF(NativeArray<Entity> MEJIKACDFLB)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x870F130", Offset = "0x870D730", VA = "0x18870F130")]
	private NativeList<Entity> JPHPNIIPJNI(NativeArray<Entity> MEJIKACDFLB)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x870ECA0", Offset = "0x870D2A0", VA = "0x18870ECA0")]
	private void BIMAKOCBLAJ(NativeArray<Entity> MEJIKACDFLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x30C90C0", Offset = "0x30C76C0", VA = "0x1830C90C0")]
	public JFENELNKGCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[HFDKPBJCCLL]
public sealed class NKJKHPCDKLI : FNBFBEOHNGB, MOLBKPMFEIO
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EntityQuery LHHHNPMLGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EntityQuery BHANIOKNDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EntityQuery GLLBHLKABGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private OPLNFCMNMMB PBNHPIIKCGI;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8713670", Offset = "0x8711C70", VA = "0x188713670", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8713250", Offset = "0x8711850", VA = "0x188713250", Slot = "15")]
	public override void InitReferences(CNPFBIMHGJN KADNKCJPKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8713840", Offset = "0x8711E40", VA = "0x188713840", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8712890", Offset = "0x8710E90", VA = "0x188712890")]
	private void HOOKGONPGIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8712200", Offset = "0x8710800", VA = "0x188712200")]
	private void FMKMEOHJBCM(NativeParallelHashSet<HELGAKOMGEN> NEPJGLPLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x8712BC0", Offset = "0x87111C0", VA = "0x188712BC0")]
	private void IHFOLCBGCKC(NativeParallelHashSet<HELGAKOMGEN> NEPJGLPLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x87132B0", Offset = "0x87118B0", VA = "0x1887132B0")]
	private void KPJHFAALDAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8712160", Offset = "0x8710760", VA = "0x188712160")]
	private bool FCJEAPAKAEF(Entity JAPNANJIKLB, [Out] HELGAKOMGEN IDCDANGOGFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8711F50", Offset = "0x8710550", VA = "0x188711F50")]
	internal bool ENPCKIABMML(Entity JAPNANJIKLB, [Out] HELGAKOMGEN IDCDANGOGFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x30C90C0", Offset = "0x30C76C0", VA = "0x1830C90C0")]
	public NKJKHPCDKLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[HFDKPBJCCLL]
public sealed class GPPAHNMINDF : FNBFBEOHNGB
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EntityQuery HMPKANNPHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EntityQuery OPJHNKNAOBI;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8707820", Offset = "0x8705E20", VA = "0x188707820", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8707970", Offset = "0x8705F70", VA = "0x188707970", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8707230", Offset = "0x8705830", VA = "0x188707230")]
	private void FMKMEOHJBCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8707530", Offset = "0x8705B30", VA = "0x188707530")]
	private void IHFOLCBGCKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x30C90C0", Offset = "0x30C76C0", VA = "0x1830C90C0")]
	public GPPAHNMINDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class IADKEODMKOM : FNBFBEOHNGB, MOLBKPMFEIO
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[BurstCompile]
	private struct FFGJBLAELOF : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EntityQueryInJob EAALAMFONPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public EntityQueryInJob AJBIKNBNCLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public EntityQueryInJob HHKLOKALNLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public EntityQueryInJob HAKGPNIOKGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[ReadOnly]
		public EntityTypeHandle JPKMJHDIICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[ReadOnly]
		public ComponentTypeHandle<LGAOHJKLDBH> CKAJKFEFBCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public NativeParallelHashSet<HELGAKOMGEN> HNABOIDKBJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public NativeList<Entity> DDJIMIJPKMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeList<Entity> FILODGFPLFE;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8707060", Offset = "0x8705660", VA = "0x188707060", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x87070E0", Offset = "0x87056E0", VA = "0x1887070E0")]
		private void KDIELOMACLM(EntityQueryInJob PHFHKEANJCK, NativeList<Entity> JLPDMMMEIFM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private struct AIPDDCODCHF : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[ReadOnly]
		public EntityTypeHandle JPKMJHDIICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[ReadOnly]
		public ComponentTypeHandle<LGAOHJKLDBH> CKAJKFEFBCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public NativeParallelHashSet<HELGAKOMGEN> HNABOIDKBJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeList<Entity> JLPDMMMEIFM;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x86FA880", Offset = "0x86F8E80", VA = "0x1886FA880", Slot = "4")]
		public void Execute(ArchetypeChunk DLAJJAMMDFJ, int FLFDIABNKLA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EntityQuery EAALAMFONPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private EntityQuery AJBIKNBNCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private EntityQuery HHKLOKALNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private EntityQuery HAKGPNIOKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private EntityQuery BAGODDLGPPM;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x870DD30", Offset = "0x870C330", VA = "0x18870DD30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x870E170", Offset = "0x870C770", VA = "0x18870E170", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x870D8A0", Offset = "0x870BEA0", VA = "0x18870D8A0")]
	private void HGLDFFHPGAB(NativeParallelHashSet<HELGAKOMGEN> NEPJGLPLNIG, int IPHAJLBDBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x870D9A0", Offset = "0x870BFA0", VA = "0x18870D9A0")]
	private void NFMEEDHOEJI(NativeParallelHashSet<HELGAKOMGEN> NEPJGLPLNIG, int HHJJHDDFEMA, int NJMLHPAEHBM, int NHCMPOHEMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x30C90C0", Offset = "0x30C76C0", VA = "0x1830C90C0")]
	public IADKEODMKOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class DIGLPFHKOGB : FNBFBEOHNGB
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[BurstCompile]
	private struct JBBLBCDPPJD : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[ReadOnly]
		public EntityTypeHandle JPKMJHDIICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> NDGDEMIFJNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[ReadOnly]
		public ComponentTypeHandle<EMIHHCFMFJC> AJLDOPNFLFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[ReadOnly]
		public ComponentDataFromEntity<IBLOPDEMJHL> ENALCIMBGLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[ReadOnly]
		public ComponentDataFromEntity<global::KHAIHLMIJBJ> EJKEHBECFOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public ComponentTypeHandle<LGAOHJKLDBH> CCEKHJAECIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeParallelHashSet<HELGAKOMGEN> HNABOIDKBJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeList<Entity> BBNJHFPFMHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeList<EMIHHCFMFJC> MAFPKGELAGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeList<HELGAKOMGEN> OLCJGBLICMM;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x870E7A0", Offset = "0x870CDA0", VA = "0x18870E7A0", Slot = "4")]
		public void Execute(ArchetypeChunk DLAJJAMMDFJ, int FLFDIABNKLA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private EntityQuery DHCEOEADNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private EntityQuery ECEFPDBHOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private EntityQuery AIPIMEDAPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private EntityQuery NOEBAPPAHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private EntityQuery IANGFOPHAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private OPLNFCMNMMB IGOJJFGODFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private NKJKHPCDKLI MLFKDOHDGAI;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x86FF420", Offset = "0x86FDA20", VA = "0x1886FF420", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x86FE1F0", Offset = "0x86FC7F0", VA = "0x1886FE1F0", Slot = "15")]
	public override void InitReferences(CNPFBIMHGJN KADNKCJPKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x86FF810", Offset = "0x86FDE10", VA = "0x1886FF810", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x86FEC90", Offset = "0x86FD290", VA = "0x1886FEC90")]
	private void NGKCENPFLEP(NativeParallelHashSet<HELGAKOMGEN> HNABOIDKBJC, int KCPBAMLOLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x86FDDA0", Offset = "0x86FC3A0", VA = "0x1886FDDA0")]
	private void HLDOIHIPFBB(NativeParallelHashSet<HELGAKOMGEN> HNABOIDKBJC, int LOOFIALHNAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x86FE860", Offset = "0x86FCE60", VA = "0x1886FE860")]
	private void NCCMHMIAMNI(NativeParallelHashSet<HELGAKOMGEN> HNABOIDKBJC, int LDOFDCHLPNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x86FE250", Offset = "0x86FC850", VA = "0x1886FE250")]
	private void JGKJJAOLFME(NativeParallelHashSet<HELGAKOMGEN> HNABOIDKBJC, int KGENFNNOJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x86FD8B0", Offset = "0x86FBEB0", VA = "0x1886FD8B0")]
	private void CODJFBNIABN(NativeParallelHashSet<HELGAKOMGEN> HNABOIDKBJC, int IHNCHDLHDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x86FE6B0", Offset = "0x86FCCB0", VA = "0x1886FE6B0")]
	private void LMMCFDOGHCA(Entity JFDGBDIJMBH, LEFLGOLACFG FHBCLLGBJMB, HELGAKOMGEN IDCDANGOGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x30C90C0", Offset = "0x30C76C0", VA = "0x1830C90C0")]
	public DIGLPFHKOGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class BLDKDDPOIFL : FNBFBEOHNGB
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private EntityQuery CEGAJOFFANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private EntityQuery GELDFFKJIOF;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x86FB100", Offset = "0x86F9700", VA = "0x1886FB100", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x86FB330", Offset = "0x86F9930", VA = "0x1886FB330", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x30C90C0", Offset = "0x30C76C0", VA = "0x1830C90C0")]
	public BLDKDDPOIFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class GPPHDKPGMCP : FNBFBEOHNGB
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[TypeManager.ForcedStableTypeHash(13972172025007325174uL)]
	private struct MFFNFDJMOGL : IComponentData
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private EntityQuery ADHJPABLFPH;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8707A20", Offset = "0x8706020", VA = "0x188707A20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8707B60", Offset = "0x8706160", VA = "0x188707B60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x30C90C0", Offset = "0x30C76C0", VA = "0x1830C90C0")]
	public GPPHDKPGMCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[HFDKPBJCCLL]
internal class AHDLCKIPMML : FNBFBEOHNGB
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private class KLHKBDFMGFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public EntityQuery EAPNINEMHFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public EntityQuery CHKMMCKCEEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public HLINPDFIBPI CJDFFGDGEKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public ComponentType BHGOIKGDBGN;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public KLHKBDFMGFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private delegate void HLINPDFIBPI(NativeArray<LEFLGOLACFG> MNHLJANEAIO, DIBJFLJJFNO AMGDJGGJAOG);

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private List<KLHKBDFMGFC> POBHILGOOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private PMPEPOCCAFE LMJGGGBPHIC;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x86FA100", Offset = "0x86F8700", VA = "0x1886FA100", Slot = "15")]
	public override void InitReferences(CNPFBIMHGJN KADNKCJPKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x86FA160", Offset = "0x86F8760", VA = "0x1886FA160", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x86FA2F0", Offset = "0x86F88F0", VA = "0x1886FA2F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x32FF760", Offset = "0x32FDD60", VA = "0x1832FF760")]
	private void LNKLLBOHDAO<T>(HLINPDFIBPI CJDFFGDGEKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x86F9F60", Offset = "0x86F8560", VA = "0x1886F9F60")]
	private static void IJJJBFCGCHF(NativeArray<LEFLGOLACFG> NMIBJADALJH, DIBJFLJJFNO HCBFEGIBDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x86F9C20", Offset = "0x86F8220", VA = "0x1886F9C20")]
	private static void CMCILNJBPKF(NativeArray<LEFLGOLACFG> NMIBJADALJH, DIBJFLJJFNO HCBFEGIBDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x86F9DC0", Offset = "0x86F83C0", VA = "0x1886F9DC0")]
	private static void DFMHHEMHMDC(NativeArray<LEFLGOLACFG> NMIBJADALJH, DIBJFLJJFNO HCBFEGIBDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x30C90C0", Offset = "0x30C76C0", VA = "0x1830C90C0")]
	public AHDLCKIPMML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[HFDKPBJCCLL]
public sealed class KAIFJBLJKAB : FNBFBEOHNGB
{
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private EntityQuery PHFHKEANJCK;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x870F6B0", Offset = "0x870DCB0", VA = "0x18870F6B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct HLMMJLPHCEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public UniformTRS MBPHPALMDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public StandardRenderableVisualData FKOOMCEIICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public CODBDPNCDGJ FAAACGBLHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float3 CCJOGIFAANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public bool EHCINKFBHKD;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[NKODJCNJPIB(Lifetime.LoadInstance)]
public struct NFFKIABAHEO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Entity BLFJNFOGIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public NativeList<Entity> MEJIKACDFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeList<Entity> GKBKGOHGDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public NativeParallelHashSet<Entity> DMFADOKPNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public NativeList<HLMMJLPHCEO> BAGDPPHLHDB;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8711A30", Offset = "0x8710030", VA = "0x188711A30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[ServiceLifetime(Lifetime.OMRoom)]
[RegisterService(typeof(DJCLOHDLABH), new string[] { })]
internal class DJCLOHDLABH : MOLBKPMFEIO, DCEPPCNEFDI, HKPOOEHKBFO, PFDHPBBBFAF
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public readonly struct DPCCJFICHJP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly DJCLOHDLABH BEBONNCPGLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly bool OIEDHGCKMNA;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x1B0CD90", Offset = "0x1B0B390", VA = "0x181B0CD90")]
		public DPCCJFICHJP(DJCLOHDLABH BEBONNCPGLF, bool OIEDHGCKMNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8701FE0", Offset = "0x87005E0", VA = "0x188701FE0")]
		public Queue<DHALGNEGDIE>.Enumerator ABGODHCJODA()
		{
			return default(Queue<DHALGNEGDIE>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x87020A0", Offset = "0x87006A0", VA = "0x1887020A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[DependsOn]
	private HNBHNOBANOG PFACHOGLMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[DependsOn]
	private LHFLBCKMPKJ ANNKEFOJBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private List<NativeList<KMFOEBEFONO>> OPPBCJCADNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private List<(Entity, List<GameObject>)> CIDEKAJHHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private NativeList<LEFLGOLACFG> LIGGCJGFJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private OIDFDMEJALK<DHALGNEGDIE> FKEGMEEMHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private OIDFDMEJALK<NFFKIABAHEO> DHAPCKPNNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private OIDFDMEJALK<ICMLMHIHEKF> JMEPCKJBAJB;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8700730", Offset = "0x86FED30", VA = "0x188700730", Slot = "4")]
	public void InitReferences(CNPFBIMHGJN KADNKCJPKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8700C10", Offset = "0x86FF210", VA = "0x188700C10")]
	public void PKOBPFAGKPH(NativeList<KMFOEBEFONO> CCHCBDNJBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8700AC0", Offset = "0x86FF0C0", VA = "0x188700AC0")]
	public void OPJJCKPMEJA(Entity BEBONNCPGLF, [In] BEHKKOBPFOO<GameObject> NKKDFNGKKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x86FFC00", Offset = "0x86FE200", VA = "0x1886FFC00")]
	public void CAAFJOHOENH(NativeList<LEFLGOLACFG> NMIBJADALJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x86FFC90", Offset = "0x86FE290", VA = "0x1886FFC90")]
	public void CDFIIAPBIJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x86FFF30", Offset = "0x86FE530", VA = "0x1886FFF30")]
	public void COPDGBDJCFH(EKBBEBOGNCO IHEHADIIJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8700A20", Offset = "0x86FF020", VA = "0x188700A20")]
	public JobHandle OKLELEDKGAL([In] DHALGNEGDIE GKNICJPCIJJ, JobHandle BPIOJMHPPEL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8700980", Offset = "0x86FEF80", VA = "0x188700980")]
	public JobHandle OKLELEDKGAL([In] NFFKIABAHEO GKNICJPCIJJ, JobHandle BPIOJMHPPEL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8383560", Offset = "0x8381B60", VA = "0x188383560")]
	public DPCCJFICHJP MMCHDBMNIEC(bool OIEDHGCKMNA)
	{
		return default(DPCCJFICHJP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8700930", Offset = "0x86FEF30", VA = "0x188700930")]
	public OOKPABLPMDG<NFFKIABAHEO> LIGLBNEOAGB()
	{
		return default(OOKPABLPMDG<NFFKIABAHEO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x87003E0", Offset = "0x86FE9E0", VA = "0x1887003E0")]
	public OOKPABLPMDG<ICMLMHIHEKF> DFJHEKBMKHC()
	{
		return default(OOKPABLPMDG<ICMLMHIHEKF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x8700430", Offset = "0x86FEA30", VA = "0x188700430")]
	public void ELFNJAKNOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8700650", Offset = "0x86FEC50", VA = "0x188700650", Slot = "5")]
	public void HDAIJOIMLPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x86FFEC0", Offset = "0x86FE4C0", VA = "0x1886FFEC0", Slot = "6")]
	private void CMMNFFLCJOL(CNPFBIMHGJN KADNKCJPKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x10354A0", Offset = "0x1033AA0", VA = "0x1810354A0", Slot = "7")]
	private void GCOCFFJOAJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public DJCLOHDLABH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct CLDMJIMJBIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public UniformTRS MBPHPALMDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public StandardRenderableVisualData FKOOMCEIICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public GKJBALMMHEO ENMBHGMENHL;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[NKODJCNJPIB(Lifetime.LoadInstance)]
public struct DHALGNEGDIE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public Entity BLFJNFOGIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public NativeList<Entity> MEJIKACDFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public NativeList<Entity> GKBKGOHGDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public NativeParallelHashSet<Entity> DMFADOKPNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public NativeList<NDDIGIFKAJC> CJCBANNPPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public NativeList<KMFOEBEFONO> CCHCBDNJBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public NativeList<CLDMJIMJBIL> JOONCDGPPMP;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x86FD7D0", Offset = "0x86FBDD0", VA = "0x1886FD7D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x86FD7E0", Offset = "0x86FBDE0", VA = "0x1886FD7E0")]
	public void ELCJDKMDHCB(bool OIEDHGCKMNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[RegisterService(typeof(LEGJEIBOIBP), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
internal class LEGJEIBOIBP : HJNPDELKIBF, HKPOOEHKBFO, PFDHPBBBFAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[DependsOn]
	private DJCLOHDLABH CPNNKNKGIJA;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x870FB50", Offset = "0x870E150", VA = "0x18870FB50", Slot = "4")]
	public void ShutdownReferences()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x870FB00", Offset = "0x870E100", VA = "0x18870FB00", Slot = "5")]
	private void CMMNFFLCJOL(CNPFBIMHGJN KADNKCJPKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x135CED0", Offset = "0x135B4D0", VA = "0x18135CED0", Slot = "6")]
	private void GCOCFFJOAJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public LEGJEIBOIBP()
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[AlwaysUpdateSystem]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[CompilerGenerated]
	public class PostDeserializeBakeShapesSystem : FNBFBEOHNGB, MOLBKPMFEIO
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[BurstCompile]
		private struct GatherBakedPrimitiveDataJob : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			[ReadOnly]
			public ComponentTypeHandle<StandardRenderableVisualData> visualTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalPoseData> poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalUniformScaleData> scaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			[ReadOnly]
			public ComponentTypeHandle<LocalDeformableScaleData> deformationScaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			[ReadOnly]
			public ComponentTypeHandle<ShapeConfigData> configTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			[ReadOnly]
			public ComponentTypeHandle<PrimitiveShapeData> shapeDataTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			[ReadOnly]
			public NativeParallelHashMap<int, CODBDPNCDGJ> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public NativeArray<HLMMJLPHCEO> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8707D90", Offset = "0x8706390", VA = "0x188707D90", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[BurstCompile]
		private struct GatherBakedSplineDataJob : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			[ReadOnly]
			public ComponentTypeHandle<SplineShapeData> splineShapeTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			[ReadOnly]
			public ComponentTypeHandle<StandardRenderableVisualData> visualTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalPoseData> poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalUniformScaleData> scaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			[ReadOnly]
			public NativeArray<KMFOEBEFONO> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			[ReadOnly]
			public NativeArray<NDDIGIFKAJC> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public NativeArray<CLDMJIMJBIL> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x8708130", Offset = "0x8706730", VA = "0x188708130", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[BurstCompile]
		internal struct CalculateSplinePointEstimateJob : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			[ReadOnly]
			public BufferTypeHandle<LinkedEntityGroup> linkedEntityGroup;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x86FD690", Offset = "0x86FBC90", VA = "0x1886FD690", Slot = "4")]
			public void Execute(ArchetypeChunk batchInChunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[BurstCompile]
		private struct GeneratePointsJob : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private struct PointSrcData
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				public float3 Position;

				[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public quaternion Rotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public float Radius;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public quaternion BlendedRotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public float BendAngle;

				[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public float BendRadius;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public float DistanceToNext;

				[Cpp2IlInjected.Token(Token = "0x17000023")]
				public float3 Direction
				{
					[Cpp2IlInjected.Token(Token = "0x6000135")]
					[Cpp2IlInjected.Address(RVA = "0x8715720", Offset = "0x8713D20", VA = "0x188715720")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000136")]
					[Cpp2IlInjected.Address(RVA = "0x87156D0", Offset = "0x8713CD0", VA = "0x1887156D0")]
					set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000046")]
			private interface IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000137")]
				[Cpp2IlInjected.Address(Slot = "0")]
				float3 NLHJBCFJELL(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000138")]
				[Cpp2IlInjected.Address(RVA = "0x87107B0", Offset = "0x870EDB0", VA = "0x1887107B0", Slot = "5")]
				public float3 HDDLOKFDEDI(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000139")]
				[Cpp2IlInjected.Address(RVA = "0x8710B60", Offset = "0x870F160", VA = "0x188710B60", Slot = "4")]
				public float3 NLHJBCFJELL(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000048")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x600013A")]
				[Cpp2IlInjected.Address(RVA = "0x87138F0", Offset = "0x8711EF0", VA = "0x1887138F0", Slot = "4")]
				public float3 NLHJBCFJELL(quaternion rotation)
				{
					return default(float3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private static readonly float3 Up;

			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private static readonly float3 DirectionAxis;

			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private static readonly float3 NormalAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			[ReadOnly]
			public BufferTypeHandle<LinkedEntityGroup> pointsByEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			[ReadOnly]
			public ComponentTypeHandle<ShapeConfigData> shapeConfigTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			[ReadOnly]
			public ComponentTypeHandle<SplineShapeData> splineParametersTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> pointPositions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointRotationData> pointRotations;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> pointScales;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public NativeArray<NDDIGIFKAJC> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public NativeArray<KMFOEBEFONO> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x87097E0", Offset = "0x8707DE0", VA = "0x1887097E0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x870A030", Offset = "0x8708630", VA = "0x18870A030")]
			private void HBGOCIKAPAD(NativeList<PointSrcData> srcData, NativeList<KMFOEBEFONO> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x870C310", Offset = "0x870A910", VA = "0x18870C310")]
			public static Vector3 OIGIACHGFBM(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x870C290", Offset = "0x870A890", VA = "0x18870C290")]
			public static quaternion NNMLBHAHBAH(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x8709E00", Offset = "0x8708400", VA = "0x188709E00")]
			private static quaternion FEDHNCCBEDN(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8708850", Offset = "0x8706E50", VA = "0x188708850")]
			private static float3 AAIKLDGDIDK(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x870C050", Offset = "0x870A650", VA = "0x18870C050")]
			private static quaternion KADDKMBAHOF(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x8708A20", Offset = "0x8707020", VA = "0x188708A20")]
			private static KMFOEBEFONO AFDLNAHCJFE(int idx, NativeList<PointSrcData> srcData)
			{
				return default(KMFOEBEFONO);
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x44E7F20", Offset = "0x44E6520", VA = "0x1844E7F20")]
			private void PNDILHDBDIL<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x870B240", Offset = "0x8709840", VA = "0x18870B240")]
			private void JPHCPJHJEMM(NativeList<PointSrcData> sourcePoints, NativeList<KMFOEBEFONO> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x870B0C0", Offset = "0x87096C0", VA = "0x18870B0C0")]
			public static float HMACEGICNJE(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x8709440", Offset = "0x8707A40", VA = "0x188709440")]
			private static quaternion BNHNFNFKGOC(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x8709630", Offset = "0x8707C30", VA = "0x188709630")]
			private static KMFOEBEFONO ENJIHOLOEAP(PointSrcData point)
			{
				return default(KMFOEBEFONO);
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x8709750", Offset = "0x8707D50", VA = "0x188709750")]
			private static KMFOEBEFONO ENJIHOLOEAP(float3 pos, quaternion rot, float radius)
			{
				return default(KMFOEBEFONO);
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x87093A0", Offset = "0x87079A0", VA = "0x1887093A0")]
			private static bool BMJKGPEPOOF(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x8708E70", Offset = "0x8707470", VA = "0x188708E70")]
			private static float3 AGGDCCBEJGP(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x870C0E0", Offset = "0x870A6E0", VA = "0x18870C0E0")]
			public static float3 LKMBMODDPGL(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x870AF10", Offset = "0x8709510", VA = "0x18870AF10")]
			public static float3 HDDLOKFDEDI(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x8708F40", Offset = "0x8707540", VA = "0x188708F40")]
			private static quaternion BEBHKGKDMAG(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8708C90", Offset = "0x8707290", VA = "0x188708C90")]
			private static float AGDPKAPAJEJ(float3 from, float3 to)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeBakeShapesSystem_LambdaJob_0_Job : IJobEntityBatchWithIndex
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public EntityCommandBuffer.ParallelWriter ecbWriter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public BufferTypeHandle<LinkedEntityGroup> __splineAndPointsTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x8717E10", Offset = "0x8716410", VA = "0x188717E10")]
			private void ANCGLJOPGHL(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x8717EF0", Offset = "0x87164F0", VA = "0x188717EF0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex, int indexOfFirstEntityInQuery)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct TrimSplinePointExcess_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			[ReadOnly]
			public NativeArray<int> pointCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public NativeList<KMFOEBEFONO> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x8719100", Offset = "0x8717700", VA = "0x188719100")]
			private void ANCGLJOPGHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x8719160", Offset = "0x8717760", VA = "0x188719160", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct SetSplinePointCapacity_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public NativeList<KMFOEBEFONO> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x87190A0", Offset = "0x87176A0", VA = "0x1887190A0")]
			private void ANCGLJOPGHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x87190F0", Offset = "0x87176F0", VA = "0x1887190F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct GatherPrimitivesAndUniqueParents_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> parentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public NativeList<Entity> parents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public NativeParallelHashSet<Entity> uniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public NativeList<HLMMJLPHCEO> data;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x8708470", Offset = "0x8706A70", VA = "0x188708470")]
			private void ANCGLJOPGHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x8708630", Offset = "0x8706C30", VA = "0x188708630", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct GatherSplinesAndUniqueParents_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> parentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public NativeList<Entity> splines;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public NativeList<Entity> parents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public NativeParallelHashSet<Entity> uniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public NativeList<NDDIGIFKAJC> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public NativeList<CLDMJIMJBIL> bakedData;

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x8708640", Offset = "0x8706C40", VA = "0x188708640")]
			private void ANCGLJOPGHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x8708840", Offset = "0x8706E40", VA = "0x188708840", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct RemoveDestroyedEntitiesFromParents_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			[ReadOnly]
			public NativeList<Entity> splineParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			[ReadOnly]
			public NativeList<Entity> splineEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public BufferFromEntity<ChildBuffer> childrenFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity;

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x8718C70", Offset = "0x8717270", VA = "0x188718C70")]
			private void ANCGLJOPGHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x8719090", Offset = "0x8717690", VA = "0x188719090", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static readonly IPHNFELODMJ log;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private const int PointEstimateIndex = 0;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private const int PointCountIndex = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private EntityQuery splineQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private EntityQuery primitiveQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private NKEJFFHGEOP replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private HNBHNOBANOG objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private DJCLOHDLABH bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private JINEJCGNBKK ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8717900", Offset = "0x8715F00", VA = "0x188717900", Slot = "15")]
		public override void InitReferences(CNPFBIMHGJN services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8718920", Offset = "0x8716F20", VA = "0x188718920", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8718A10", Offset = "0x8717010", VA = "0x188718A10", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8718A70", Offset = "0x8717070", VA = "0x188718A70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x87179A0", Offset = "0x8715FA0", VA = "0x1887179A0")]
		private JobHandle LABFOFCHCMB(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8716790", Offset = "0x8714D90", VA = "0x188716790")]
		private JobHandle CJIBCLELMGG(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8715F80", Offset = "0x8714580", VA = "0x188715F80")]
		private JobHandle DICMKBKILAJ(NativeArray<int> pointCount, NativeList<KMFOEBEFONO> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8715740", Offset = "0x8713D40", VA = "0x188715740")]
		private JobHandle KMPEBPOJIGH(NativeList<KMFOEBEFONO> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8716020", Offset = "0x8714620", VA = "0x188716020")]
		private JobHandle CEEJNDFNLIG(EntityQuery query, NativeList<NDDIGIFKAJC> splinePointRanges, NativeList<KMFOEBEFONO> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8716F60", Offset = "0x8715560", VA = "0x188716F60")]
		private JobHandle DPCIJMDBGIK(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8717CF0", Offset = "0x87162F0", VA = "0x188717CF0")]
		private JobHandle LMMIIDLGOFD(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x87164F0", Offset = "0x8714AF0", VA = "0x1887164F0")]
		private JobHandle CEFMEPCFNMB(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<HLMMJLPHCEO> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn, Allocator allocator = Allocator.TempJob)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8717420", Offset = "0x8715A20", VA = "0x188717420")]
		private JobHandle EMDNKABCPAE(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<NDDIGIFKAJC> splinePointRanges, [Out] NativeList<CLDMJIMJBIL> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn, Allocator allocator = Allocator.TempJob)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x87157E0", Offset = "0x8713DE0", VA = "0x1887157E0")]
		private JobHandle AJPEKAPAEPC(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x87180D0", Offset = "0x87166D0", VA = "0x1887180D0")]
		private JobHandle OILCIABNDBI(EntityQuery query, NativeList<HLMMJLPHCEO> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8715B60", Offset = "0x8714160", VA = "0x188715B60")]
		private static NativeParallelHashMap<int, CODBDPNCDGJ> ANLAIKGIKDO()
		{
			return default(NativeParallelHashMap<int, CODBDPNCDGJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8717080", Offset = "0x8715680", VA = "0x188717080")]
		private JobHandle EJDGDBMOBHC(EntityQuery query, NativeList<NDDIGIFKAJC> splinePointRanges, NativeList<KMFOEBEFONO> splinePointData, NativeList<CLDMJIMJBIL> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x87176D0", Offset = "0x8715CD0", VA = "0x1887176D0")]
		private JobHandle ENMPLIABAPB(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8715F80", Offset = "0x8714580", VA = "0x188715F80")]
		private JobHandle BCJGGKIBIKA(NativeArray<int> pointCount, NativeList<KMFOEBEFONO> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8715740", Offset = "0x8713D40", VA = "0x188715740")]
		private JobHandle AIILACNCMEB(NativeList<KMFOEBEFONO> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8717FE0", Offset = "0x87165E0", VA = "0x188717FE0")]
		private JobHandle MOEFCNCOCCK(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<HLMMJLPHCEO> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8716E50", Offset = "0x8715450", VA = "0x188716E50")]
		private JobHandle COMPGCBCIEA(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<NDDIGIFKAJC> ranges, NativeList<CLDMJIMJBIL> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x87177B0", Offset = "0x8715DB0", VA = "0x1887177B0")]
		private JobHandle FKFFHJBKOML(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x87185E0", Offset = "0x8716BE0", VA = "0x1887185E0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x30C90C0", Offset = "0x30C76C0", VA = "0x1830C90C0")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class FHPCANFAIBM : CJOAGKPBBIM, MOLBKPMFEIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private DJCLOHDLABH CPNNKNKGIJA;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x87071C0", Offset = "0x87057C0", VA = "0x1887071C0", Slot = "14")]
	public void InitReferences(CNPFBIMHGJN KADNKCJPKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x8707210", Offset = "0x8705810", VA = "0x188707210", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x2E01C10", Offset = "0x2E00210", VA = "0x182E01C10")]
	public FHPCANFAIBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
[AlwaysUpdateSystem]
public class EHEFPPLDCOI : FNBFBEOHNGB, MOLBKPMFEIO
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct FODBDGGDBDF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private EntityManager OLNPNJLIAFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private PLGBMEJFPJM<T> OAJFEAKGCDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> CFGKIEMOCOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private int PMIGBJGNLLP;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) MIECLPJBKEF
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x5028EF0", Offset = "0x50274F0", VA = "0x185028EF0")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x50293B0", Offset = "0x50279B0", VA = "0x1850293B0")]
		public FODBDGGDBDF(EntityManager OLNPNJLIAFG, PLGBMEJFPJM<T> OAJFEAKGCDG, NativeArray<EntityRemapUtility.EntityRemapInfo> CFGKIEMOCOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x4C15C40", Offset = "0x4C14240", VA = "0x184C15C40")]
		public FODBDGGDBDF<T> ABGODHCJODA()
		{
			return default(FODBDGGDBDF<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x5028910", Offset = "0x5026F10", VA = "0x185028910")]
		public bool DDPDBHDONME()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly IPHNFELODMJ MBOIAFDOEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private LHFLBCKMPKJ ANNKEFOJBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private DJCLOHDLABH CPNNKNKGIJA;

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x8704240", Offset = "0x8702840", VA = "0x188704240", Slot = "15")]
	public override void InitReferences(CNPFBIMHGJN KADNKCJPKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x87049C0", Offset = "0x8702FC0", VA = "0x1887049C0")]
	public void NIDJCHOPLJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x8705A10", Offset = "0x8704010", VA = "0x188705A10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x8703120", Offset = "0x8701720", VA = "0x188703120")]
	private void ICCKBPCLBBH(ICMLMHIHEKF GKNICJPCIJJ, Mesh[] CBLFOFKBKJF, NativeArray<EntityRemapUtility.EntityRemapInfo> CFGKIEMOCOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3C538C0", Offset = "0x3C51EC0", VA = "0x183C538C0")]
	private FODBDGGDBDF<T> NLDLLLKFDAI<T>(PLGBMEJFPJM<T> OAJFEAKGCDG, NativeArray<EntityRemapUtility.EntityRemapInfo> CFGKIEMOCOD) where T : struct
	{
		return default(FODBDGGDBDF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x87023E0", Offset = "0x87009E0", VA = "0x1887023E0")]
	private void ABAODEHPMDE(Transform BEBONNCPGLF, NativeArray<DMFKHGADJJF> CFPKFLJLMFO, BEHKKOBPFOO<GameObject> LMCBJOABKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x8705550", Offset = "0x8703B50", VA = "0x188705550")]
	private void NOJBHKPLBJP(Transform BEBONNCPGLF, NativeArray<MFKGHKJFOBB> JKONNJFIJCO, BEHKKOBPFOO<GameObject> LMCBJOABKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x87045D0", Offset = "0x8702BD0", VA = "0x1887045D0")]
	private void NFIFOGKGCED(Transform BEBONNCPGLF, NativeArray<HJMNEPGMKHE> IPJBMMIDFLM, BEHKKOBPFOO<GameObject> LMCBJOABKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x8702770", Offset = "0x8700D70", VA = "0x188702770")]
	private void BOCMCHEPJEB(Transform BEBONNCPGLF, NativeArray<NGEJGHBKCFH> CBLFOFKBKJF, Mesh[] OIADPNOMMDD, BEHKKOBPFOO<GameObject> LMCBJOABKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x87043C0", Offset = "0x87029C0", VA = "0x1887043C0")]
	private static void KLNJNCKDLJH(NativeParallelHashSet<Entity> MEJIKACDFLB, NativeParallelHashSet<Entity> JEBFBBNDPPO, NativeArray<EntityRemapUtility.EntityRemapInfo> CFGKIEMOCOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8704510", Offset = "0x8702B10", VA = "0x188704510")]
	private static void NEDGEDCEJLM(NativeList<Entity> BBBJHCKNPGO, NativeArray<EntityRemapUtility.EntityRemapInfo> CFGKIEMOCOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x87049F0", Offset = "0x8702FF0", VA = "0x1887049F0")]
	private NativeParallelHashMap<Entity, IBLOPDEMJHL> NMPCBMKFPGP(DJCLOHDLABH.DPCCJFICHJP AFPFELMCBCF, OOKPABLPMDG<NFFKIABAHEO> DAENCAPIFGO, List<GameObject> LMCBJOABKMO)
	{
		return default(NativeParallelHashMap<Entity, IBLOPDEMJHL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x87042C0", Offset = "0x87028C0", VA = "0x1887042C0")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> JGGGOCOKPHB(Entity ODNDOBEAJJC)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x8702BA0", Offset = "0x87011A0", VA = "0x188702BA0")]
	private void EKBMBHGFBND(NativeList<Entity> LAODDAGBBLD, NativeList<Entity> PDODAHCCCED, NativeParallelHashMap<Entity, IBLOPDEMJHL> MFHEKEOFMAN, NativeList<NDDIGIFKAJC> GNJGAOBFMNF, NativeList<KMFOEBEFONO> EDCPFIPKNLP, NativeList<CLDMJIMJBIL> OPPBCJCADNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8706B90", Offset = "0x8705190", VA = "0x188706B90")]
	private void PIMHFEKCBMH(NativeList<Entity> MEJIKACDFLB, NativeList<Entity> GKBKGOHGDLF, NativeParallelHashMap<Entity, IBLOPDEMJHL> MFHEKEOFMAN, NativeList<HLMMJLPHCEO> BAGDPPHLHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x30C90C0", Offset = "0x30C76C0", VA = "0x1830C90C0")]
	public EHEFPPLDCOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public abstract class NFPKFPEFEAE : AAHJJNBKLDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public readonly UniformTRS MBPHPALMDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly CENLKEFEGPJ BEBONNCPGLF;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private GameObject OIABFJPLJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public UniformTRS JGAAGHPIAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x871A6E0", Offset = "0x8718CE0", VA = "0x18871A6E0", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Vector3 IGBBHHKMOLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x871A950", Offset = "0x8718F50", VA = "0x18871A950", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Matrix4x4 KMDFCFNNMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x871A900", Offset = "0x8718F00", VA = "0x18871A900", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 BJIFIHFMAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x871A7C0", Offset = "0x8718DC0", VA = "0x18871A7C0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x871A8B0", Offset = "0x8718EB0", VA = "0x18871A8B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Quaternion HDKMOLEKPEG
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x871A860", Offset = "0x8718E60", VA = "0x18871A860", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x871A9F0", Offset = "0x8718FF0", VA = "0x18871A9F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private Vector3 JAHOIDHFILO
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x871A9A0", Offset = "0x8718FA0", VA = "0x18871A9A0", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private Vector3 JLKGIIGBHPD
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x871AA40", Offset = "0x8719040", VA = "0x18871AA40", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private Vector3 AFHDMKINPNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x871A810", Offset = "0x8718E10", VA = "0x18871A810", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x871AA90", Offset = "0x8719090", VA = "0x18871AA90")]
	public NFPKFPEFEAE(UniformTRS MBPHPALMDGK, CENLKEFEGPJ BEBONNCPGLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public abstract class KDPIFBOJBIH : NFPKFPEFEAE, EHINNOKAEPA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly float ALMPJNHAKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly float3 AJAMNFHAHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly IDOKBCEFAKB IFGENIMDOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly FBDPDFJNLFK GILIOJADFHA;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private ACLDACCHLEI PPLHOLGFBIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x871A190", Offset = "0x8718790", VA = "0x18871A190", Slot = "17")]
		get
		{
			return default(ACLDACCHLEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private UniformTRS AKACHDIGNIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x871A060", Offset = "0x8718660", VA = "0x18871A060", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private float PJAEBGMJFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xAF8E90", Offset = "0xAF7490", VA = "0x180AF8E90", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private Vector3 CCPNAEDENFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x871A140", Offset = "0x8718740", VA = "0x18871A140", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private IDOKBCEFAKB JJEJFOBAPIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xB2DCC0", Offset = "0xB2C2C0", VA = "0x180B2DCC0", Slot = "21")]
		get
		{
			return default(IDOKBCEFAKB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private FBDPDFJNLFK NBOLPFIFOMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x152C9A0", Offset = "0x152AFA0", VA = "0x18152C9A0", Slot = "22")]
		get
		{
			return default(FBDPDFJNLFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool LGNGLMOODLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool MJDHKDNGEDA
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x871A1E0", Offset = "0x87187E0", VA = "0x18871A1E0")]
	protected KDPIFBOJBIH(UniformTRS MBPHPALMDGK, CENLKEFEGPJ BEBONNCPGLF, float ALMPJNHAKPD, float3 AJAMNFHAHLE, IDOKBCEFAKB IFGENIMDOCD, FBDPDFJNLFK GILIOJADFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract UnityEngine.Hash128 ComputeHash();

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public abstract class PICOPAAAHHF : AAHJJNBKLDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	protected readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x134D100", Offset = "0x134B700", VA = "0x18134D100")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected Entity CAKIIDEDCFG
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x871ABD0", Offset = "0x87191D0", VA = "0x18871ABD0")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	protected HNBHNOBANOG EIBKLMACMLO
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x871B170", Offset = "0x8719770", VA = "0x18871B170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	protected FIMHEFEBFND OJEEGEKNOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x871AB40", Offset = "0x8719140", VA = "0x18871AB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	protected BLCEJAOLGDJ FACHAJJABEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x871B3E0", Offset = "0x87199E0", VA = "0x18871B3E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private GameObject OIABFJPLJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x871ABA0", Offset = "0x87191A0", VA = "0x18871ABA0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public UniformTRS JGAAGHPIAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x13728D0", Offset = "0x1370ED0", VA = "0x1813728D0", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Vector3 IGBBHHKMOLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x871B2F0", Offset = "0x87198F0", VA = "0x18871B2F0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Matrix4x4 KMDFCFNNMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x871B180", Offset = "0x8719780", VA = "0x18871B180", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 BJIFIHFMAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x871ABF0", Offset = "0x87191F0", VA = "0x18871ABF0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x871B060", Offset = "0x8719660", VA = "0x18871B060", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Quaternion HDKMOLEKPEG
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x871AF40", Offset = "0x8719540", VA = "0x18871AF40", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x871B560", Offset = "0x8719B60", VA = "0x18871B560", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private Vector3 JAHOIDHFILO
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x871B470", Offset = "0x8719A70", VA = "0x18871B470", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private Vector3 JLKGIIGBHPD
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x871B670", Offset = "0x8719C70", VA = "0x18871B670", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private Vector3 AFHDMKINPNB
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x871AD20", Offset = "0x8719320", VA = "0x18871AD20", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0xF9F550", Offset = "0xF9DB50", VA = "0x180F9F550")]
	protected PICOPAAAHHF(NLPLHJLLGBB IIIJIBCGHEO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x871A670", Offset = "0x8718C70", VA = "0x18871A670")]
	public static ACLDACCHLEI HNGLNPFKABH(PICOPAAAHHF DHDFDKFCOJK)
	{
		return default(ACLDACCHLEI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class HBPJFNKKFMB
{
	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x8719BE0", Offset = "0x87181E0", VA = "0x188719BE0")]
	public static void LPHGGHBGDMJ(NativeArray<Entity> MEJIKACDFLB, EntityManager OLNPNJLIAFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class PNBDLGLILDE
{
	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x871BE80", Offset = "0x871A480", VA = "0x18871BE80")]
	public static void NPKLDIHFOIA(NativeArray<Entity> MEJIKACDFLB, EntityManager OLNPNJLIAFG, EKBBEBOGNCO KFDIILANBEC, HNBHNOBANOG MIKGDJBNCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x871B8D0", Offset = "0x8719ED0", VA = "0x18871B8D0")]
	public static void ILBGHDNDKCG(NativeArray<Entity> MEJIKACDFLB, EntityManager OLNPNJLIAFG, EKBBEBOGNCO KFDIILANBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x871BBE0", Offset = "0x871A1E0", VA = "0x18871BBE0")]
	public static NativeList<Entity> JPHPNIIPJNI(NativeArray<Entity> MEJIKACDFLB, EntityManager OLNPNJLIAFG)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x871B890", Offset = "0x8719E90", VA = "0x18871B890")]
	public static NativeList<Entity> EHLPPOCIEKF(NativeArray<Entity> MEJIKACDFLB, EntityManager OLNPNJLIAFG)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x871BC20", Offset = "0x871A220", VA = "0x18871BC20")]
	private static NativeList<Entity> JPHPNIIPJNI(NativeArray<Entity> MEJIKACDFLB, EntityManager OLNPNJLIAFG, bool IDGGPGOOKBA)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public abstract class LOLDGBCLNDK : PICOPAAAHHF, EHINNOKAEPA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float ALMPJNHAKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private Vector3 AJAMNFHAHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private IDOKBCEFAKB IFGENIMDOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private FBDPDFJNLFK GILIOJADFHA;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	protected EntityManager ACKHPMIHGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x871A260", Offset = "0x8718860", VA = "0x18871A260")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	protected EPCIOFAAGGG CADNOFCPFJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x871A4B0", Offset = "0x8718AB0", VA = "0x18871A4B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	protected ShapeConfigData MFGBNHDGOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x871A540", Offset = "0x8718B40", VA = "0x18871A540")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private ACLDACCHLEI PPLHOLGFBIE
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x871A670", Offset = "0x8718C70", VA = "0x18871A670", Slot = "17")]
		get
		{
			return default(ACLDACCHLEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private float PJAEBGMJFAD
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xB02260", Offset = "0xB00860", VA = "0x180B02260", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private Vector3 CCPNAEDENFK
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x1455950", Offset = "0x1453F50", VA = "0x181455950", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private IDOKBCEFAKB JJEJFOBAPIM
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xAA70A0", Offset = "0xAA56A0", VA = "0x180AA70A0", Slot = "21")]
		get
		{
			return default(IDOKBCEFAKB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private FBDPDFJNLFK NBOLPFIFOMO
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xAF64A0", Offset = "0xAF4AA0", VA = "0x180AF64A0", Slot = "22")]
		get
		{
			return default(FBDPDFJNLFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	private UniformTRS AKACHDIGNIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x13728D0", Offset = "0x1370ED0", VA = "0x1813728D0", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool MJDHKDNGEDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xAD4490", Offset = "0xAD2A90", VA = "0x180AD4490", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xAD43F0", Offset = "0xAD29F0", VA = "0x180AD43F0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	private bool LGNGLMOODLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x871A6A0", Offset = "0x8718CA0", VA = "0x18871A6A0")]
	protected LOLDGBCLNDK(NLPLHJLLGBB IIIJIBCGHEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x871A320", Offset = "0x8718920", VA = "0x18871A320", Slot = "26")]
	public virtual void FPGILMIKMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class FNBFBEOHNGB : CJOAGKPBBIM, MOLBKPMFEIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	protected HNBHNOBANOG MIKGDJBNCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private JILHBDOFIBK AJLGIFGJLEI;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	protected EKBBEBOGNCO OOIBOPKIHPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8719AD0", Offset = "0x87180D0", VA = "0x188719AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	protected DIBJFLJJFNO MMINMIPPDLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8719B20", Offset = "0x8718120", VA = "0x188719B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	protected bool PAOFCJMFCGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8719A10", Offset = "0x8718010", VA = "0x188719A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x8719B70", Offset = "0x8718170", VA = "0x188719B70", Slot = "15")]
	public virtual void InitReferences(CNPFBIMHGJN KADNKCJPKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x2E01C10", Offset = "0x2E00210", VA = "0x182E01C10")]
	protected FNBFBEOHNGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class IEBBGLHLLCI
{
	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x8719E20", Offset = "0x8718420", VA = "0x188719E20")]
	public static void IDODIIKOINA(NativeArray<Entity> LAODDAGBBLD, EntityManager OLNPNJLIAFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__4081358339
{
	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x871C7E0", Offset = "0x871ADE0", VA = "0x18871C7E0")]
	public static void GIFNOONCKGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x871C7D0", Offset = "0x871ADD0", VA = "0x18871C7D0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class PCFBMNEKADD : ContainerPropertyBag<HKJKOCGOICD>
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x871AAE0", Offset = "0x87190E0", VA = "0x18871AAE0")]
	public PCFBMNEKADD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class EFCPFLMJCCC : ContainerPropertyBag<IMGDMOFBEJL>
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x87199B0", Offset = "0x8717FB0", VA = "0x1887199B0")]
	public EFCPFLMJCCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class BGDPANCIEBK : ContainerPropertyBag<BIDIPKEIOIP>
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x8719950", Offset = "0x8717F50", VA = "0x188719950")]
	public BGDPANCIEBK()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x871C290", Offset = "0x871A890", VA = "0x18871C290")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
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
