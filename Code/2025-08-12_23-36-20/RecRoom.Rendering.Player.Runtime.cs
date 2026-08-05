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
	public class LogRegistrationIndex : GDJKPKDCEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8BC4A20", Offset = "0x8BC3820", VA = "0x188BC4A20", Slot = "4")]
		public override void FAIIODDINIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
			[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8543CB0", Offset = "0x8542AB0", VA = "0x188543CB0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5740", Offset = "0x8BC4540", VA = "0x188BC5740")]
		private void EDICDPMMNIG(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5BC0", Offset = "0x8BC49C0", VA = "0x188BC5BC0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5990", Offset = "0x8BC4790", VA = "0x188BC5990", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5C20", Offset = "0x8BC4A20", VA = "0x188BC5C20")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LBNPDHMCBML
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int? JCPEMGLMOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool? MDBAFCLGMHN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KAPEKMAJAJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CMCEJCHLLNF();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class PKBLACPGIOF : LBNPDHMCBML, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly string CFNKNCIPEOL;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly string MAIGDEDFGDO;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly string DIEDIOPLPDM;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly string EMFAACFCKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HCNPPOOIDEE KDEKLBPLJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private int? NPFECEDPFCO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int? JCPEMGLMOCD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool KAPEKMAJAJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA98D20", Offset = "0xA97B20", VA = "0x180A98D20", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA98C40", Offset = "0xA97A40", VA = "0x180A98C40")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool? MDBAFCLGMHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5510", Offset = "0x8BC4310", VA = "0x188BC5510", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
	[UnityEngine.Scripting.Preserve]
	public PKBLACPGIOF([POMNKOCGGBN(null)][NotNull] HCNPPOOIDEE PCFBHCOALKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8BC4D70", Offset = "0x8BC3B70", VA = "0x188BC4D70", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8BC5560", Offset = "0x8BC4360", VA = "0x188BC5560")]
	[NKOKDPHOKEP.EPFIDDHPHJC.MBGBOEIIBBL]
	[UsedImplicitly]
	public static void OOIEJCFMCCB(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8BC4C70", Offset = "0x8BC3A70", VA = "0x188BC4C70", Slot = "5")]
	public void CMCEJCHLLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8BC4E70", Offset = "0x8BC3C70", VA = "0x188BC4E70")]
	private void EBMDDIFCHFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8BC5430", Offset = "0x8BC4230", VA = "0x188BC5430")]
	private bool IHLJAGECLLK(string KCOEKLOHCPK, [Out] FKNHDDDMCFM NMNPAHHOJKF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface EAGKGHAKIMM
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BJGMBKECLBC();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class GCADEIFMCBI : EAGKGHAKIMM
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class MDOOBEJGPEP : IEnumerator<PHFDFIIIMCE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private PHFDFIIIMCE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public GCADEIFMCBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private PHFDFIIIMCE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
		[DebuggerHidden]
		public MDOOBEJGPEP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8BC4B30", Offset = "0x8BC3930", VA = "0x188BC4B30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8BC4C20", Offset = "0x8BC3A20", VA = "0x188BC4C20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private GMJHELKMAKL ANJAAFFHGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int PDEEOPPINAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool? IEEHMJIOFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool NIKKALFFMEM;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static ALMLLDBPKBM DKNLCGELOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HashSet<string> HBPJHKPPIMJ;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8BC3A70", Offset = "0x8BC2870", VA = "0x188BC3A70")]
	[UnityEngine.Scripting.Preserve]
	public GCADEIFMCBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8BC3280", Offset = "0x8BC2080", VA = "0x188BC3280")]
	private GMJHELKMAKL AGIKFEFDMGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8BC3510", Offset = "0x8BC2310", VA = "0x188BC3510")]
	[IteratorStateMachine(typeof(MDOOBEJGPEP))]
	private IEnumerator<PHFDFIIIMCE> DLBGMIGMEAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8BC3600", Offset = "0x8BC2400", VA = "0x188BC3600")]
	private void PHGMEJIDEHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8BC3590", Offset = "0x8BC2390", VA = "0x188BC3590")]
	[NKOKDPHOKEP.APMGAGDLDLC]
	public static void OOIEJCFMCCB(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8BC3390", Offset = "0x8BC2190", VA = "0x188BC3390", Slot = "4")]
	public void BJGMBKECLBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(GNBFHJLBDBH), new string[] { })]
public class GNBFHJLBDBH : MLOBALCJPKH, JDBGEACJNEG
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class FCFOLGFANBP : IEnumerator<PHFDFIIIMCE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private PHFDFIIIMCE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public GNBFHJLBDBH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private PHFDFIIIMCE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
		[DebuggerHidden]
		public FCFOLGFANBP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3010", Offset = "0x8BC1E10", VA = "0x188BC3010", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3230", Offset = "0x8BC2030", VA = "0x188BC3230", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private LBNPDHMCBML FFBHAPPJEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private NFGFJOGJHBJ MGPCMCDPGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private IDisposable PPPIPMBBGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private IDisposable NAFJLEMDPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private HashSet<ReflectionProbe> AAKPIPNLADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private bool DNPOMJJLFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private bool JCLLPKFAGLH;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8BC4990", Offset = "0x8BC3790", VA = "0x188BC4990")]
	[UnityEngine.Scripting.Preserve]
	public GNBFHJLBDBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8BC46B0", Offset = "0x8BC34B0", VA = "0x188BC46B0", Slot = "4")]
	public void InitExternal(CKKEMANKHME GLBBEGAGJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8BC4140", Offset = "0x8BC2F40", VA = "0x188BC4140")]
	private void GGNGAAMMAKB(Scene NOELEJKPMFF, LoadSceneMode EKCMFHDCCCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8BC3EB0", Offset = "0x8BC2CB0", VA = "0x188BC3EB0")]
	private void CPNMIJOKIMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8BC4830", Offset = "0x8BC3630", VA = "0x188BC4830")]
	private void NHOLDMLMFKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8BC3B90", Offset = "0x8BC2990", VA = "0x188BC3B90")]
	private (ReflectionProbe, int) ABFPAJCEEJM()
	{
		return default((ReflectionProbe, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8BC4630", Offset = "0x8BC3430", VA = "0x188BC4630")]
	[IteratorStateMachine(typeof(FCFOLGFANBP))]
	private IEnumerator<PHFDFIIIMCE> HMGJOOPBIHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8BC3D80", Offset = "0x8BC2B80", VA = "0x188BC3D80")]
	private void CLKFCJFFBLF([CanBeNull] ReflectionProbe EPFAOMFMJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8BC3D50", Offset = "0x8BC2B50", VA = "0x188BC3D50")]
	private void BMGHHBPBNKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8BC3E60", Offset = "0x8BC2C60", VA = "0x188BC3E60")]
	private void CNMDCHNNEIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8BC4060", Offset = "0x8BC2E60", VA = "0x188BC4060", Slot = "5")]
	public void EMLPGEIJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8BC4150", Offset = "0x8BC2F50", VA = "0x188BC4150")]
	[CompilerGenerated]
	private void HKDAGDDOBNP()
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
