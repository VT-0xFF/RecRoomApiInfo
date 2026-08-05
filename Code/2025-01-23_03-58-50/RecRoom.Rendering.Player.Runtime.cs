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
	public class LogRegistrationIndex : GEPCMJPGCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x763C630", Offset = "0x763AE30", VA = "0x18763C630", Slot = "4")]
		public override void CCEDGNHHKOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8BAFD0", Offset = "0x8B97D0", VA = "0x1808BAFD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1A468A0", Offset = "0x1A450A0", VA = "0x181A468A0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x763D5B0", Offset = "0x763BDB0", VA = "0x18763D5B0")]
		private void HOKDCPPBEII(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x763D9C0", Offset = "0x763C1C0", VA = "0x18763D9C0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x763D7F0", Offset = "0x763BFF0", VA = "0x18763D7F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x763DA20", Offset = "0x763C220", VA = "0x18763DA20")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(MJOCDHMKNFB), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
public class MJOCDHMKNFB : IMBPGJLPPFF, GOCAFABHBEB
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class EEGEHGEBBDB : IEnumerator<IJKEOMMDACC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IJKEOMMDACC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public MJOCDHMKNFB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private IJKEOMMDACC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
		[DebuggerHidden]
		public EEGEHGEBBDB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x763B8A0", Offset = "0x763A0A0", VA = "0x18763B8A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x763BAC0", Offset = "0x763A2C0", VA = "0x18763BAC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EDJBFACNFGO ODCCBFHBAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DLEJEIAEBAP CELIBEPGAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private IDisposable AOEOOCOOMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private IDisposable KDBCPPICHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HashSet<ReflectionProbe> HOLJLILPPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool CLFFDDMDOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private bool BNANPKAFJGE;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x763D520", Offset = "0x763BD20", VA = "0x18763D520")]
	[UnityEngine.Scripting.Preserve]
	public MJOCDHMKNFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x763CF60", Offset = "0x763B760", VA = "0x18763CF60", Slot = "4")]
	public void LOINKCOKIAC(IMGHKCMNGFB AFLKPGNHIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x763D2A0", Offset = "0x763BAA0", VA = "0x18763D2A0")]
	private void NJBFENCDDLF(Scene PEHNLLCAPBJ, LoadSceneMode CJLAALNMBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x763D2B0", Offset = "0x763BAB0", VA = "0x18763D2B0")]
	private void OIIBKINNBCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x763CD20", Offset = "0x763B520", VA = "0x18763CD20")]
	private void EIMMKECCCKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x763D0E0", Offset = "0x763B8E0", VA = "0x18763D0E0")]
	private (ReflectionProbe, int) MIIHGPHJBJC()
	{
		return default((ReflectionProbe, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x763CEE0", Offset = "0x763B6E0", VA = "0x18763CEE0")]
	[IteratorStateMachine(typeof(EEGEHGEBBDB))]
	private IEnumerator<IJKEOMMDACC> KILOIEOOPEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x763CE00", Offset = "0x763B600", VA = "0x18763CE00")]
	private void GAMBHEEOFKF([CanBeNull] ReflectionProbe PLAOHKODHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x763D460", Offset = "0x763BC60", VA = "0x18763D460")]
	private void OPJGMDMNMGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x763CBF0", Offset = "0x763B3F0", VA = "0x18763CBF0")]
	private void DBHMKDOIPDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x763CC40", Offset = "0x763B440", VA = "0x18763CC40", Slot = "5")]
	public void DECDNNFOBFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x763C700", Offset = "0x763AF00", VA = "0x18763C700")]
	[CompilerGenerated]
	private void ANIDJJAANBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface EDJBFACNFGO
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int? JAIMNMCMGAM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool FLFOOGFAONG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MGALOBKJMIC();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class LPJEMGAANFL : EDJBFACNFGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly string OCFOPIKMOII;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly string DBNIBEHNHIH;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly string NNMEBBCANEO;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static readonly string LELPJCJICNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private KHOLIEJJFCA HHDLNCGBDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int? AHDNBNOPAGA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int? JAIMNMCMGAM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool FLFOOGFAONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8BB030", Offset = "0x8B9830", VA = "0x1808BB030", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8BB010", Offset = "0x8B9810", VA = "0x1808BB010")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
	[UnityEngine.Scripting.Preserve]
	public LPJEMGAANFL([NotNull][NDCFMLCHJCI(null)] KHOLIEJJFCA PDNGGKANKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x763C1C0", Offset = "0x763A9C0", VA = "0x18763C1C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x763BB10", Offset = "0x763A310", VA = "0x18763BB10")]
	[PDAMAKFHAHC.ELHPMEBKNPF.EOFCJBJBGID]
	[UsedImplicitly]
	public static void AADICJPEAKP(CMONJLKOOCI MFHCHOKEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x763C3A0", Offset = "0x763ABA0", VA = "0x18763C3A0", Slot = "5")]
	public void MGALOBKJMIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x763BC00", Offset = "0x763A400", VA = "0x18763BC00")]
	private void APMDGJNNKPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x763C2C0", Offset = "0x763AAC0", VA = "0x18763C2C0")]
	private bool FGCDBJDOMDM(string JFIOPIKGGLF, [Out] JFLMKPADPMF HLHHKMCKAPN)
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
