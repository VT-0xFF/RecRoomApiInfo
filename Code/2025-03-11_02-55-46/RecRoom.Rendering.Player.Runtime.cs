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
	public class LogRegistrationIndex : KENHJELJHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7D45B80", Offset = "0x7D44F80", VA = "0x187D45B80", Slot = "4")]
		public override void ICLMLJMBJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
			[Cpp2IlInjected.Address(RVA = "0x969450", Offset = "0x968850", VA = "0x180969450", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1E8F400", Offset = "0x1E8E800", VA = "0x181E8F400", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7D47890", Offset = "0x7D46C90", VA = "0x187D47890")]
		private void PFONFFPEPLP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7D47CA0", Offset = "0x7D470A0", VA = "0x187D47CA0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7D47AD0", Offset = "0x7D46ED0", VA = "0x187D47AD0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7D47D00", Offset = "0x7D47100", VA = "0x187D47D00")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(MEAGOFDLLDA), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
public class MEAGOFDLLDA : ONKICOMGDGN, JOOHDJKBMLK
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class OLFHMCMECNL : IEnumerator<MOLDBMJPKNN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private MOLDBMJPKNN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public MEAGOFDLLDA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private MOLDBMJPKNN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
		[DebuggerHidden]
		public OLFHMCMECNL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7D47620", Offset = "0x7D46A20", VA = "0x187D47620", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7D47840", Offset = "0x7D46C40", VA = "0x187D47840", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private OAGICCPMFAE AIBAKBMGPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private HAGJBHKCPHN LGBLBNLKODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private IDisposable EBCHMIOAHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private IDisposable LPCGDFDBPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HashSet<ReflectionProbe> DGJCJAAOEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool IOPNEGBOLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private bool BOGJIBBGNOB;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7D46A90", Offset = "0x7D45E90", VA = "0x187D46A90")]
	[UnityEngine.Scripting.Preserve]
	public MEAGOFDLLDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7D45E10", Offset = "0x7D45210", VA = "0x187D45E10", Slot = "4")]
	public void GFFMILOCPIL(FHGOKBONFMJ BHDEAEIFGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7D45F90", Offset = "0x7D45390", VA = "0x187D45F90")]
	private void GHBAELIBPFE(Scene DEOCBFPAFKF, LoadSceneMode MOKGMNPCLBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7D467E0", Offset = "0x7D45BE0", VA = "0x187D467E0")]
	private void KKNBOLOPPLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D30", Offset = "0x7D45130", VA = "0x187D45D30")]
	private void DGDDCELPAHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7D46620", Offset = "0x7D45A20", VA = "0x187D46620")]
	private (ReflectionProbe, int) KENGOLIDHKC()
	{
		return default((ReflectionProbe, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7D45FA0", Offset = "0x7D453A0", VA = "0x187D45FA0")]
	[IteratorStateMachine(typeof(OLFHMCMECNL))]
	private IEnumerator<MOLDBMJPKNN> GNMKJLPHJMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7D46020", Offset = "0x7D45420", VA = "0x187D46020")]
	private void IGFFLKIJCNE([CanBeNull] ReflectionProbe EFAHCPPKCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7D469E0", Offset = "0x7D45DE0", VA = "0x187D469E0")]
	private void OIGCBEOKOLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7D46990", Offset = "0x7D45D90", VA = "0x187D46990")]
	private void LPNGLPCPNBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7D45C50", Offset = "0x7D45050", VA = "0x187D45C50", Slot = "5")]
	public void CAHNJLIHDHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7D46100", Offset = "0x7D45500", VA = "0x187D46100")]
	[CompilerGenerated]
	private void JLLBJNBPFAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface OAGICCPMFAE
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int? JHINKFKAEPE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool DMHEPPNHCHL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CMFKJHGNBJG();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class MIJOCKJGNCI : OAGICCPMFAE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly string OOEDDNJEELH;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly string MLPGAMNDLPF;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly string HJECOBLPDED;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static readonly string KBLNNGJJFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private HKNCEKAFBLB MIAHCEFFCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int? MEPPOMNOKHE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int? JHINKFKAEPE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool DMHEPPNHCHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x96A750", Offset = "0x969B50", VA = "0x18096A750", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x96A740", Offset = "0x969B40", VA = "0x18096A740")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
	[UnityEngine.Scripting.Preserve]
	public MIJOCKJGNCI([NotNull][PNFCCJKFMBH(null)] HKNCEKAFBLB OANGCDEFDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7D471E0", Offset = "0x7D465E0", VA = "0x187D471E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7D472E0", Offset = "0x7D466E0", VA = "0x187D472E0")]
	[AEDFFNEEAKJ.LKOFKMOGMGJ.KBJNMFOOFMD]
	[UsedImplicitly]
	public static void GFADCAIANBG(LEPFMCICNAK EOMAFKDOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7D470E0", Offset = "0x7D464E0", VA = "0x187D470E0", Slot = "5")]
	public void CMFKJHGNBJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7D46B20", Offset = "0x7D45F20", VA = "0x187D46B20")]
	private void CMBKGJJICOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7D473D0", Offset = "0x7D467D0", VA = "0x187D473D0")]
	private bool HFMLDKKJOKJ(string KDMIPKLINBI, [Out] EMHLKGNIAGM JFMFADJOPEC)
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
