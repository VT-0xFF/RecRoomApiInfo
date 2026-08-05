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
	public class LogRegistrationIndex : LALFEIIPPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x844EE90", Offset = "0x844E090", VA = "0x18844EE90", Slot = "4")]
		public override void ELDCOJNOKAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
			[Cpp2IlInjected.Address(RVA = "0xA00F90", Offset = "0xA00190", VA = "0x180A00F90", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7E08C50", Offset = "0x7E07E50", VA = "0x187E08C50", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x844EFA0", Offset = "0x844E1A0", VA = "0x18844EFA0")]
		private void AGIDAPFICKK(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x844F420", Offset = "0x844E620", VA = "0x18844F420", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x844F1F0", Offset = "0x844E3F0", VA = "0x18844F1F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x844F480", Offset = "0x844E680", VA = "0x18844F480")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BNNKCKAKPPP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int? BLHDAAKBPJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool? NJPHOEFEEBC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CMMIHLOKAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FLOLKOPGEJB();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CGGGLOFACCN : BNNKCKAKPPP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly string COHFDLPECJG;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly string NFFIJBONLEG;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly string KNICGEHMEGJ;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly string LMKBKOCBKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private ABCAKKCKJPM BEPCHPICIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private int? KDGFAEHLJBE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int? BLHDAAKBPJE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool CMMIHLOKAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA0D3F0", Offset = "0xA0C5F0", VA = "0x180A0D3F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA0D640", Offset = "0xA0C840", VA = "0x180A0D640")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool? NJPHOEFEEBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x844CBD0", Offset = "0x844BDD0", VA = "0x18844CBD0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA0F6B0", Offset = "0xA0E8B0", VA = "0x180A0F6B0")]
	[UnityEngine.Scripting.Preserve]
	public CGGGLOFACCN([NGLIAOPBMFM(null)][NotNull] ABCAKKCKJPM BFEDBNCCFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x844C960", Offset = "0x844BB60", VA = "0x18844C960", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x844CA60", Offset = "0x844BC60", VA = "0x18844CA60")]
	[MGCKGAIBEHC.MJEHAAIJGKF.HELJMGKJDLB]
	[UsedImplicitly]
	public static void FGCLADANIMB(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x844CAD0", Offset = "0x844BCD0", VA = "0x18844CAD0", Slot = "5")]
	public void FLOLKOPGEJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x844CC20", Offset = "0x844BE20", VA = "0x18844CC20")]
	private void NAOHBFAAODJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x844C880", Offset = "0x844BA80", VA = "0x18844C880")]
	private bool APIBJHHKGPJ(string HPDNKGJKEOC, [Out] NEICAFDDAKC HIMKLEEPHMH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DPPJNMBLPOK
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FCCJMCNOBJP();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class INFALONKHNN : DPPJNMBLPOK
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class GKEFIPGKOPC : IEnumerator<NOFGPJFCPHG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private NOFGPJFCPHG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public INFALONKHNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private NOFGPJFCPHG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
		[DebuggerHidden]
		public GKEFIPGKOPC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x844D350", Offset = "0x844C550", VA = "0x18844D350", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x844D440", Offset = "0x844C640", VA = "0x18844D440", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private AFABIGEDGFJ JJMLHJOEJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int GFJLKODMIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool? PLCEGFHOKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool MIMJJHOGJPG;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static KEPOMIIOHBM JCEGKKDPMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HashSet<string> MIJLANGHPGD;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x844ED70", Offset = "0x844DF70", VA = "0x18844ED70")]
	[UnityEngine.Scripting.Preserve]
	public INFALONKHNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x844EBE0", Offset = "0x844DDE0", VA = "0x18844EBE0")]
	private AFABIGEDGFJ NFPFKFPPKBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x844EB60", Offset = "0x844DD60", VA = "0x18844EB60")]
	[IteratorStateMachine(typeof(GKEFIPGKOPC))]
	private IEnumerator<NOFGPJFCPHG> LEOFNNMIONN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x844E580", Offset = "0x844D780", VA = "0x18844E580")]
	private void BPCFJHMGCBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x844EAF0", Offset = "0x844DCF0", VA = "0x18844EAF0")]
	[MGCKGAIBEHC.PCMIGKEOIEO]
	public static void FGCLADANIMB(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x844E970", Offset = "0x844DB70", VA = "0x18844E970", Slot = "4")]
	public void FCCJMCNOBJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(IAEIHINDCOA), new string[] { })]
public class IAEIHINDCOA : KMKODLCHFCF, EJADEOIPJPK
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class HCCGEMPKHFF : IEnumerator<NOFGPJFCPHG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private NOFGPJFCPHG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public IAEIHINDCOA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private NOFGPJFCPHG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
		[DebuggerHidden]
		public HCCGEMPKHFF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x844D490", Offset = "0x844C690", VA = "0x18844D490", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x844D6B0", Offset = "0x844C8B0", VA = "0x18844D6B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private BNNKCKAKPPP ICHPPNBKALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private FAMJNCFEMOB INKJOLONDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private IDisposable EMPKGJNJPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private IDisposable MFEKEFOMLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private HashSet<ReflectionProbe> OMBFOIKLBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private bool FBBFHJGMPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private bool JPOODJDKACC;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x844E4F0", Offset = "0x844D6F0", VA = "0x18844E4F0")]
	[UnityEngine.Scripting.Preserve]
	public IAEIHINDCOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x844D8B0", Offset = "0x844CAB0", VA = "0x18844D8B0", Slot = "4")]
	public void InitExternal(EENCHNOCEIL BNPCDJLAAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x844E460", Offset = "0x844D660", VA = "0x18844E460")]
	private void PNDMHGACJMP(Scene PEKGABPLLNJ, LoadSceneMode DGDONNHKDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x844D700", Offset = "0x844C900", VA = "0x18844D700")]
	private void DEPGNCMFMDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x844E2A0", Offset = "0x844D4A0", VA = "0x18844E2A0")]
	private void PIAPDPFLGBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x844DA30", Offset = "0x844CC30", VA = "0x18844DA30")]
	private (ReflectionProbe, int) JCNFPHLFBPP()
	{
		return default((ReflectionProbe, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x844E110", Offset = "0x844D310", VA = "0x18844E110")]
	[IteratorStateMachine(typeof(HCCGEMPKHFF))]
	private IEnumerator<NOFGPJFCPHG> KNDLCBNINML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x844E190", Offset = "0x844D390", VA = "0x18844E190")]
	private void MPLHMLEHFIC([CanBeNull] ReflectionProbe CIHDNFOPJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x844E270", Offset = "0x844D470", VA = "0x18844E270")]
	private void OPPLNJOKGNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x844E0C0", Offset = "0x844D2C0", VA = "0x18844E0C0")]
	private void KKEBJKBHCIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x844E380", Offset = "0x844D580", VA = "0x18844E380", Slot = "5")]
	public void PNAGKOGGHJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x844DBF0", Offset = "0x844CDF0", VA = "0x18844DBF0")]
	[CompilerGenerated]
	private void JPPELPEGINA()
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
