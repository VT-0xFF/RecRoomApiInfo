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
	public class LogRegistrationIndex : CGFLIBNDCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7989650", Offset = "0x7988450", VA = "0x187989650", Slot = "4")]
		public override void EHDMJEMLBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F41F0", Offset = "0x8F2FF0", VA = "0x1808F41F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1E0BA10", Offset = "0x1E0A810", VA = "0x181E0BA10", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7989990", Offset = "0x7988790", VA = "0x187989990")]
		private void OGIEEDDHGBJ(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7989DA0", Offset = "0x7988BA0", VA = "0x187989DA0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7989BD0", Offset = "0x79889D0", VA = "0x187989BD0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7989E00", Offset = "0x7988C00", VA = "0x187989E00")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(DAFJJJAKJFE), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
public class DAFJJJAKJFE : NAIFEMPPMKG, EJBGNPMNAED
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class OHNIJLEHFNB : IEnumerator<HLGDLHCLDFE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private HLGDLHCLDFE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public DAFJJJAKJFE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private HLGDLHCLDFE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
		[DebuggerHidden]
		public OHNIJLEHFNB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7989720", Offset = "0x7988520", VA = "0x187989720", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7989940", Offset = "0x7988740", VA = "0x187989940", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private FHBGNCCHGJN COKKPCOAFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DDJGAGKAGGH DOJMABCOJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private IDisposable LDLGJLLAPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private IDisposable CGKGNLBPDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HashSet<ReflectionProbe> NBDMDANGOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool IFAEPCCEMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private bool HHANBCDOEKM;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7988AA0", Offset = "0x79878A0", VA = "0x187988AA0")]
	[UnityEngine.Scripting.Preserve]
	public DAFJJJAKJFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7987C80", Offset = "0x7986A80", VA = "0x187987C80", Slot = "4")]
	public void FELIODKOHEH(BFHPBCPPECP AGGPMDGGKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7988270", Offset = "0x7987070", VA = "0x187988270")]
	private void LPGJCIMJJDO(Scene OMJGHNNJPBG, LoadSceneMode PLJGGEGLFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7988090", Offset = "0x7986E90", VA = "0x187988090")]
	private void KMGJEMPMDGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7988280", Offset = "0x7987080", VA = "0x187988280")]
	private void MEBPNDFJGEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7987E50", Offset = "0x7986C50", VA = "0x187987E50")]
	private (ReflectionProbe, int) IOCAHCDAFGH()
	{
		return default((ReflectionProbe, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7988010", Offset = "0x7986E10", VA = "0x187988010")]
	[IteratorStateMachine(typeof(OHNIJLEHFNB))]
	private IEnumerator<HLGDLHCLDFE> JGFLODNIJNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7988360", Offset = "0x7987160", VA = "0x187988360")]
	private void MGAEGGCNMMB([CanBeNull] ReflectionProbe BDAANLJKOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7988240", Offset = "0x7987040", VA = "0x187988240")]
	private void LCEOGMEMEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7987E00", Offset = "0x7986C00", VA = "0x187987E00")]
	private void HLJMPAPNFIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7988440", Offset = "0x7987240", VA = "0x187988440", Slot = "5")]
	public void OAKNFNBDPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7988520", Offset = "0x7987320", VA = "0x187988520")]
	[CompilerGenerated]
	private void PANHBNLMFMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FHBGNCCHGJN
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int? EIHILOCICLF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool NFFCDOAAPKH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ACMCKEMGJDG();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class IBEMPBPGJBL : FHBGNCCHGJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly string OPMFDNAKIFD;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly string EDOAMJGOPEK;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly string OLBCBMGHFGL;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static readonly string OHBLEICEAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private JGLLKCGMCOF GLNNMDMAIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int? JHMGLHEFOJG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int? EIHILOCICLF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool NFFCDOAAPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8F4420", Offset = "0x8F3220", VA = "0x1808F4420", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8F43F0", Offset = "0x8F31F0", VA = "0x1808F43F0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
	[UnityEngine.Scripting.Preserve]
	public IBEMPBPGJBL([NotNull][MHFJPMCEEAM(null)] JGLLKCGMCOF HMFEFPHLCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7988C30", Offset = "0x7987A30", VA = "0x187988C30", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x79893D0", Offset = "0x79881D0", VA = "0x1879893D0")]
	[FOLINPJCBJN.MNGLEKFJHCC.CIIMNDHGCHC]
	[UsedImplicitly]
	public static void PLMNLGEEKGM(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7988B30", Offset = "0x7987930", VA = "0x187988B30", Slot = "5")]
	public void ACMCKEMGJDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7988D30", Offset = "0x7987B30", VA = "0x187988D30")]
	private void IGANGGCJGLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x79892F0", Offset = "0x79880F0", VA = "0x1879892F0")]
	private bool NDIECDMJPFK(string PKOOHHGDCDI, [Out] MEBFFNJMPKE IIPFEBFLPCB)
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
