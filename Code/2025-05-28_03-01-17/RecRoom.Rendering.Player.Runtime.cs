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
	public class LogRegistrationIndex : FNHPAIPGMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8588320", Offset = "0x8587120", VA = "0x188588320", Slot = "4")]
		public override void KEMEJJLNDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x20D9300", Offset = "0x20D8100", VA = "0x1820D9300", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85892C0", Offset = "0x85880C0", VA = "0x1885892C0")]
		private void OCIJCOAIOEO(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85896E0", Offset = "0x85884E0", VA = "0x1885896E0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8589510", Offset = "0x8588310", VA = "0x188589510", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8589740", Offset = "0x8588540", VA = "0x188589740")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(MOPMJMECEPD), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
public class MOPMJMECEPD : IIPCECBIBKI, IMNKKHLGPLB
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class FPIMEDHGFPE : IEnumerator<GCOFLMDGPIM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private GCOFLMDGPIM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public MOPMJMECEPD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private GCOFLMDGPIM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
		[DebuggerHidden]
		public FPIMEDHGFPE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8587570", Offset = "0x8586370", VA = "0x188587570", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8587790", Offset = "0x8586590", VA = "0x188587790", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private FFIAACFEKBM FNOIEHCHEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DMPDKJKKDKL MJGEODGDMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private IDisposable IFMLGBJMEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private IDisposable MEPPEENAIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HashSet<ReflectionProbe> NJMKHNIEPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool HNNDEADFFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private bool AJKIKKAIGKA;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8589230", Offset = "0x8588030", VA = "0x188589230")]
	[UnityEngine.Scripting.Preserve]
	public MOPMJMECEPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8588960", Offset = "0x8587760", VA = "0x188588960", Slot = "4")]
	public void PIEFLCLFLGG(LFBEMDOHFPC EPHKCBICOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8588820", Offset = "0x8587620", VA = "0x188588820")]
	private void OKDLLOPALLI(Scene CEAHIPAFCHH, LoadSceneMode AMLBFINICIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8588AE0", Offset = "0x85878E0", VA = "0x188588AE0")]
	private void PJMIMHEOIIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x85883F0", Offset = "0x85871F0", VA = "0x1885883F0")]
	private void AMAIGLHBCCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8588630", Offset = "0x8587430", VA = "0x188588630")]
	private (ReflectionProbe, int) JOAFFJHPGLL()
	{
		return default((ReflectionProbe, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x85884D0", Offset = "0x85872D0", VA = "0x1885884D0")]
	[IteratorStateMachine(typeof(FPIMEDHGFPE))]
	private IEnumerator<GCOFLMDGPIM> CFAAOLKACJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8588830", Offset = "0x8587630", VA = "0x188588830")]
	private void OOEEMEKDDCJ([CanBeNull] ReflectionProbe AANGHAAODFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x85887F0", Offset = "0x85875F0", VA = "0x1885887F0")]
	private void LAPJFNFJMFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8588910", Offset = "0x8587710", VA = "0x188588910")]
	private void PEFKLMNBAMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8588550", Offset = "0x8587350", VA = "0x188588550", Slot = "5")]
	public void DAHEEJMILJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8588C90", Offset = "0x8587A90", VA = "0x188588C90")]
	[CompilerGenerated]
	private void PPDMIGOHIID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FFIAACFEKBM
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int? ECKEONGLJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool APDFOELHKAO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BOHPDOCGFJJ();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class JMBBOMIPEOE : FFIAACFEKBM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly string DOBLCCOJLBF;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly string GBOEBNIEAJK;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly string EAFAINBMKMD;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static readonly string IHCPEGNKMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private MEHFIDNJION DCLMEFCNNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int? JIAIOIJPBBA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int? ECKEONGLJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool APDFOELHKAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED10", Offset = "0xA0DB10", VA = "0x180A0ED10", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECB0", Offset = "0xA0DAB0", VA = "0x180A0ECB0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	[UnityEngine.Scripting.Preserve]
	public JMBBOMIPEOE([NotNull][LCNEJNNIOGA(null)] MEHFIDNJION MOANACPPHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x85878E0", Offset = "0x85866E0", VA = "0x1885878E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x85879E0", Offset = "0x85867E0", VA = "0x1885879E0")]
	[ENKLKENGHAE.GHBFDECCGMJ.HGNDHHKALNH]
	[UsedImplicitly]
	public static void EDILNKCEBFD(NAELDDAANND AHGNCOFKLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x85877E0", Offset = "0x85865E0", VA = "0x1885877E0", Slot = "5")]
	public void BOHPDOCGFJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8587AE0", Offset = "0x85868E0", VA = "0x188587AE0")]
	private void GFDNHCAHBAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x85880B0", Offset = "0x8586EB0", VA = "0x1885880B0")]
	private bool HPCOAEAKKMC(string AJDPEDPHICH, [Out] AJFCMHLJFOA MPNKGAHAEKN)
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
