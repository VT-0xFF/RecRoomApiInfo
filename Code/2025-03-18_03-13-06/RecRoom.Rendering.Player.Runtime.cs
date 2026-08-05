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
	public class LogRegistrationIndex : LGGBAGMLBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7D5A7F0", Offset = "0x7D599F0", VA = "0x187D5A7F0", Slot = "4")]
		public override void COGNOIDNGPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x964CD0", Offset = "0x963ED0", VA = "0x180964CD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1E90770", Offset = "0x1E8F970", VA = "0x181E90770", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7D5C520", Offset = "0x7D5B720", VA = "0x187D5C520")]
		private void BCKFAMNGJJN(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7D5C940", Offset = "0x7D5BB40", VA = "0x187D5C940", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7D5C770", Offset = "0x7D5B970", VA = "0x187D5C770", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7D5C9A0", Offset = "0x7D5BBA0", VA = "0x187D5C9A0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(OJICIPIALFL), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
public class OJICIPIALFL : DMMDEKGKPLC, DKPHGOHMHMA
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class NNEDLNAALBO : IEnumerator<DEPLMKJKOMK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private DEPLMKJKOMK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public OJICIPIALFL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private DEPLMKJKOMK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
		[DebuggerHidden]
		public NNEDLNAALBO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7D5B3D0", Offset = "0x7D5A5D0", VA = "0x187D5B3D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7D5B5F0", Offset = "0x7D5A7F0", VA = "0x187D5B5F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private ENABOGPFINL GAOKJFKKJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private LKJLIEKKDMF OPGFFACOELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private IDisposable DFFFBKGMDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private IDisposable BEKCCMAABBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HashSet<ReflectionProbe> EFOJHJBNHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool GGKCCLEFFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private bool HKPBNBBJBFA;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7D5C490", Offset = "0x7D5B690", VA = "0x187D5C490")]
	[UnityEngine.Scripting.Preserve]
	public OJICIPIALFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7D5BB70", Offset = "0x7D5AD70", VA = "0x187D5BB70", Slot = "4")]
	public void ELIHEGOOGMP(DBCOBCEEMIL LGCLECJNKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7D5BCF0", Offset = "0x7D5AEF0", VA = "0x187D5BCF0")]
	private void EOJFPPICIML(Scene DDKIMJLBIBI, LoadSceneMode FECFBMCNEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7D5C180", Offset = "0x7D5B380", VA = "0x187D5C180")]
	private void MLHOIABCNKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7D5BFC0", Offset = "0x7D5B1C0", VA = "0x187D5BFC0")]
	private void KJCMLKPDMMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7D5BE00", Offset = "0x7D5B000", VA = "0x187D5BE00")]
	private (ReflectionProbe, int) HOIINHEEFIA()
	{
		return default((ReflectionProbe, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7D5BD80", Offset = "0x7D5AF80", VA = "0x187D5BD80")]
	[IteratorStateMachine(typeof(NNEDLNAALBO))]
	private IEnumerator<DEPLMKJKOMK> HLAIJBBCFEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7D5C0A0", Offset = "0x7D5B2A0", VA = "0x187D5C0A0")]
	private void LOAABEDANNF([CanBeNull] ReflectionProbe APDHCHINPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7D5BD00", Offset = "0x7D5AF00", VA = "0x187D5BD00")]
	private void EOPFPEHEKBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7D5BD30", Offset = "0x7D5AF30", VA = "0x187D5BD30")]
	private void FCMHLCJIKLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7D5C330", Offset = "0x7D5B530", VA = "0x187D5C330", Slot = "5")]
	public void PPDMLGCOEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B640", Offset = "0x7D5A840", VA = "0x187D5B640")]
	[CompilerGenerated]
	private void EHFBGCLMIND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface ENABOGPFINL
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int? KFMBBIAJGNC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool NHHGENNNBPG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LGDFOJPINPD();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class MNKIDBFDIDB : ENABOGPFINL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly string JIDCHEKILLM;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly string BDDCGCCCBEP;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly string NBFNIMLOICF;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static readonly string OAOAFMAMNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private FHHIANONFNH OJAPDAKIAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int? IEJHMEGEFJN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int? KFMBBIAJGNC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool NHHGENNNBPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x964F10", Offset = "0x964110", VA = "0x180964F10", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x964F50", Offset = "0x964150", VA = "0x180964F50")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x970550", Offset = "0x96F750", VA = "0x180970550")]
	[UnityEngine.Scripting.Preserve]
	public MNKIDBFDIDB([NotNull][KMMHIEIDBEA(null)] FHHIANONFNH MDKMPMLAPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7D5AF80", Offset = "0x7D5A180", VA = "0x187D5AF80", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7D5AE80", Offset = "0x7D5A080", VA = "0x187D5AE80")]
	[LDKBBAENJDF.GEEMEPAJEEA.KFNNKBLDKPF]
	[UsedImplicitly]
	public static void BCKNIEJEBAF(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B160", Offset = "0x7D5A360", VA = "0x187D5B160", Slot = "5")]
	public void LGDFOJPINPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7D5A8C0", Offset = "0x7D59AC0", VA = "0x187D5A8C0")]
	private void AMBBCCKKKOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B080", Offset = "0x7D5A280", VA = "0x187D5B080")]
	private bool FOLDOJNGPBE(string JPNADNAMBPD, [Out] LPNNCNNLCBB EPIENOJKHEO)
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
