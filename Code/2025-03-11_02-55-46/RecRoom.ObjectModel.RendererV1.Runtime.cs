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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
	public class LogRegistrationIndex : KENHJELJHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x77984C0", Offset = "0x77978C0", VA = "0x1877984C0", Slot = "4")]
		public override void ICLMLJMBJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
			[Cpp2IlInjected.Address(RVA = "0x969450", Offset = "0x968850", VA = "0x180969450", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1E8F400", Offset = "0x1E8E800", VA = "0x181E8F400", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x77A4790", Offset = "0x77A3B90", VA = "0x1877A4790")]
		private void PFONFFPEPLP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x77A4D20", Offset = "0x77A4120", VA = "0x1877A4D20", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x77A4D80", Offset = "0x77A4180", VA = "0x1877A4D80")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class GFIMPACDPHF
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x77901E0", Offset = "0x778F5E0", VA = "0x1877901E0")]
	public static Quaternion MNBFEKHMBGH([In] this HNHJFNCCALB IPGAMDJAJAP, [In] Vector3 HEBBPJGOPIH)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class ALMEJKNIFDC
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7788530", Offset = "0x7787930", VA = "0x187788530")]
	public static bool NOPBEKKDOIA(this HPJCPHCMBOG ACNBKDIDKCE, OAHBOFCALAL KFEJIDFAIID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7788570", Offset = "0x7787970", VA = "0x187788570")]
	public static bool OFGECCMDHGG(this HPJCPHCMBOG ACNBKDIDKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7786AB0", Offset = "0x7785EB0", VA = "0x187786AB0")]
	public static bool CLFPOGLNMPN(this HPJCPHCMBOG ACNBKDIDKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7788400", Offset = "0x7787800", VA = "0x187788400")]
	public static void NMNJHNBDLME(this HPJCPHCMBOG ACNBKDIDKCE, Vector3 DPJLFFGKGFA, Quaternion DHEPDKHKAEK, float EJOLINDBPPE, bool KAGHLGPIKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7788180", Offset = "0x7787580", VA = "0x187788180")]
	public static void LCABMJMLAEA(this HPJCPHCMBOG ACNBKDIDKCE, Vector3 DPJLFFGKGFA, Quaternion DHEPDKHKAEK, float EJOLINDBPPE, int EPGPJCNNFOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7787ED0", Offset = "0x77872D0", VA = "0x187787ED0")]
	public static void KEADGOCANPK(this HPJCPHCMBOG ACNBKDIDKCE, int EPGPJCNNFOF, Vector3 DPJLFFGKGFA, Quaternion DHEPDKHKAEK, float EJOLINDBPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7788100", Offset = "0x7787500", VA = "0x187788100")]
	public static void KNKAFMAKLAM(this HPJCPHCMBOG ACNBKDIDKCE, Vector3 NNIEOJBGHOI, Quaternion IEKGOLJMHCH, float EJOLINDBPPE, bool KAGHLGPIKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x77871B0", Offset = "0x77865B0", VA = "0x1877871B0")]
	private static void FCBGDPFPDPI(this HPJCPHCMBOG ACNBKDIDKCE, Vector3 HJBDDDIFEBJ, Quaternion NBFJKGINHEC, float EJOLINDBPPE, bool KAGHLGPIKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7787B00", Offset = "0x7786F00", VA = "0x187787B00")]
	private static void HJBFJIFHGIM(this HPJCPHCMBOG ACNBKDIDKCE, Vector3 ODMGDEIMGFO, Quaternion NNFHCIFKIPA, float CAGFFJLLIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7786AE0", Offset = "0x7785EE0", VA = "0x187786AE0")]
	private static void EDAOFIOILMB(this HPJCPHCMBOG ACNBKDIDKCE, int FFCBHHABFJN, Vector3 ODMGDEIMGFO, Quaternion NNFHCIFKIPA, float CAGFFJLLIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7788150", Offset = "0x7787550", VA = "0x187788150")]
	private static bool KPJIJHBBHLM(this HPJCPHCMBOG ACNBKDIDKCE, int FFCBHHABFJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7786820", Offset = "0x7785C20", VA = "0x187786820")]
	private static void CJKNLIDMEFI(this HPJCPHCMBOG ACNBKDIDKCE, int FFCBHHABFJN, Vector3 ODMGDEIMGFO, Quaternion NNFHCIFKIPA, float CAGFFJLLIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7786CC0", Offset = "0x77860C0", VA = "0x187786CC0")]
	public static Vector3 EDJGDKHJMBI(this HPJCPHCMBOG ACNBKDIDKCE, int FFCBHHABFJN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7787FF0", Offset = "0x77873F0", VA = "0x187787FF0")]
	public static Quaternion KJIBFGPOEJM(this HPJCPHCMBOG ACNBKDIDKCE, int FFCBHHABFJN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7787CB0", Offset = "0x77870B0", VA = "0x187787CB0")]
	public static Vector3 IFLFPELAACF(OAHBOFCALAL NHJKDMPGJCM, Vector3 HJBDDDIFEBJ, Vector3? OJJEIBDBBGA, Vector3 GPFGKCPGENB)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface DDNGFHELKKG
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GJNOEIBDMLG(EntityQuery KKBGBNDNACE, EntityManager HIKDABPFHKC, DAANGIHLEKL GDFLHALIOAL, GGHFJPPOMCJ EHFBBIKLDEH);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface BOLBGDLDFAF
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType OBBPEOOPHBG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MKCINNGADOK(EntityQuery KKBGBNDNACE, NCIAIDEDLKA OEOBNNDILOI);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KEOFKOIHENC(EntityQuery KKBGBNDNACE, NCIAIDEDLKA OEOBNNDILOI);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PCIGPANEICJ(NCIAIDEDLKA OEOBNNDILOI);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class NMMEDDCCMMJ : DDNGFHELKKG
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7799790", Offset = "0x7798B90", VA = "0x187799790", Slot = "4")]
	public void GJNOEIBDMLG(EntityQuery KKBGBNDNACE, EntityManager HIKDABPFHKC, DAANGIHLEKL GDFLHALIOAL, GGHFJPPOMCJ EHFBBIKLDEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public NMMEDDCCMMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class KBMEFFNCABB : DDNGFHELKKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly OPHICPAGLCD IBLPGGJBLLJ;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
	public KBMEFFNCABB(OPHICPAGLCD IBLPGGJBLLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7796C10", Offset = "0x7796010", VA = "0x187796C10", Slot = "4")]
	public void GJNOEIBDMLG(EntityQuery KKBGBNDNACE, EntityManager HIKDABPFHKC, DAANGIHLEKL GDFLHALIOAL, GGHFJPPOMCJ EHFBBIKLDEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class AIJDFOIMFKB : DDNGFHELKKG
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x77866E0", Offset = "0x7785AE0", VA = "0x1877866E0", Slot = "4")]
	public void GJNOEIBDMLG(EntityQuery KKBGBNDNACE, EntityManager HIKDABPFHKC, DAANGIHLEKL GDFLHALIOAL, GGHFJPPOMCJ EHFBBIKLDEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public AIJDFOIMFKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class COFAKOGHLOC : BOLBGDLDFAF
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType OBBPEOOPHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x778AE30", Offset = "0x778A230", VA = "0x18778AE30", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x778B0E0", Offset = "0x778A4E0", VA = "0x18778B0E0", Slot = "5")]
	public void MKCINNGADOK(EntityQuery KKBGBNDNACE, NCIAIDEDLKA OEOBNNDILOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x778AE60", Offset = "0x778A260", VA = "0x18778AE60", Slot = "6")]
	public void KEOFKOIHENC(EntityQuery KKBGBNDNACE, NCIAIDEDLKA OEOBNNDILOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x778B360", Offset = "0x778A760", VA = "0x18778B360", Slot = "7")]
	public void PCIGPANEICJ(NCIAIDEDLKA OEOBNNDILOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public COFAKOGHLOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class DNHJILPGBIM : BOLBGDLDFAF
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType OBBPEOOPHBG
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x778E150", Offset = "0x778D550", VA = "0x18778E150", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x778E400", Offset = "0x778D800", VA = "0x18778E400", Slot = "5")]
	public void MKCINNGADOK(EntityQuery KKBGBNDNACE, NCIAIDEDLKA OEOBNNDILOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x778E180", Offset = "0x778D580", VA = "0x18778E180", Slot = "6")]
	public void KEOFKOIHENC(EntityQuery KKBGBNDNACE, NCIAIDEDLKA OEOBNNDILOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x778E680", Offset = "0x778DA80", VA = "0x18778E680", Slot = "7")]
	public void PCIGPANEICJ(NCIAIDEDLKA OEOBNNDILOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public DNHJILPGBIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FBIJILLNPAG : BOLBGDLDFAF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType OBBPEOOPHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x778E6D0", Offset = "0x778DAD0", VA = "0x18778E6D0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x778E980", Offset = "0x778DD80", VA = "0x18778E980", Slot = "5")]
	public void MKCINNGADOK(EntityQuery KKBGBNDNACE, NCIAIDEDLKA OEOBNNDILOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x778E700", Offset = "0x778DB00", VA = "0x18778E700", Slot = "6")]
	public void KEOFKOIHENC(EntityQuery KKBGBNDNACE, NCIAIDEDLKA OEOBNNDILOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x778EC00", Offset = "0x778E000", VA = "0x18778EC00", Slot = "7")]
	public void PCIGPANEICJ(NCIAIDEDLKA OEOBNNDILOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public FBIJILLNPAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class JMIGMEJCEJL : OKBGABKHKPB, FLJLMKCIEIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DAANGIHLEKL GDFLHALIOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private EHJLMPLCNND DBNLHIHKFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private GGHFJPPOMCJ EHFBBIKLDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, DDNGFHELKKG adapter)> ADAEFGNIMGL;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7796760", Offset = "0x7795B60", VA = "0x187796760", Slot = "15")]
	public virtual void InitReferences(FHGOKBONFMJ BHDEAEIFGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x77967F0", Offset = "0x7795BF0", VA = "0x1877967F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x77965F0", Offset = "0x77959F0", VA = "0x1877965F0")]
	private void DDGMDAMHFPB(EntityQueryDesc KHKMGOAAPFM, DDNGFHELKKG NJNBHFDMGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7796A20", Offset = "0x7795E20", VA = "0x187796A20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x27FBB00", Offset = "0x27FAF00", VA = "0x1827FBB00")]
	public JMIGMEJCEJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class GONLCJBLDAI : OKBGABKHKPB, FLJLMKCIEIM
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class EFLKEJMOGFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery HEFAEAAFEDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery JMIMKOIIGMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery BEHMEAMMKBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery BOBMKHMDBJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery ALMLLHMJNJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EntityQuery MGMIFHAGDBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EntityQuery EOAPIDADALI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public BOLBGDLDFAF EPJFEFFKENB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ComponentType KOHHDHGBKHL;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public EFLKEJMOGFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private DAANGIHLEKL GDFLHALIOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private GGHFJPPOMCJ EHFBBIKLDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EHJLMPLCNND DBNLHIHKFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<EFLKEJMOGFC> ADAEFGNIMGL;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7790A00", Offset = "0x778FE00", VA = "0x187790A00", Slot = "14")]
	public void InitReferences(FHGOKBONFMJ BHDEAEIFGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7790EE0", Offset = "0x77902E0", VA = "0x187790EE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7791060", Offset = "0x7790460", VA = "0x187791060", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7790A90", Offset = "0x778FE90", VA = "0x187790A90")]
	private void NNOJAHGHCJN(EFLKEJMOGFC LJEFMOEFEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x77902C0", Offset = "0x778F6C0", VA = "0x1877902C0")]
	private void DDGMDAMHFPB(BOLBGDLDFAF EPJFEFFKENB, ComponentType GBFLKDCDAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x27FBB00", Offset = "0x27FAF00", VA = "0x1827FBB00")]
	public GONLCJBLDAI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14336554891096525153uL)]
internal struct FJGLCEDMIDB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(3939343835747908767uL)]
internal struct KKLEHAIAGDA : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(9697228609905595395uL)]
internal struct GGNGNBPOEDF : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(GGHFJPPOMCJ), new string[] { })]
public class PMICKGMLLHG : GGHFJPPOMCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public MOCNBIDPOEK FPMKAAPPNLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9641A0", Offset = "0x9635A0", VA = "0x1809641A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(MOCNBIDPOEK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x968380", Offset = "0x967780", VA = "0x180968380", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public PMICKGMLLHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(JKGOHAJABJM), new string[] { })]
public class FCLKMMEPNKA : JKGOHAJABJM, BDMDIKPLAEM, FCCMCMPLEOO, KMADININNGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[DependsOn]
	private GAMNGGOOCAB HMKOFFGCOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[DependsOn]
	private DAANGIHLEKL GDFLHALIOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[DependsOn]
	private KFKIFDIIJNI FFCFBJDHKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Entity OFIFJAJPFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private AKCJCIIMEDH NKBNKIAKHIN;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x778F0B0", Offset = "0x778E4B0", VA = "0x18778F0B0", Slot = "4")]
	public bool JDBBDKGBDAD(DHFHGDGMDKP DKAEPFAKBGE, OBIFENBBCHC PEBNJNGMMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x778ECE0", Offset = "0x778E0E0", VA = "0x18778ECE0", Slot = "5")]
	public AKCJCIIMEDH FCBLMLCJNID()
	{
		return default(AKCJCIIMEDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x778EFA0", Offset = "0x778E3A0", VA = "0x18778EFA0", Slot = "6")]
	public void FDDPPNJIHHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x778EC50", Offset = "0x778E050", VA = "0x18778EC50", Slot = "7")]
	private void AONIDMJBHFK(FHGOKBONFMJ BHDEAEIFGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xFFB930", Offset = "0xFFAD30", VA = "0x180FFB930", Slot = "8")]
	private void EGAMOOCMNGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public FCLKMMEPNKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(FOLEOLHDCEH), new string[] { })]
public class DDEPKGIGKPK : FOLEOLHDCEH
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x778BF90", Offset = "0x778B390", VA = "0x18778BF90", Slot = "4")]
	public void PFGJACILCKO(World HMKOFFGCOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x778BE70", Offset = "0x778B270", VA = "0x18778BE70", Slot = "5")]
	public void GOJPIAKFJCM(World HMKOFFGCOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x778B560", Offset = "0x778A960", VA = "0x18778B560", Slot = "6")]
	public ComponentSystemBase BOCPOBCHPMO(World HMKOFFGCOII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x778BF30", Offset = "0x778B330", VA = "0x18778BF30", Slot = "7")]
	public void JFODKDMGIOD(World HMKOFFGCOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x778B5B0", Offset = "0x778A9B0", VA = "0x18778B5B0", Slot = "8")]
	public void CJIAIEMPPCF(World HMKOFFGCOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x778BE10", Offset = "0x778B210", VA = "0x18778BE10", Slot = "9")]
	public void FHGLGKFPCFI(World HMKOFFGCOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x778BEC0", Offset = "0x778B2C0", VA = "0x18778BEC0", Slot = "10")]
	public void HDKPFJEGFOI(World HMKOFFGCOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x778B610", Offset = "0x778AA10", VA = "0x18778B610", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> FADACKAGLEC()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public DDEPKGIGKPK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(8022771283198464153uL)]
public struct ENBOOKCNDAJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(7787318400023670087uL)]
public struct LFBMHGEDCKJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class ILGEJFPDAPJ : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public DPDHDNPDHKE NIAOBDKNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x969470", Offset = "0x968870", VA = "0x180969470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x77965A0", Offset = "0x77959A0", VA = "0x1877965A0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7796530", Offset = "0x7795930", VA = "0x187796530", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public ILGEJFPDAPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(9578575130884295287uL)]
public struct IKCBDIPCJFN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public AKCJCIIMEDH HDPFNDKLLEF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xB838A0", Offset = "0xB82CA0", VA = "0x180B838A0")]
	public static IKCBDIPCJFN JKGHIELMIOO(AKCJCIIMEDH ODHBLOGMAPO)
	{
		return default(IKCBDIPCJFN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class BEEIIJCPNHA : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public BLGBNPJNFFP IOOKOIBMNNC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x969470", Offset = "0x968870", VA = "0x180969470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x77891B0", Offset = "0x77885B0", VA = "0x1877891B0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public BEEIIJCPNHA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(10815538147163088674uL)]
public struct OPHAOHEGILI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(10245696125477899514uL)]
public struct IPDKDIFBCAH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NPNDLLJKHLE KLKKEJHMCGL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xB838A0", Offset = "0xB82CA0", VA = "0x180B838A0")]
	public static IPDKDIFBCAH JKGHIELMIOO(NPNDLLJKHLE ODHBLOGMAPO)
	{
		return default(IPDKDIFBCAH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(10129251117493878592uL)]
public struct FKMJOKDICNN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public AKCJCIIMEDH HDPFNDKLLEF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xB838A0", Offset = "0xB82CA0", VA = "0x180B838A0")]
	public static FKMJOKDICNN JKGHIELMIOO(AKCJCIIMEDH ODHBLOGMAPO)
	{
		return default(FKMJOKDICNN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GBCOGCFOGBE : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public OMEBILIEOAO JOIOOIPDPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x969470", Offset = "0x968870", VA = "0x180969470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7790190", Offset = "0x778F590", VA = "0x187790190", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7790120", Offset = "0x778F520", VA = "0x187790120", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public GBCOGCFOGBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class FJCCPLAPNOF : OIHHMBAJKJK, DPDHDNPDHKE, EOFEGJKNAFF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public HFCKMPNMIEL CGMBAGGALBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xC23280", Offset = "0xC22680", VA = "0x180C23280", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(HFCKMPNMIEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool FFBKPPJOMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xAFAB30", Offset = "0xAF9F30", VA = "0x180AFAB30", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public float3 NJMFKPOPIFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xF35990", Offset = "0xF34D90", VA = "0x180F35990", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x778FE30", Offset = "0x778F230", VA = "0x18778FE30")]
	public FJCCPLAPNOF(UniformTRS DLCIDFLLFKP, OECCNICKBHM HKNGNFLDPKM, float ILNCJACLHFE, float3 CGIPKOIFBOM, KJLMKLABEMK IMIBEEOGNLO, KOCPEJPPMDN CBHBGIDDABE, HFCKMPNMIEL HBNEPCKNBOE, float3 IADKDIIHMIH, bool CNHMGDAEJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x778FDE0", Offset = "0x778F1E0", VA = "0x18778FDE0", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class NBAFEDFMBGM : OIHHMBAJKJK, OMEBILIEOAO, EOFEGJKNAFF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<PDDAJOGDNBJ> DDJBPLBBGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly DODFNBNEDGP GAPCIOOOOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly float LLDHCAGLFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly int BIFPCJAGKME;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool PLJCMFPPIHP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x77992D0", Offset = "0x77986D0", VA = "0x1877992D0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool FIPBCFDKLOF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x77992F0", Offset = "0x77986F0", VA = "0x1877992F0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool IGPBMMLECKH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x77992E0", Offset = "0x77986E0", VA = "0x1877992E0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int IAAIAHDJLEI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xC5B340", Offset = "0xC5A740", VA = "0x180C5B340", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float CLHDCFNLLFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xB8D090", Offset = "0xB8C490", VA = "0x180B8D090", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int GLHONEOHMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xDF6DF0", Offset = "0xDF61F0", VA = "0x180DF6DF0", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7799220", Offset = "0x7798620", VA = "0x187799220")]
	public NBAFEDFMBGM(UniformTRS DLCIDFLLFKP, OECCNICKBHM HKNGNFLDPKM, float ILNCJACLHFE, float3 CGIPKOIFBOM, KJLMKLABEMK IMIBEEOGNLO, KOCPEJPPMDN CBHBGIDDABE, DODFNBNEDGP GAPCIOOOOMF, float LLDHCAGLFJJ, int BIFPCJAGKME, NativeArray<PDDAJOGDNBJ> DDJBPLBBGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xF4DC60", Offset = "0xF4D060", VA = "0x180F4DC60", Slot = "33")]
	public NativeArray<PDDAJOGDNBJ> GetNativeCurvePoints()
	{
		return default(NativeArray<PDDAJOGDNBJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7799160", Offset = "0x7798560", VA = "0x187799160", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class CLDGMFMPFHL : LOEFMNODIKE, DPDHDNPDHKE, EOFEGJKNAFF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Dictionary<KKPFGOPCOFD, HFCKMPNMIEL> EFLFHKAIIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private HFCKMPNMIEL HBNEPCKNBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool CNHMGDAEJBB;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private HFCKMPNMIEL ANPBOBIMOBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x983DD0", Offset = "0x9831D0", VA = "0x180983DD0", Slot = "28")]
		get
		{
			return default(HFCKMPNMIEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool BCDFDMOKLLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xD324F0", Offset = "0xD318F0", VA = "0x180D324F0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float3 NJMFKPOPIFG
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x778AD60", Offset = "0x778A160", VA = "0x18778AD60", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x778AD40", Offset = "0x778A140", VA = "0x18778AD40")]
	public CLDGMFMPFHL(DHFHGDGMDKP JPJAODCKADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x778A6C0", Offset = "0x7789AC0", VA = "0x18778A6C0", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x778A710", Offset = "0x7789B10", VA = "0x18778A710", Slot = "26")]
	public override void PCKKFECIKBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class KFBNKIJNFKI : BOBCODMCCGF, BLGBNPJNFFP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private GameObject BPDHEFNFAKH;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GameObject ILEPLPIMKGD
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7796E60", Offset = "0x7796260", VA = "0x187796E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ANJIJJGNKJL KCFIKHGOCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7796D60", Offset = "0x7796160", VA = "0x187796D60", Slot = "15")]
		get
		{
			return default(ANJIJJGNKJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public GKDDANMGOBF CEGAMGNEMPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7797350", Offset = "0x7796750", VA = "0x187797350", Slot = "16")]
		get
		{
			return default(GKDDANMGOBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7797200", Offset = "0x7796600", VA = "0x187797200")]
	public KFBNKIJNFKI(DHFHGDGMDKP DKAEPFAKBGE, bool GMEDMNHDCGG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7797070", Offset = "0x7796470", VA = "0x187797070")]
	public void MDKKCGOBEFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7796D60", Offset = "0x7796160", VA = "0x187796D60")]
	protected ANJIJJGNKJL APOELNNLKOH()
	{
		return default(ANJIJJGNKJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7796F20", Offset = "0x7796320", VA = "0x187796F20")]
	private static bool LIKBCJODNKA(DHFHGDGMDKP LMEOBJOCMMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7796EF0", Offset = "0x77962F0", VA = "0x187796EF0", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class OJKFAMKABMD : LOEFMNODIKE, OMEBILIEOAO, EOFEGJKNAFF, IDisposable, DGNOLDGACPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeList<PDDAJOGDNBJ> DDJBPLBBGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool CFOKIAGOCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool BFGAMGCBFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private float LLDHCAGLFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int BIFPCJAGKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private bool OINJEGGOMON;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool AILINEIOBFO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xB07F00", Offset = "0xB07300", VA = "0x180B07F00", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool NEHLPLAGMMM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9B1790", Offset = "0x9B0B90", VA = "0x1809B1790", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float MMPJMACNMNK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xEFF370", Offset = "0xEFE770", VA = "0x180EFF370", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int EGMAMEHEFKI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xC23280", Offset = "0xC22680", VA = "0x180C23280", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool MEIDGJBEOIB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAFAB30", Offset = "0xAF9F30", VA = "0x180AFAB30", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int HEOKLGNIHII
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x779A6A0", Offset = "0x7799AA0", VA = "0x18779A6A0", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int MMNGKPBIKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x779A5B0", Offset = "0x77999B0", VA = "0x18779A5B0", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x779A7A0", Offset = "0x7799BA0", VA = "0x18779A7A0")]
	public OJKFAMKABMD(DHFHGDGMDKP JPJAODCKADG, [Optional] NativeList<PDDAJOGDNBJ> DDJBPLBBGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x779A6C0", Offset = "0x7799AC0", VA = "0x18779A6C0", Slot = "26")]
	public override void PCKKFECIKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7799EE0", Offset = "0x77992E0", VA = "0x187799EE0", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7799FD0", Offset = "0x77993D0", VA = "0x187799FD0", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x779A200", Offset = "0x7799600", VA = "0x18779A200")]
	public void HMDAGLKFFJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x779A030", Offset = "0x7799430", VA = "0x18779A030", Slot = "34")]
	public NativeArray<PDDAJOGDNBJ> GetNativeCurvePoints()
	{
		return default(NativeArray<PDDAJOGDNBJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x779A460", Offset = "0x7799860", VA = "0x18779A460", Slot = "35")]
	private Vector3 LLHKMELEOPB(int HHHJLAPJJLA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7799EB0", Offset = "0x77992B0", VA = "0x187799EB0", Slot = "36")]
	private Quaternion BNPLOBJJHNG(int HHHJLAPJJLA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x779A260", Offset = "0x7799660", VA = "0x18779A260", Slot = "37")]
	private float INGNJOBIFNK(int HHHJLAPJJLA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x779A3F0", Offset = "0x77997F0", VA = "0x18779A3F0")]
	private NativeArray<Entity> KJKEKLNIPCM()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class CGGHIFAJBGE : EELIFPECAAN
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7789F00", Offset = "0x7789300", VA = "0x187789F00", Slot = "15")]
	protected override ComponentSystemBase AIKKCFFHGLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x778A2A0", Offset = "0x77896A0", VA = "0x18778A2A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x778A2B0", Offset = "0x77896B0", VA = "0x18778A2B0")]
	public CGGHIFAJBGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[KDOAFPHOGOG]
public sealed class BDEPKPDGIMD : KMOEIMBPGHD
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private EntityQuery AABLCLOLFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private EntityQuery PDBHDPONLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EntityQuery BONKIHKHLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery CKMCIIGLPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EntityQuery NLHAHIMFNEM;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7788BB0", Offset = "0x7787FB0", VA = "0x187788BB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7788F10", Offset = "0x7788310", VA = "0x187788F10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x77885A0", Offset = "0x77879A0", VA = "0x1877885A0")]
	private void AOALAKNOGCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x77889A0", Offset = "0x7787DA0", VA = "0x1877889A0")]
	private void OLIPFBLFOAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7788F50", Offset = "0x7788350", VA = "0x187788F50")]
	private void PKNOKMMNHEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7788AB0", Offset = "0x7787EB0", VA = "0x187788AB0")]
	private void OLNMMKJGMJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7788840", Offset = "0x7787C40", VA = "0x187788840")]
	private void LHOFIEKGLIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7788780", Offset = "0x7787B80", VA = "0x187788780")]
	private NativeList<Entity> IHMLCDOKLGH(NativeArray<Entity> PPMNIACNFOH)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x77887E0", Offset = "0x7787BE0", VA = "0x1877887E0")]
	private NativeList<Entity> JAPLAHCNBOA(NativeArray<Entity> PPMNIACNFOH)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7788940", Offset = "0x7787D40", VA = "0x187788940")]
	private void LONIGLHHDCA(NativeArray<Entity> PPMNIACNFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x77866D0", Offset = "0x7785AD0", VA = "0x1877866D0")]
	public BDEPKPDGIMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[KDOAFPHOGOG]
public sealed class AHFFLPDIGIN : KMOEIMBPGHD, FLJLMKCIEIM
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery MIGBECCONNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityQuery JJMBDGAJIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private EntityQuery BEHMEAMMKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private JKGOHAJABJM PPHMNFKIADP;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7786450", Offset = "0x7785850", VA = "0x187786450", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7786030", Offset = "0x7785430", VA = "0x187786030", Slot = "15")]
	public override void InitReferences(FHGOKBONFMJ BHDEAEIFGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7786620", Offset = "0x7785A20", VA = "0x187786620", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x77859B0", Offset = "0x7784DB0", VA = "0x1877859B0")]
	private void FNGHECJJHOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7785290", Offset = "0x7784690", VA = "0x187785290")]
	private void CDPPIGJKALE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7786090", Offset = "0x7785490", VA = "0x187786090")]
	private void KDOPDGGLJGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7785910", Offset = "0x7784D10", VA = "0x187785910")]
	private bool DCDMPGGKDIN(Entity JNOEBKCCPMC, [Out] AKCJCIIMEDH HDPFNDKLLEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x77850E0", Offset = "0x77844E0", VA = "0x1877850E0")]
	private bool BKENAJFKGJD(Entity JNOEBKCCPMC, [Out] AKCJCIIMEDH HDPFNDKLLEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x77866D0", Offset = "0x7785AD0", VA = "0x1877866D0")]
	public AHFFLPDIGIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[KDOAFPHOGOG]
public sealed class HHFHJMACDCG : KMOEIMBPGHD
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EntityQuery LNGELOMKJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EntityQuery BHJLPJFMLOB;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7796340", Offset = "0x7795740", VA = "0x187796340", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7796490", Offset = "0x7795890", VA = "0x187796490", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7796040", Offset = "0x7795440", VA = "0x187796040")]
	private void FNGHECJJHOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7795D50", Offset = "0x7795150", VA = "0x187795D50")]
	private void CDPPIGJKALE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x77866D0", Offset = "0x7785AD0", VA = "0x1877866D0")]
	public HHFHJMACDCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class DGBHENHMGNH : KMOEIMBPGHD, FLJLMKCIEIM
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct NHJIOIGKJFB : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EntityQueryInJob DJJJBFHACOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public EntityQueryInJob KDJBHODLDIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EntityQueryInJob ICKLMCBGENJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EntityQueryInJob MNBCGMFJKHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ReadOnly]
		public EntityTypeHandle ENODGDFJFAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[ReadOnly]
		public ComponentTypeHandle<FKMJOKDICNN> EICLOEDEHEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NativeParallelHashSet<AKCJCIIMEDH> MAKFPAIDGEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NativeList<Entity> MCCECNHABLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeList<Entity> DNJDEAGPLCM;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7799630", Offset = "0x7798A30", VA = "0x187799630", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x77996B0", Offset = "0x7798AB0", VA = "0x1877996B0")]
		private void GOLNBIFOGCK(EntityQueryInJob KKBGBNDNACE, NativeList<Entity> LIDCMIJDHKA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private struct FKMOLODFDBE : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ReadOnly]
		public EntityTypeHandle ENODGDFJFAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[ReadOnly]
		public ComponentTypeHandle<FKMJOKDICNN> EICLOEDEHEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeParallelHashSet<AKCJCIIMEDH> MAKFPAIDGEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeList<Entity> LIDCMIJDHKA;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x778FED0", Offset = "0x778F2D0", VA = "0x18778FED0", Slot = "4")]
		public void Execute(ArchetypeChunk DPDOIHPBFBO, int OJGEGCHNCCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[BurstCompile]
	private struct NHGFIPDAODG : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[ReadOnly]
		public EntityTypeHandle ENODGDFJFAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> OKHNPAMCILG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[ReadOnly]
		public ComponentTypeHandle<IPDKDIFBCAH> PFBOHCPIPPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public ComponentDataFromEntity<IKCBDIPCJFN> BIDNAOLGAAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public ComponentTypeHandle<FKMJOKDICNN> IJONIGJOMEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeParallelHashSet<AKCJCIIMEDH> MAKFPAIDGEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeList<Entity> MLCCOEMGPGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeList<IPDKDIFBCAH> CCDDNFFBIPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<AKCJCIIMEDH> IEKHPLIKGAA;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7799300", Offset = "0x7798700", VA = "0x187799300", Slot = "4")]
		public void Execute(ArchetypeChunk DPDOIHPBFBO, int OJGEGCHNCCC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EntityQuery DJJJBFHACOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EntityQuery KDJBHODLDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private EntityQuery ICKLMCBGENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EntityQuery MNBCGMFJKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EntityQuery JJBDJHILBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private EntityQuery LPPDDIDMDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EntityQuery KJNCMKMOBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private JKGOHAJABJM FNIFGKFNMLI;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x778D840", Offset = "0x778CC40", VA = "0x18778D840", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x778CA00", Offset = "0x778BE00", VA = "0x18778CA00", Slot = "15")]
	public override void InitReferences(FHGOKBONFMJ BHDEAEIFGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x778DDC0", Offset = "0x778D1C0", VA = "0x18778DDC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x778D240", Offset = "0x778C640", VA = "0x18778D240")]
	private void MMDADHMHEKJ(NativeParallelHashSet<AKCJCIIMEDH> MAKFPAIDGEI, int KAAKLHGMKIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x778CA60", Offset = "0x778BE60", VA = "0x18778CA60")]
	private void LBABFONPACM(NativeParallelHashSet<AKCJCIIMEDH> MAKFPAIDGEI, int ABJAFCIBNNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x778C5C0", Offset = "0x778B9C0", VA = "0x18778C5C0")]
	private void INBAABPIEHA(NativeParallelHashSet<AKCJCIIMEDH> MAKFPAIDGEI, int OICOPPLABBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x778CEB0", Offset = "0x778C2B0", VA = "0x18778CEB0")]
	private void LMKNIINBPLA(NativeParallelHashSet<AKCJCIIMEDH> JCHGHHDIFBC, int FOFOGMCHEJI, int AMPDIJEJKAO, int AACMOAEIGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x778C410", Offset = "0x778B810", VA = "0x18778C410")]
	private void HMCIGCPKNEC(Entity NNAJGMBBBAL, NPNDLLJKHLE PJHKNEFBCNK, AKCJCIIMEDH HDPFNDKLLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x77866D0", Offset = "0x7785AD0", VA = "0x1877866D0")]
	public DGBHENHMGNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class MJPNICCOIEJ : KMOEIMBPGHD
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private EntityQuery GBHODFDKKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private EntityQuery ICCENDCMDHP;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7798920", Offset = "0x7797D20", VA = "0x187798920", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7798B50", Offset = "0x7797F50", VA = "0x187798B50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x77866D0", Offset = "0x7785AD0", VA = "0x1877866D0")]
	public MJPNICCOIEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[KDOAFPHOGOG]
internal class FEIKFDFBPKL : KMOEIMBPGHD
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class GNABLIJPHHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public EntityQuery DNHFFCEDOOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public EntityQuery DLFLANPGMDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NLPICHEPMNJ ILCKHJOJFPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public ComponentType GBDLCGKEEJC;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public GNABLIJPHHN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private delegate void NLPICHEPMNJ(NativeArray<NPNDLLJKHLE> ODHBLOGMAPO, NCIAIDEDLKA OEOBNNDILOI);

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private List<GNABLIJPHHN> ADAEFGNIMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private EHJLMPLCNND DBNLHIHKFNP;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x778F670", Offset = "0x778EA70", VA = "0x18778F670", Slot = "15")]
	public override void InitReferences(FHGOKBONFMJ BHDEAEIFGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x778F6D0", Offset = "0x778EAD0", VA = "0x18778F6D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x778F860", Offset = "0x778EC60", VA = "0x18778F860", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x347FF50", Offset = "0x347F350", VA = "0x18347FF50")]
	private void DDGMDAMHFPB<T>(NLPICHEPMNJ ILCKHJOJFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x778F4D0", Offset = "0x778E8D0", VA = "0x18778F4D0")]
	private static void IFEPMGNIHNP(NativeArray<NPNDLLJKHLE> OHJJNNCOGMN, NCIAIDEDLKA IGLGOHENEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x778F330", Offset = "0x778E730", VA = "0x18778F330")]
	private static void ICKDBCOJBDE(NativeArray<NPNDLLJKHLE> OHJJNNCOGMN, NCIAIDEDLKA IGLGOHENEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x778F190", Offset = "0x778E590", VA = "0x18778F190")]
	private static void ELLMMDBFEJL(NativeArray<NPNDLLJKHLE> OHJJNNCOGMN, NCIAIDEDLKA IGLGOHENEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x77866D0", Offset = "0x7785AD0", VA = "0x1877866D0")]
	public FEIKFDFBPKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[KDOAFPHOGOG]
public sealed class PIGDEJBBMAN : KMOEIMBPGHD
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private EntityQuery KKBGBNDNACE;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x779B940", Offset = "0x779AD40", VA = "0x18779B940", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct NJJCHEPFHGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public UniformTRS DLCIDFLLFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public StandardRenderableVisualData PMKNBAACEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public HFCKMPNMIEL HBNEPCKNBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float3 IADKDIIHMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public bool CNHMGDAEJBB;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[CFHELINJLKB(Lifetime.LoadInstance)]
public struct MLPAAKFFJII : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Entity CFICENCPFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeList<Entity> PPMNIACNFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<Entity> PKCEMMMKLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeParallelHashSet<Entity> MDMPFNPJHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeList<NJJCHEPFHGH> BBFOPFCDACP;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x77990D0", Offset = "0x77984D0", VA = "0x1877990D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.OMRoom)]
[RegisterService(typeof(PGACOPLMLHP), new string[] { })]
internal class PGACOPLMLHP : FLJLMKCIEIM, JOOHDJKBMLK, FCCMCMPLEOO, KMADININNGI
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct CIAJCCLJLEO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private readonly PGACOPLMLHP HKNGNFLDPKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly bool FFCANDIIMHC;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x15EEE20", Offset = "0x15EE220", VA = "0x1815EEE20")]
		public CIAJCCLJLEO(PGACOPLMLHP HKNGNFLDPKM, bool FFCANDIIMHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x778A600", Offset = "0x7789A00", VA = "0x18778A600")]
		public Queue<MENDICGFDOF>.Enumerator NFFMPMPKJEP()
		{
			return default(Queue<MENDICGFDOF>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x778A2C0", Offset = "0x77896C0", VA = "0x18778A2C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[DependsOn]
	private KFKIFDIIJNI BACCPECICEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[DependsOn]
	private AANGCNHJCJP OGOHKBICCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private List<NativeList<PDDAJOGDNBJ>> ANICJNMOMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<(Entity, List<GameObject>)> IPNIHADAJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<NPNDLLJKHLE> OGGBGIAGILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private OLDAJHMKDCE<MENDICGFDOF> LIDCMPNFDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private OLDAJHMKDCE<MLPAAKFFJII> HELMEPKAAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private OLDAJHMKDCE<CDBODDOEOEE> BLJMEHIEHOI;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x779B140", Offset = "0x779A540", VA = "0x18779B140", Slot = "4")]
	public void InitReferences(FHGOKBONFMJ BHDEAEIFGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x779B7F0", Offset = "0x779ABF0", VA = "0x18779B7F0")]
	public void PAMFBBHNIFP(NativeList<PDDAJOGDNBJ> GJKIEADAMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x779B690", Offset = "0x779AA90", VA = "0x18779B690")]
	public void OPEHIOGHAHG(Entity HKNGNFLDPKM, [In] LAEKEAJIIJD<GameObject> FOBCOBGNKON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x779B600", Offset = "0x779AA00", VA = "0x18779B600")]
	public void NBDKALEDGGD(NativeList<NPNDLLJKHLE> OHJJNNCOGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x779AF10", Offset = "0x779A310", VA = "0x18779AF10")]
	public void FHGLGKFPCFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x779A920", Offset = "0x7799D20", VA = "0x18779A920")]
	public void DMDMDFLKOGM(FKAMLBHGFOI FDIJEKJEAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x779AE70", Offset = "0x779A270", VA = "0x18779AE70")]
	public JobHandle DNBOKNIGNDB([In] MENDICGFDOF LPIFIOEEOGF, JobHandle CCIHKBAJMML)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x779ADD0", Offset = "0x779A1D0", VA = "0x18779ADD0")]
	public JobHandle DNBOKNIGNDB([In] MLPAAKFFJII LPIFIOEEOGF, JobHandle CCIHKBAJMML)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x748DBE0", Offset = "0x748CFE0", VA = "0x18748DBE0")]
	public CIAJCCLJLEO GFHOFGPDLBC(bool FFCANDIIMHC)
	{
		return default(CIAJCCLJLEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x779B560", Offset = "0x779A960", VA = "0x18779B560")]
	public ACFALNHABAB<MLPAAKFFJII> LHDBAPAKJDH()
	{
		return default(ACFALNHABAB<MLPAAKFFJII>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x779B5B0", Offset = "0x779A9B0", VA = "0x18779B5B0")]
	public ACFALNHABAB<CDBODDOEOEE> LPHLEKOPGOH()
	{
		return default(ACFALNHABAB<CDBODDOEOEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x779B340", Offset = "0x779A740", VA = "0x18779B340")]
	public void JIMFDDOIBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x779A840", Offset = "0x7799C40", VA = "0x18779A840", Slot = "5")]
	public void CAHNJLIHDHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x779A7D0", Offset = "0x7799BD0", VA = "0x18779A7D0", Slot = "6")]
	private void AONIDMJBHFK(FHGOKBONFMJ BHDEAEIFGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x100A030", Offset = "0x1009430", VA = "0x18100A030", Slot = "7")]
	private void EGAMOOCMNGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public PGACOPLMLHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct NEKKNEMIAIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public UniformTRS DLCIDFLLFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public StandardRenderableVisualData PMKNBAACEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public EBCIGMMPLDE GAPCIOOOOMF;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[CFHELINJLKB(Lifetime.LoadInstance)]
public struct MENDICGFDOF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Entity CFICENCPFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public NativeList<Entity> PPMNIACNFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeList<Entity> PKCEMMMKLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeParallelHashSet<Entity> MDMPFNPJHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeList<AOIKGLJHPKL> FIOIGNEEKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeList<PDDAJOGDNBJ> GJKIEADAMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeList<NEKKNEMIAIO> IIGLOEAMCBN;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7798910", Offset = "0x7797D10", VA = "0x187798910", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7798840", Offset = "0x7797C40", VA = "0x187798840")]
	public void AICKIPOBPIG(bool FFCANDIIMHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[RegisterService(typeof(AFKEFMDGFEI), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
internal class AFKEFMDGFEI : MPFPGKCBAHD, FCCMCMPLEOO, KMADININNGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[DependsOn]
	private PGACOPLMLHP DCJFGCDMNPO;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x77850C0", Offset = "0x77844C0", VA = "0x1877850C0", Slot = "4")]
	public void OLCPIKJCBII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7785070", Offset = "0x7784470", VA = "0x187785070", Slot = "5")]
	private void AONIDMJBHFK(FHGOKBONFMJ BHDEAEIFGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0xFDAD20", Offset = "0xFDA120", VA = "0x180FDAD20", Slot = "6")]
	private void EGAMOOCMNGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public AFKEFMDGFEI()
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[AlwaysUpdateSystem]
	public class PostDeserializeBakeShapesSystem : KMOEIMBPGHD, FLJLMKCIEIM
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[BurstCompile]
		private struct GatherBakedPrimitiveDataJob : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			[ReadOnly]
			public ComponentTypeHandle<StandardRenderableVisualData> visualTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalPoseData> poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalUniformScaleData> scaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			[ReadOnly]
			public ComponentTypeHandle<LocalDeformableScaleData> deformationScaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			[ReadOnly]
			public ComponentTypeHandle<ShapeConfigData> configTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			[ReadOnly]
			public ComponentTypeHandle<PrimitiveShapeData> shapeDataTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			[ReadOnly]
			public NativeParallelHashMap<int, HFCKMPNMIEL> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public NativeArray<NJJCHEPFHGH> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x77912F0", Offset = "0x77906F0", VA = "0x1877912F0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[BurstCompile]
		private struct GatherBakedSplineDataJob : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			[ReadOnly]
			public ComponentTypeHandle<SplineShapeData> splineShapeTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			[ReadOnly]
			public ComponentTypeHandle<StandardRenderableVisualData> visualTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalPoseData> poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalUniformScaleData> scaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			[ReadOnly]
			public NativeArray<PDDAJOGDNBJ> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			[ReadOnly]
			public NativeArray<AOIKGLJHPKL> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public NativeArray<NEKKNEMIAIO> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x7791690", Offset = "0x7790A90", VA = "0x187791690", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[BurstCompile]
		internal struct CalculateSplinePointEstimateJob : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			[ReadOnly]
			public BufferTypeHandle<LinkedEntityGroup> linkedEntityGroup;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x778B3B0", Offset = "0x778A7B0", VA = "0x18778B3B0", Slot = "4")]
			public void Execute(ArchetypeChunk batchInChunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[BurstCompile]
		private struct GeneratePointsJob : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000040")]
			private struct PointSrcData
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				public float3 Position;

				[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
				[Cpp2IlInjected.Token(Token = "0x40000B8")]
				public quaternion Rotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000B9")]
				public float Radius;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000BA")]
				public quaternion BlendedRotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000BB")]
				public float BendAngle;

				[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				public float BendRadius;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000BD")]
				public float DistanceToNext;

				[Cpp2IlInjected.Token(Token = "0x17000020")]
				public float3 Direction
				{
					[Cpp2IlInjected.Token(Token = "0x6000120")]
					[Cpp2IlInjected.Address(RVA = "0x77A09E0", Offset = "0x779FDE0", VA = "0x1877A09E0")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000121")]
					[Cpp2IlInjected.Address(RVA = "0x77A0990", Offset = "0x779FD90", VA = "0x1877A0990")]
					set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000041")]
			private interface IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000122")]
				[Cpp2IlInjected.Address(Slot = "0")]
				float3 GMGALMOKAMN(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000042")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0x77980E0", Offset = "0x77974E0", VA = "0x1877980E0", Slot = "5")]
				public float3 FKJIOGMKPKK(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000124")]
				[Cpp2IlInjected.Address(RVA = "0x7798480", Offset = "0x7797880", VA = "0x187798480", Slot = "4")]
				public float3 GMGALMOKAMN(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000043")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0x7799990", Offset = "0x7798D90", VA = "0x187799990", Slot = "4")]
				public float3 GMGALMOKAMN(quaternion rotation)
				{
					return default(float3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private static readonly float3 Up;

			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private static readonly float3 DirectionAxis;

			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private static readonly float3 NormalAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			[ReadOnly]
			public BufferTypeHandle<LinkedEntityGroup> pointsByEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			[ReadOnly]
			public ComponentTypeHandle<ShapeConfigData> shapeConfigTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			[ReadOnly]
			public ComponentTypeHandle<SplineShapeData> splineParametersTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> pointPositions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointRotationData> pointRotations;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> pointScales;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public NativeArray<AOIKGLJHPKL> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public NativeArray<PDDAJOGDNBJ> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x7793120", Offset = "0x7792520", VA = "0x187793120", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7794DE0", Offset = "0x77941E0", VA = "0x187794DE0")]
			private void PFDLLMMNHCM(NativeList<PointSrcData> srcData, NativeList<PDDAJOGDNBJ> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x77949D0", Offset = "0x7793DD0", VA = "0x1877949D0")]
			public static Vector3 MCPBPKOLEHG(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x7792BC0", Offset = "0x7791FC0", VA = "0x187792BC0")]
			public static quaternion AKIGGIFEFCH(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x77947A0", Offset = "0x7793BA0", VA = "0x1877947A0")]
			private static quaternion MBEIMADJABL(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7793780", Offset = "0x7792B80", VA = "0x187793780")]
			private static float3 FALANIBNNPH(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7792C40", Offset = "0x7792040", VA = "0x187792C40")]
			private static quaternion BAHCBAPDDKD(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7792EB0", Offset = "0x77922B0", VA = "0x187792EB0")]
			private static PDDAJOGDNBJ CIJFOAMMCJL(int idx, NativeList<PointSrcData> srcData)
			{
				return default(PDDAJOGDNBJ);
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x3B6DC90", Offset = "0x3B6D090", VA = "0x183B6DC90")]
			private void EKJDIOHKJNA<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7791DB0", Offset = "0x77911B0", VA = "0x187791DB0")]
			private void AGCBPMLFBEF(NativeList<PointSrcData> sourcePoints, NativeList<PDDAJOGDNBJ> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7793CB0", Offset = "0x77930B0", VA = "0x187793CB0")]
			public static float HLEIPMGIFAM(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x77945B0", Offset = "0x77939B0", VA = "0x1877945B0")]
			private static quaternion KNOJILGALAH(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x7793EC0", Offset = "0x77932C0", VA = "0x187793EC0")]
			private static PDDAJOGDNBJ IDKIGDPPBDH(PointSrcData point)
			{
				return default(PDDAJOGDNBJ);
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7793E30", Offset = "0x7793230", VA = "0x187793E30")]
			private static PDDAJOGDNBJ IDKIGDPPBDH(float3 pos, quaternion rot, float radius)
			{
				return default(PDDAJOGDNBJ);
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x77940B0", Offset = "0x77934B0", VA = "0x1877940B0")]
			private static bool INJOHBHHPIP(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7793FE0", Offset = "0x77933E0", VA = "0x187793FE0")]
			private static float3 IGMGAIBECAI(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7793B00", Offset = "0x7792F00", VA = "0x187793B00")]
			public static float3 GLHGLIGAMMG(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7793950", Offset = "0x7792D50", VA = "0x187793950")]
			public static float3 FKJIOGMKPKK(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7794150", Offset = "0x7793550", VA = "0x187794150")]
			private static quaternion JPCEAFFOOJD(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7792CD0", Offset = "0x77920D0", VA = "0x187792CD0")]
			private static float CDBKKMNNKEO(float3 from, float3 to)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeBakeShapesSystem_LambdaJob_0_Job : IJobEntityBatchWithIndex
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public EntityCommandBuffer.ParallelWriter ecbWriter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public BufferTypeHandle<LinkedEntityGroup> __splineAndPointsTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x77A27C0", Offset = "0x77A1BC0", VA = "0x1877A27C0")]
			private void EBPOPGCIHKA(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x77A28A0", Offset = "0x77A1CA0", VA = "0x1877A28A0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex, int indexOfFirstEntityInQuery)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct TrimSplinePointExcess_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			[ReadOnly]
			public NativeArray<int> pointCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public NativeList<PDDAJOGDNBJ> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x77A43B0", Offset = "0x77A37B0", VA = "0x1877A43B0")]
			private void EBPOPGCIHKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x77A4410", Offset = "0x77A3810", VA = "0x1877A4410", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct SetSplinePointCapacity_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public NativeList<PDDAJOGDNBJ> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x77A4350", Offset = "0x77A3750", VA = "0x1877A4350")]
			private void EBPOPGCIHKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x77A43A0", Offset = "0x77A37A0", VA = "0x1877A43A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct GatherPrimitivesAndUniqueParents_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> parentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public NativeList<Entity> parents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public NativeParallelHashSet<Entity> uniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public NativeList<NJJCHEPFHGH> data;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x77919D0", Offset = "0x7790DD0", VA = "0x1877919D0")]
			private void EBPOPGCIHKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7791B90", Offset = "0x7790F90", VA = "0x187791B90", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct GatherSplinesAndUniqueParents_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> parentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public NativeList<Entity> splines;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public NativeList<Entity> parents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public NativeParallelHashSet<Entity> uniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public NativeList<AOIKGLJHPKL> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public NativeList<NEKKNEMIAIO> bakedData;

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7791BA0", Offset = "0x7790FA0", VA = "0x187791BA0")]
			private void EBPOPGCIHKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x7791DA0", Offset = "0x77911A0", VA = "0x187791DA0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct RemoveDestroyedEntitiesFromParents_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			[ReadOnly]
			public NativeList<Entity> splineParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			[ReadOnly]
			public NativeList<Entity> splineEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public BufferFromEntity<ChildBuffer> childrenFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x77A3F20", Offset = "0x77A3320", VA = "0x1877A3F20")]
			private void EBPOPGCIHKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x77A4340", Offset = "0x77A3740", VA = "0x1877A4340", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private static readonly HLBHMADGLFA log;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private const int PointEstimateIndex = 0;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private const int PointCountIndex = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private EntityQuery splineQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private EntityQuery primitiveQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private HCFHEHNKMCF replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private KFKIFDIIJNI objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private PGACOPLMLHP bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private ICDMILMGDEJ ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x77A1A70", Offset = "0x77A0E70", VA = "0x1877A1A70", Slot = "15")]
		public override void InitReferences(FHGOKBONFMJ services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x77A3860", Offset = "0x77A2C60", VA = "0x1877A3860", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x77A3950", Offset = "0x77A2D50", VA = "0x1877A3950", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x77A39B0", Offset = "0x77A2DB0", VA = "0x1877A39B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x77A2FB0", Offset = "0x77A23B0", VA = "0x1877A2FB0")]
		private JobHandle MENMLIDJFKC(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x77A0A00", Offset = "0x779FE00", VA = "0x1877A0A00")]
		private JobHandle BNICKOKOIPB(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x77A1710", Offset = "0x77A0B10", VA = "0x1877A1710")]
		private JobHandle FHLKGCDKHNA(NativeArray<int> pointCount, NativeList<PDDAJOGDNBJ> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x77A10C0", Offset = "0x77A04C0", VA = "0x1877A10C0")]
		private JobHandle CGGJBAPCPKG(NativeList<PDDAJOGDNBJ> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x77A2AE0", Offset = "0x77A1EE0", VA = "0x1877A2AE0")]
		private JobHandle MBLFPILFEEC(EntityQuery query, NativeList<AOIKGLJHPKL> splinePointRanges, NativeList<PDDAJOGDNBJ> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x77A32F0", Offset = "0x77A26F0", VA = "0x1877A32F0")]
		private JobHandle MMDODBMJLII(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x77A15F0", Offset = "0x77A09F0", VA = "0x1877A15F0")]
		private JobHandle EHDEMFEGGDP(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x77A1BF0", Offset = "0x77A0FF0", VA = "0x1877A1BF0")]
		private JobHandle KGIFAIHANHM(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<NJJCHEPFHGH> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x77A17B0", Offset = "0x77A0BB0", VA = "0x1877A17B0")]
		private JobHandle ILDBHMDCBPF(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<AOIKGLJHPKL> splinePointRanges, [Out] NativeList<NEKKNEMIAIO> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x77A3B20", Offset = "0x77A2F20", VA = "0x1877A3B20")]
		private JobHandle POPNBDOJJDE(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x77A1E90", Offset = "0x77A1290", VA = "0x1877A1E90")]
		private JobHandle LJJBFNDMEGJ(EntityQuery query, NativeList<NJJCHEPFHGH> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x77A23A0", Offset = "0x77A17A0", VA = "0x1877A23A0")]
		private static NativeParallelHashMap<int, HFCKMPNMIEL> LMIJBAAKPMM()
		{
			return default(NativeParallelHashMap<int, HFCKMPNMIEL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x77A1160", Offset = "0x77A0560", VA = "0x1877A1160")]
		private JobHandle CKDEAKDAMDP(EntityQuery query, NativeList<AOIKGLJHPKL> splinePointRanges, NativeList<PDDAJOGDNBJ> splinePointData, NativeList<NEKKNEMIAIO> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x77A1B10", Offset = "0x77A0F10", VA = "0x1877A1B10")]
		private JobHandle JHANDLOHIPC(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x77A1710", Offset = "0x77A0B10", VA = "0x1877A1710")]
		private JobHandle PLOHFGDFMKJ(NativeArray<int> pointCount, NativeList<PDDAJOGDNBJ> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x77A10C0", Offset = "0x77A04C0", VA = "0x1877A10C0")]
		private JobHandle JJPGGKJOEFK(NativeList<PDDAJOGDNBJ> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x77A1500", Offset = "0x77A0900", VA = "0x1877A1500")]
		private JobHandle DNGNOGEBOCK(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<NJJCHEPFHGH> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x77A3410", Offset = "0x77A2810", VA = "0x1877A3410")]
		private JobHandle NMFGAMPKGNO(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<AOIKGLJHPKL> ranges, NativeList<NEKKNEMIAIO> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x77A2990", Offset = "0x77A1D90", VA = "0x1877A2990")]
		private JobHandle MBIINJBGADH(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x77A3520", Offset = "0x77A2920", VA = "0x1877A3520", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x77866D0", Offset = "0x7785AD0", VA = "0x1877866D0")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class DAHIHKHIIMO : OKBGABKHKPB, FLJLMKCIEIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private PGACOPLMLHP DCJFGCDMNPO;

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x778B4F0", Offset = "0x778A8F0", VA = "0x18778B4F0", Slot = "14")]
	public void InitReferences(FHGOKBONFMJ BHDEAEIFGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x778B540", Offset = "0x778A940", VA = "0x18778B540", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x27FBB00", Offset = "0x27FAF00", VA = "0x1827FBB00")]
	public DAHIHKHIIMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
[AlwaysUpdateSystem]
public class PIGNHHGFMAL : KMOEIMBPGHD, FLJLMKCIEIM
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private struct FGKBFFMDGKM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private EntityManager HIKDABPFHKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private BCEPIHFMLCM<T> FFEACDIHDEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> KFAFNPBPIAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private int FFCBHHABFJN;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) ODFFHKFHEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x44FCA50", Offset = "0x44FBE50", VA = "0x1844FCA50")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x44FCCB0", Offset = "0x44FC0B0", VA = "0x1844FCCB0")]
		public FGKBFFMDGKM(EntityManager HIKDABPFHKC, BCEPIHFMLCM<T> FFEACDIHDEE, NativeArray<EntityRemapUtility.EntityRemapInfo> KFAFNPBPIAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x41DF5D0", Offset = "0x41DE9D0", VA = "0x1841DF5D0")]
		public FGKBFFMDGKM<T> NFFMPMPKJEP()
		{
			return default(FGKBFFMDGKM<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x44FC2D0", Offset = "0x44FB6D0", VA = "0x1844FC2D0")]
		public bool HGNGIMJAKLP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly HLBHMADGLFA OLJCIIPAAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private AANGCNHJCJP OGOHKBICCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private PGACOPLMLHP DCJFGCDMNPO;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x779D160", Offset = "0x779C560", VA = "0x18779D160", Slot = "15")]
	public override void InitReferences(FHGOKBONFMJ BHDEAEIFGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x779D130", Offset = "0x779C530", VA = "0x18779D130")]
	public void HDKPFJEGFOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x779F760", Offset = "0x779EB60", VA = "0x18779F760", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x779E680", Offset = "0x779DA80", VA = "0x18779E680")]
	private void OEEGJOJOJPL(CDBODDOEOEE LPIFIOEEOGF, Mesh[] GFBBPBMKJOM, NativeArray<EntityRemapUtility.EntityRemapInfo> KFAFNPBPIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3670410", Offset = "0x366F810", VA = "0x183670410")]
	private FGKBFFMDGKM<T> NJCPFKJAMMF<T>(BCEPIHFMLCM<T> FFEACDIHDEE, NativeArray<EntityRemapUtility.EntityRemapInfo> KFAFNPBPIAA) where T : struct
	{
		return default(FGKBFFMDGKM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x779BD80", Offset = "0x779B180", VA = "0x18779BD80")]
	private void AIIACGGGJHH(Transform HKNGNFLDPKM, NativeArray<JHDGDEJGLFH> ECJAHAPIIGC, LAEKEAJIIJD<GameObject> HAPCHDICBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x779C710", Offset = "0x779BB10", VA = "0x18779C710")]
	private void CPPNDFNKBBE(Transform HKNGNFLDPKM, NativeArray<DDHOKDDOCED> LJPJHEHFJGK, LAEKEAJIIJD<GameObject> HAPCHDICBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x779C260", Offset = "0x779B660", VA = "0x18779C260")]
	private void BIBAOADALKB(Transform HKNGNFLDPKM, NativeArray<OLLHANAGEKM> MMMIDHDEONJ, LAEKEAJIIJD<GameObject> HAPCHDICBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x779DD50", Offset = "0x779D150", VA = "0x18779DD50")]
	private void KNAMLGJNMPP(Transform HKNGNFLDPKM, NativeArray<AFBJOBAONJO> GFBBPBMKJOM, Mesh[] LKPONADGMEH, LAEKEAJIIJD<GameObject> HAPCHDICBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x779C110", Offset = "0x779B510", VA = "0x18779C110")]
	private static void AILLGLGACHK(NativeParallelHashSet<Entity> PPMNIACNFOH, NativeParallelHashSet<Entity> EKOKJHMOBPF, NativeArray<EntityRemapUtility.EntityRemapInfo> KFAFNPBPIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x779C650", Offset = "0x779BA50", VA = "0x18779C650")]
	private static void CDNGHMJDELE(NativeList<Entity> DBJKHFJBKPC, NativeArray<EntityRemapUtility.EntityRemapInfo> KFAFNPBPIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x779D1E0", Offset = "0x779C5E0", VA = "0x18779D1E0")]
	private NativeParallelHashMap<Entity, IKCBDIPCJFN> KHOHMIJAMGG(PGACOPLMLHP.CIAJCCLJLEO LIIHGLGMGLC, ACFALNHABAB<MLPAAKFFJII> CMDMHOLBIBK, List<GameObject> HAPCHDICBJL)
	{
		return default(NativeParallelHashMap<Entity, IKCBDIPCJFN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x779E580", Offset = "0x779D980", VA = "0x18779E580")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> OBKJAEFIPBE(Entity FFCEELPMPGF)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x779CBE0", Offset = "0x779BFE0", VA = "0x18779CBE0")]
	private void FEKOAKJCKJC(NativeList<Entity> CCIEFKGOAMI, NativeList<Entity> MCEOBJGGNFN, NativeParallelHashMap<Entity, IKCBDIPCJFN> GGKLEOPCNPD, NativeList<AOIKGLJHPKL> FNHHHDIMBMF, NativeList<PDDAJOGDNBJ> CCNDGLMAMGE, NativeList<NEKKNEMIAIO> ANICJNMOMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x779E190", Offset = "0x779D590", VA = "0x18779E190")]
	private void MJNDMHGLPIK(NativeList<Entity> PPMNIACNFOH, NativeList<Entity> PKCEMMMKLFF, NativeParallelHashMap<Entity, IKCBDIPCJFN> GGKLEOPCNPD, NativeList<NJJCHEPFHGH> BBFOPFCDACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x77866D0", Offset = "0x7785AD0", VA = "0x1877866D0")]
	public PIGNHHGFMAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public abstract class DDHOCFOIHBO : JEEEDEFFFJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly UniformTRS DLCIDFLLFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly OECCNICKBHM HKNGNFLDPKM;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private GameObject BDDGIMBNFFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS FPENMKCJLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x778C1A0", Offset = "0x778B5A0", VA = "0x18778C1A0", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 BJEDDILIBOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x778C150", Offset = "0x778B550", VA = "0x18778C150", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 FJILCPJAPGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x778C2D0", Offset = "0x778B6D0", VA = "0x18778C2D0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 IOGKHCLHAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x778C010", Offset = "0x778B410", VA = "0x18778C010", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x778C100", Offset = "0x778B500", VA = "0x18778C100", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion MAJHOLILBEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x778C060", Offset = "0x778B460", VA = "0x18778C060", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x778C370", Offset = "0x778B770", VA = "0x18778C370", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 JDIHHCNMCPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x778C320", Offset = "0x778B720", VA = "0x18778C320", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 LHIBFHJBKLL
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x778C0B0", Offset = "0x778B4B0", VA = "0x18778C0B0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 ILPDCCIKMCN
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x778C280", Offset = "0x778B680", VA = "0x18778C280", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x778C3C0", Offset = "0x778B7C0", VA = "0x18778C3C0")]
	public DDHOCFOIHBO(UniformTRS DLCIDFLLFKP, OECCNICKBHM HKNGNFLDPKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public abstract class OIHHMBAJKJK : DDHOCFOIHBO, EOFEGJKNAFF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly float ILNCJACLHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly float3 CGIPKOIFBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly KJLMKLABEMK IMIBEEOGNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly KOCPEJPPMDN CBHBGIDDABE;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private ANJIJJGNKJL LJFIMPEDPNG
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7799DE0", Offset = "0x77991E0", VA = "0x187799DE0", Slot = "17")]
		get
		{
			return default(ANJIJJGNKJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS OOIMODMLINO
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7799D00", Offset = "0x7799100", VA = "0x187799D00", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float PFDCFDPOAEK
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xAEF480", Offset = "0xAEE880", VA = "0x180AEF480", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 BHEGCMNNCIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7799CB0", Offset = "0x77990B0", VA = "0x187799CB0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private KJLMKLABEMK FDIKBNPKHAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xD32200", Offset = "0xD31600", VA = "0x180D32200", Slot = "21")]
		get
		{
			return default(KJLMKLABEMK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private KOCPEJPPMDN LCHNOAGDMIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x11CF0F0", Offset = "0x11CE4F0", VA = "0x1811CF0F0", Slot = "22")]
		get
		{
			return default(KOCPEJPPMDN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool HDODJPJHCCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool BDFIIFNIPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7799E30", Offset = "0x7799230", VA = "0x187799E30")]
	protected OIHHMBAJKJK(UniformTRS DLCIDFLLFKP, OECCNICKBHM HKNGNFLDPKM, float ILNCJACLHFE, float3 CGIPKOIFBOM, KJLMKLABEMK IMIBEEOGNLO, KOCPEJPPMDN CBHBGIDDABE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract UnityEngine.Hash128 ComputeHash();

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class BOBCODMCCGF : JEEEDEFFFJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	protected readonly DHFHGDGMDKP INABPBPJONL;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	protected OECCNICKBHM DPIDLKACMMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xFDC0C0", Offset = "0xFDB4C0", VA = "0x180FDC0C0")]
		get
		{
			return default(OECCNICKBHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity FOFFOEGGMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7789C80", Offset = "0x7789080", VA = "0x187789C80")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected KFKIFDIIJNI IJMPMHPKPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7789830", Offset = "0x7788C30", VA = "0x187789830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected HFNLENKMAKG DHKIGECHBOH
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7789A90", Offset = "0x7788E90", VA = "0x187789A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected PKHIKGNKLCD LAGHPAJNDJF
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7789A00", Offset = "0x7788E00", VA = "0x187789A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject BDDGIMBNFFI
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7789DC0", Offset = "0x77891C0", VA = "0x187789DC0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS FPENMKCJLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x1010620", Offset = "0x100FA20", VA = "0x181010620", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 BJEDDILIBOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7789740", Offset = "0x7788B40", VA = "0x187789740", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 FJILCPJAPGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7789AF0", Offset = "0x7788EF0", VA = "0x187789AF0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 IOGKHCLHAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7789220", Offset = "0x7788620", VA = "0x187789220", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7789630", Offset = "0x7788A30", VA = "0x187789630", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion MAJHOLILBEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7789350", Offset = "0x7788750", VA = "0x187789350", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7789DF0", Offset = "0x77891F0", VA = "0x187789DF0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 JDIHHCNMCPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7789CD0", Offset = "0x77890D0", VA = "0x187789CD0", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 LHIBFHJBKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7789470", Offset = "0x7788870", VA = "0x187789470", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 ILPDCCIKMCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7789840", Offset = "0x7788C40", VA = "0x187789840", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0xCEDC30", Offset = "0xCED030", VA = "0x180CEDC30")]
	protected BOBCODMCCGF(DHFHGDGMDKP JPJAODCKADG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7789CA0", Offset = "0x77890A0", VA = "0x187789CA0")]
	public static ANJIJJGNKJL JKGHIELMIOO(BOBCODMCCGF MPAMMAGABHA)
	{
		return default(ANJIJJGNKJL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class KGNMBMIHNJC
{
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x77974B0", Offset = "0x77968B0", VA = "0x1877974B0")]
	public static void HCCFAEEKNKM(NativeArray<Entity> PPMNIACNFOH, EntityManager HIKDABPFHKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class LBHGKLLCKLD
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x77976F0", Offset = "0x7796AF0", VA = "0x1877976F0")]
	public static void GCDFBNMJLML(NativeArray<Entity> PPMNIACNFOH, EntityManager HIKDABPFHKC, FKAMLBHGFOI CIFIKMJOJND, KFKIFDIIJNI FFCFBJDHKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7797DD0", Offset = "0x77971D0", VA = "0x187797DD0")]
	public static void NLOLKOBAEEH(NativeArray<Entity> PPMNIACNFOH, EntityManager HIKDABPFHKC, FKAMLBHGFOI CIFIKMJOJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7797D90", Offset = "0x7797190", VA = "0x187797D90")]
	public static NativeList<Entity> JAPLAHCNBOA(NativeArray<Entity> PPMNIACNFOH, EntityManager HIKDABPFHKC)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7797AF0", Offset = "0x7796EF0", VA = "0x187797AF0")]
	public static NativeList<Entity> IHMLCDOKLGH(NativeArray<Entity> PPMNIACNFOH, EntityManager HIKDABPFHKC)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7797B30", Offset = "0x7796F30", VA = "0x187797B30")]
	private static NativeList<Entity> JAPLAHCNBOA(NativeArray<Entity> PPMNIACNFOH, EntityManager HIKDABPFHKC, bool HKIHJCNNOMI)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public abstract class LOEFMNODIKE : BOBCODMCCGF, EOFEGJKNAFF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private float ILNCJACLHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private Vector3 CGIPKOIFBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private KJLMKLABEMK IMIBEEOGNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private KOCPEJPPMDN CBHBGIDDABE;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected EntityManager OOOLJCPPJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x77A5140", Offset = "0x77A4540", VA = "0x1877A5140")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected GAMNGGOOCAB INEKPIGLFKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x77A50B0", Offset = "0x77A44B0", VA = "0x1877A50B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData MHCIJLJOLCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x77A51D0", Offset = "0x77A45D0", VA = "0x1877A51D0")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private ANJIJJGNKJL LJFIMPEDPNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7789CA0", Offset = "0x77890A0", VA = "0x187789CA0", Slot = "17")]
		get
		{
			return default(ANJIJJGNKJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float PFDCFDPOAEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xDED8E0", Offset = "0xDECCE0", VA = "0x180DED8E0", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 BHEGCMNNCIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x1416D70", Offset = "0x1416170", VA = "0x181416D70", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private KJLMKLABEMK FDIKBNPKHAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x968340", Offset = "0x967740", VA = "0x180968340", Slot = "21")]
		get
		{
			return default(KJLMKLABEMK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private KOCPEJPPMDN LCHNOAGDMIB
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xB69AB0", Offset = "0xB68EB0", VA = "0x180B69AB0", Slot = "22")]
		get
		{
			return default(KOCPEJPPMDN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS OOIMODMLINO
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x77A5110", Offset = "0x77A4510", VA = "0x1877A5110", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool BDFIIFNIPCH
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x993140", Offset = "0x992540", VA = "0x180993140", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x992EC0", Offset = "0x9922C0", VA = "0x180992EC0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool HDODJPJHCCN
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x77A5450", Offset = "0x77A4850", VA = "0x1877A5450")]
	protected LOEFMNODIKE(DHFHGDGMDKP JPJAODCKADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x77A52C0", Offset = "0x77A46C0", VA = "0x1877A52C0", Slot = "26")]
	public virtual void PCKKFECIKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class KMOEIMBPGHD : OKBGABKHKPB, FLJLMKCIEIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	protected KFKIFDIIJNI FFCFBJDHKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private DAANGIHLEKL GDFLHALIOAL;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	protected FKAMLBHGFOI CELNEGKHPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x77A4FF0", Offset = "0x77A43F0", VA = "0x1877A4FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected NCIAIDEDLKA JNCMPGGBFNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x77A4FA0", Offset = "0x77A43A0", VA = "0x1877A4FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x77A5040", Offset = "0x77A4440", VA = "0x1877A5040", Slot = "15")]
	public virtual void InitReferences(FHGOKBONFMJ BHDEAEIFGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x27FBB00", Offset = "0x27FAF00", VA = "0x1827FBB00")]
	protected KMOEIMBPGHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class NIGNEOLCMCA
{
	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x77A5480", Offset = "0x77A4880", VA = "0x1877A5480")]
	public static void IPELBCIGLLL(NativeArray<Entity> CCIEFKGOAMI, EntityManager HIKDABPFHKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3593237264
{
	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x77A5890", Offset = "0x77A4C90", VA = "0x1877A5890")]
	public static void HIAMNDAEINL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x77A5880", Offset = "0x77A4C80", VA = "0x1877A5880")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class KBOLDDKILPM : ContainerPropertyBag<ILGEJFPDAPJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x77A4F40", Offset = "0x77A4340", VA = "0x1877A4F40")]
	public KBOLDDKILPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal class ENKKAHHLGBF : ContainerPropertyBag<BEEIIJCPNHA>
{
	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x77A4EE0", Offset = "0x77A42E0", VA = "0x1877A4EE0")]
	public ENKKAHHLGBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class BOFMPHLLGOE : ContainerPropertyBag<GBCOGCFOGBE>
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x77A4E80", Offset = "0x77A4280", VA = "0x1877A4E80")]
	public BOFMPHLLGOE()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x77A56C0", Offset = "0x77A4AC0", VA = "0x1877A56C0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
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
