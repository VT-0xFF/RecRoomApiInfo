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
	public class LogRegistrationIndex : PNJEOLJBAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7F7C770", Offset = "0x7F7BB70", VA = "0x187F7C770", Slot = "4")]
		public override void ELBDPICAHPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Rendering_Player_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
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
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x993260", Offset = "0x992660", VA = "0x180993260", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1F206C0", Offset = "0x1F1FAC0", VA = "0x181F206C0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7F7C840", Offset = "0x7F7BC40", VA = "0x187F7C840")]
		private void LBKELEMAONI(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7F7CC60", Offset = "0x7F7C060", VA = "0x187F7CC60", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7F7CA90", Offset = "0x7F7BE90", VA = "0x187F7CA90", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7F7CCC0", Offset = "0x7F7C0C0", VA = "0x187F7CCC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(DNBEBFMIMDJ), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
public class DNBEBFMIMDJ : FKFNCFDENLD, AOPBNJCLOCO
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class BFAFCKPFEKL : IEnumerator<OAGIBKDGOAG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private OAGIBKDGOAG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public DNBEBFMIMDJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private OAGIBKDGOAG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
		[DebuggerHidden]
		public BFAFCKPFEKL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7F7AB10", Offset = "0x7F79F10", VA = "0x187F7AB10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7F7AD30", Offset = "0x7F7A130", VA = "0x187F7AD30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private FOHJMLKGAFL BCEONPJLDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private AHFKEHIEJLO PEEKJHPAMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private IDisposable IJHHMJOIPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private IDisposable DDCMGKMDPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HashSet<ReflectionProbe> CPEBAIPNNDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool KCEFIABODHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private bool LFOGEFJFIOO;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7F7BBD0", Offset = "0x7F7AFD0", VA = "0x187F7BBD0")]
	[UnityEngine.Scripting.Preserve]
	public DNBEBFMIMDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7F7B700", Offset = "0x7F7AB00", VA = "0x187F7B700", Slot = "4")]
	public void HPLJIIMENGB(INNCJKBLPNO OOCDOIMOCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7F7AD80", Offset = "0x7F7A180", VA = "0x187F7AD80")]
	private void AFHMCHEPEPD(Scene DOINGIGHMLK, LoadSceneMode GCAOLJHECEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7F7B390", Offset = "0x7F7A790", VA = "0x187F7B390")]
	private void FLPIOBHICOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7F7B540", Offset = "0x7F7A940", VA = "0x187F7B540")]
	private void FPNNIELHMPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7F7B990", Offset = "0x7F7AD90", VA = "0x187F7B990")]
	private (ReflectionProbe, int) KNNFECANAGB()
	{
		return default((ReflectionProbe, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7F7B310", Offset = "0x7F7A710", VA = "0x187F7B310")]
	[IteratorStateMachine(typeof(BFAFCKPFEKL))]
	private IEnumerator<OAGIBKDGOAG> DNIDKCEGJFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7F7B880", Offset = "0x7F7AC80", VA = "0x187F7B880")]
	private void IIAGOFGIOON([CanBeNull] ReflectionProbe HMIHGCNBJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7F7B960", Offset = "0x7F7AD60", VA = "0x187F7B960")]
	private void JJFJLPCGEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7F7B2C0", Offset = "0x7F7A6C0", VA = "0x187F7B2C0")]
	private void CJAPMHOPFIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7F7B620", Offset = "0x7F7AA20", VA = "0x187F7B620", Slot = "5")]
	public void GBFOCOOFFAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7F7AD90", Offset = "0x7F7A190", VA = "0x187F7AD90")]
	[CompilerGenerated]
	private void BMFHOGCIHLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FOHJMLKGAFL
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int? CNLDBEGLLJG
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool KKKGFKNOAPA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void APEODBFMBGJ();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class FEMLHLEDABL : FOHJMLKGAFL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly string GHJPLMCHCCD;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly string KCKACJAEOPN;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly string EKMCHJDKIPF;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static readonly string DMLCJGLAADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private HNAFBHEKIKK FLOCEKFGACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int? LKMHLOLNCDO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int? CNLDBEGLLJG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool KKKGFKNOAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9932A0", Offset = "0x9926A0", VA = "0x1809932A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x993530", Offset = "0x992930", VA = "0x180993530")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x999BC0", Offset = "0x998FC0", VA = "0x180999BC0")]
	[UnityEngine.Scripting.Preserve]
	public FEMLHLEDABL([NotNull][GKAMHFFOHNI(null)] HNAFBHEKIKK JHNCNOHACNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7F7BE40", Offset = "0x7F7B240", VA = "0x187F7BE40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7F7BF40", Offset = "0x7F7B340", VA = "0x187F7BF40")]
	[BOBPNFIGGBE.FIPHDKCKMAJ.LALHFPBIBCF]
	[UsedImplicitly]
	public static void LHAMNHDMAAP(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7F7BD40", Offset = "0x7F7B140", VA = "0x187F7BD40", Slot = "5")]
	public void APEODBFMBGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7F7C040", Offset = "0x7F7B440", VA = "0x187F7C040")]
	private void LKBBKOIDFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7F7BC60", Offset = "0x7F7B060", VA = "0x187F7BC60")]
	private bool ANCIKOKFALB(string PPIKALIEIFC, [Out] KEMDOGMNHAO GJMFDCHKLIM)
	{
		return default(bool);
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
