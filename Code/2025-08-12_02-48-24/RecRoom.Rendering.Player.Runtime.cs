using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rendering_Player_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : EJFLMJDOOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8CB5BC0", Offset = "0x8CB41C0", VA = "0x188CB5BC0", Slot = "4")]
		public override void CBPAAEAGBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Rendering_Player_Runtime
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
		private ServiceBitset bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8623C50", Offset = "0x8622250", VA = "0x188623C50", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8CB6B40", Offset = "0x8CB5140", VA = "0x188CB6B40")]
		private void DHALDHDBNEP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8CB6FB0", Offset = "0x8CB55B0", VA = "0x188CB6FB0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8CB6D80", Offset = "0x8CB5380", VA = "0x188CB6D80", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8CB7010", Offset = "0x8CB5610", VA = "0x188CB7010")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface IJHHJECDLHN
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int? KCGACOABFGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool? ONLFELMHFJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NLOEDPNDFGF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LNBNIGOLGAJ();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FMBPFJEMMAN : IJHHJECDLHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly string OEOJAHLPBHJ;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly string ACLACIOJEOE;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly string FLACDJBJKFN;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly string PBOEBMAGOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private BDAGHMMFHLO IJDHMHFDIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private int? DOLMLBCGGFP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int? KCGACOABFGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool NLOEDPNDFGF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA95030", Offset = "0xA93630", VA = "0x180A95030", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA94FC0", Offset = "0xA935C0", VA = "0x180A94FC0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool? ONLFELMHFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8CB4F80", Offset = "0x8CB3580", VA = "0x188CB4F80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA9AB40", Offset = "0xA99140", VA = "0x180A9AB40")]
	[UnityEngine.Scripting.Preserve]
	public FMBPFJEMMAN([OEKMEJFDAAI(null)][NotNull] BDAGHMMFHLO ANHHCBNKCPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8CB46E0", Offset = "0x8CB2CE0", VA = "0x188CB46E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8CB4670", Offset = "0x8CB2C70", VA = "0x188CB4670")]
	[LAFCEDCMNGK.LDGLOLCMPLF.AALIAIEKGHF]
	[UsedImplicitly]
	public static void DCHONHFJNJE(CFPMHDJNIAH LOLOEONEEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8CB4E80", Offset = "0x8CB3480", VA = "0x188CB4E80", Slot = "5")]
	public void LNBNIGOLGAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8CB47E0", Offset = "0x8CB2DE0", VA = "0x188CB47E0")]
	private void GHCECFCCCAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8CB4DA0", Offset = "0x8CB33A0", VA = "0x188CB4DA0")]
	private bool HNMPIJJKNIK(string AFEPENAPHHJ, [Out] LBDAAPBJIBD CCNLCODIMEN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GGCAMKFFFEB
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOCJIGPLANA();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class GKCKIJEFCDO : GGCAMKFFFEB
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class FNOIPFHGCKE : IEnumerator<BJJPNELKDDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private BJJPNELKDDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public GKCKIJEFCDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private BJJPNELKDDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
		[DebuggerHidden]
		public FNOIPFHGCKE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8CB5160", Offset = "0x8CB3760", VA = "0x188CB5160", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8CB5250", Offset = "0x8CB3850", VA = "0x188CB5250", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private APLPOCKIJEJ EKDDBJCMFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int HDEAIHFLEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool? MHFIIOPPHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool OJBFFNBFBOB;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static IDGHEFJHGEI BGPBGJMOAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HashSet<string> FDBFBFHNDIO;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8CB5AA0", Offset = "0x8CB40A0", VA = "0x188CB5AA0")]
	[UnityEngine.Scripting.Preserve]
	public GKCKIJEFCDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8CB5490", Offset = "0x8CB3A90", VA = "0x188CB5490")]
	private APLPOCKIJEJ FIJCHJFGOEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8CB5990", Offset = "0x8CB3F90", VA = "0x188CB5990")]
	[IteratorStateMachine(typeof(FNOIPFHGCKE))]
	private IEnumerator<BJJPNELKDDJ> PCHAOEAOAEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8CB55A0", Offset = "0x8CB3BA0", VA = "0x188CB55A0")]
	private void LHCMLECKIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8CB52A0", Offset = "0x8CB38A0", VA = "0x188CB52A0")]
	[LAFCEDCMNGK.DCDCJCFDIHP]
	public static void DCHONHFJNJE(CFPMHDJNIAH LOLOEONEEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8CB5310", Offset = "0x8CB3910", VA = "0x188CB5310", Slot = "4")]
	public void DOCJIGPLANA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(MDPMBNABKPG), new string[] { })]
public class MDPMBNABKPG : BEEMKDJGJGG, LKJPKMELKMK
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class DKGHODBGNHG : IEnumerator<BJJPNELKDDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private BJJPNELKDDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public MDPMBNABKPG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private BJJPNELKDDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
		[DebuggerHidden]
		public DKGHODBGNHG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8CB4400", Offset = "0x8CB2A00", VA = "0x188CB4400", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8CB4620", Offset = "0x8CB2C20", VA = "0x188CB4620", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private IJHHJECDLHN JGNLELJDEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private KMNENFMKNHB HOAIDOADHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private IDisposable HGOCPGPOLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private IDisposable PKNFJLGEPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private HashSet<ReflectionProbe> MLJFDCLDOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private bool MNCFPPKKMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private bool EMMHLNIOPIN;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8CB6AB0", Offset = "0x8CB50B0", VA = "0x188CB6AB0")]
	[UnityEngine.Scripting.Preserve]
	public MDPMBNABKPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8CB61E0", Offset = "0x8CB47E0", VA = "0x188CB61E0", Slot = "4")]
	public void InitExternal(MKDGNELEFKI MMELACBKGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8CB5FF0", Offset = "0x8CB45F0", VA = "0x188CB5FF0")]
	private void FJMGEIJCMOE(Scene BAJOEIOPANB, LoadSceneMode DIOAIFIFBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8CB6030", Offset = "0x8CB4630", VA = "0x188CB6030")]
	private void ILAKNJAMGKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8CB6360", Offset = "0x8CB4960", VA = "0x188CB6360")]
	private void KLEJMPCICPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8CB5E30", Offset = "0x8CB4430", VA = "0x188CB5E30")]
	private (ReflectionProbe, int) EHJCPJFFKKJ()
	{
		return default((ReflectionProbe, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8CB5DB0", Offset = "0x8CB43B0", VA = "0x188CB5DB0")]
	[IteratorStateMachine(typeof(DKGHODBGNHG))]
	private IEnumerator<BJJPNELKDDJ> DNICMOEKEHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8CB5CD0", Offset = "0x8CB42D0", VA = "0x188CB5CD0")]
	private void CHKEMPEPKMB([CanBeNull] ReflectionProbe ODJFCLJIKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8CB6000", Offset = "0x8CB4600", VA = "0x188CB6000")]
	private void GFLMLJDBBAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8CB68F0", Offset = "0x8CB4EF0", VA = "0x188CB68F0")]
	private void OMEFDFKPNDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8CB6940", Offset = "0x8CB4F40", VA = "0x188CB6940", Slot = "5")]
	public void PILPLNBAOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8CB6440", Offset = "0x8CB4A40", VA = "0x188CB6440")]
	[CompilerGenerated]
	private void LMNLJNHEKNF()
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
