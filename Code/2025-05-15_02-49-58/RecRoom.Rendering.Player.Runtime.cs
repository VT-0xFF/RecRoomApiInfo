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
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x83DB190", Offset = "0x83D9790", VA = "0x1883DB190", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2064230", Offset = "0x2062830", VA = "0x182064230", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x83DCC50", Offset = "0x83DB250", VA = "0x1883DCC50")]
		private void MEMPKEBCMCB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83DD070", Offset = "0x83DB670", VA = "0x1883DD070", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83DCEA0", Offset = "0x83DB4A0", VA = "0x1883DCEA0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83DD0D0", Offset = "0x83DB6D0", VA = "0x1883DD0D0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(MJHOHHMBFLF), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
public class MJHOHHMBFLF : ILPONKCDKJP, MMMIGLKPHHG
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class ICBEDCDOGHC : IEnumerator<NFNODNEANBN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private NFNODNEANBN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public MJHOHHMBFLF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private NFNODNEANBN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
		[DebuggerHidden]
		public ICBEDCDOGHC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x83DAF20", Offset = "0x83D9520", VA = "0x1883DAF20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x83DB140", Offset = "0x83D9740", VA = "0x1883DB140", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private GIJNOMLKKCM MPINHHJFHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private JJOKNLDHNDC EPBLAJDMMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private IDisposable JDANGHFMNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private IDisposable CAKAHCABDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HashSet<ReflectionProbe> EMKFOJHLBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool HMJGAIHFENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private bool DNKKHEGBAOF;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x83DC0B0", Offset = "0x83DA6B0", VA = "0x1883DC0B0")]
	[UnityEngine.Scripting.Preserve]
	public MJHOHHMBFLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x83DB4A0", Offset = "0x83D9AA0", VA = "0x1883DB4A0", Slot = "4")]
	public void GJKEBEKMMLO(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x83DBCB0", Offset = "0x83DA2B0", VA = "0x1883DBCB0")]
	private void LBDHCNMDHJH(Scene JIODBHPKCLF, LoadSceneMode DNCLAIANHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x83DBCC0", Offset = "0x83DA2C0", VA = "0x1883DBCC0")]
	private void NDHMFNIHOFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x83DBF50", Offset = "0x83DA550", VA = "0x1883DBF50")]
	private void OMEHANFECGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x83DB260", Offset = "0x83D9860", VA = "0x1883DB260")]
	private (ReflectionProbe, int) AJIIHMDLMEL()
	{
		return default((ReflectionProbe, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x83DB700", Offset = "0x83D9D00", VA = "0x1883DB700")]
	[IteratorStateMachine(typeof(ICBEDCDOGHC))]
	private IEnumerator<NFNODNEANBN> INOGLCAENLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x83DB620", Offset = "0x83D9C20", VA = "0x1883DB620")]
	private void IEEOLJMNOOK([CanBeNull] ReflectionProbe ENILJCEKGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x83DB470", Offset = "0x83D9A70", VA = "0x1883DB470")]
	private void EMJMFAAODNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x83DB420", Offset = "0x83D9A20", VA = "0x1883DB420")]
	private void DFCEPFIPBNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x83DBE70", Offset = "0x83DA470", VA = "0x1883DBE70", Slot = "5")]
	public void NHMAMKPPBPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x83DB780", Offset = "0x83D9D80", VA = "0x1883DB780")]
	[CompilerGenerated]
	private void JLAONCMDDLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GIJNOMLKKCM
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int? LJBHEDAMJGH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool HLINDKHEKHE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADMFGNGLKOI();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class OIKFOKGOGNK : GIJNOMLKKCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly string PCGDIMNKCPF;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly string MGPCHNPMIAH;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly string CCGLODLCAGH;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static readonly string DJLJBEPCPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private LPGGOLFFKPF HPBOCPAIIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int? CBMLAGECLML;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int? LJBHEDAMJGH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool HLINDKHEKHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9EB560", Offset = "0x9E9B60", VA = "0x1809EB560", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9EB530", Offset = "0x9E9B30", VA = "0x1809EB530")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	[UnityEngine.Scripting.Preserve]
	public OIKFOKGOGNK([NotNull][DJIFKCCBBND(null)] LPGGOLFFKPF NNAMEELADIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x83DC240", Offset = "0x83DA840", VA = "0x1883DC240", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x83DC900", Offset = "0x83DAF00", VA = "0x1883DC900")]
	[AOJMKBDAFKB.CMNMOAIAENM.GMCOOAPNBEN]
	[UsedImplicitly]
	public static void HKGLCAEACML(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x83DC140", Offset = "0x83DA740", VA = "0x1883DC140", Slot = "5")]
	public void ADMFGNGLKOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x83DC340", Offset = "0x83DA940", VA = "0x1883DC340")]
	private void EGIMMPCFHLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x83DCA00", Offset = "0x83DB000", VA = "0x1883DCA00")]
	private bool PBFLAHBADBP(string HEPHPAEBDKO, [Out] MJOJGIJEOGI KMNBBMDKPOK)
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
