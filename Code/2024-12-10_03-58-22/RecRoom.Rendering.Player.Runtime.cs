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
	public class LogRegistrationIndex : IGKFPLMKJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x72FF6B0", Offset = "0x72FE2B0", VA = "0x1872FF6B0", Slot = "4")]
		public override void PEGPHNFMEDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
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
			[Cpp2IlInjected.Address(RVA = "0x88ABD0", Offset = "0x8897D0", VA = "0x18088ABD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x17502F0", Offset = "0x174EEF0", VA = "0x1817502F0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7300290", Offset = "0x72FEE90", VA = "0x187300290")]
		private void MNIOJKDAHNG(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x73006B0", Offset = "0x72FF2B0", VA = "0x1873006B0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x73004E0", Offset = "0x72FF0E0", VA = "0x1873004E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7300710", Offset = "0x72FF310", VA = "0x187300710")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(ILGJFBCJNPA), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
public class ILGJFBCJNPA : NAKOIIHECMB, POGLPIENEJD
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class DDDKGDBFNHB : IEnumerator<HGHICIBNEGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private HGHICIBNEGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public ILGJFBCJNPA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private HGHICIBNEGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x891CE0", Offset = "0x8908E0", VA = "0x180891CE0")]
		[DebuggerHidden]
		public DDDKGDBFNHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x72FE560", Offset = "0x72FD160", VA = "0x1872FE560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x72FE780", Offset = "0x72FD380", VA = "0x1872FE780", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private DOCMJCLGJCF FEKLIHLNACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private POEFAGDFHGA EILNBHKHMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private IDisposable KJPGJDNOBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private IDisposable LHPGALCBJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HashSet<ReflectionProbe> ALCHCIFHCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool LCPNHCLJNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private bool EMBAINDGAEK;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x72FF620", Offset = "0x72FE220", VA = "0x1872FF620")]
	[UnityEngine.Scripting.Preserve]
	public ILGJFBCJNPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x72FE7D0", Offset = "0x72FD3D0", VA = "0x1872FE7D0", Slot = "4")]
	public void APLOFKLOLNN(JHKOPLPKGAC AOJEPPFAEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x72FE950", Offset = "0x72FD550", VA = "0x1872FE950")]
	private void HJFNMAMLMBP(Scene INJNCECJCOB, LoadSceneMode LIPILINGBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x72FEA90", Offset = "0x72FD690", VA = "0x1872FEA90")]
	private void IMKDDBEBFLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x72FECF0", Offset = "0x72FD8F0", VA = "0x1872FECF0")]
	private void LNPIMMGIBJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x72FEDD0", Offset = "0x72FD9D0", VA = "0x1872FEDD0")]
	private (ReflectionProbe, int) MOLDOLLAKHA()
	{
		return default((ReflectionProbe, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x72FEC70", Offset = "0x72FD870", VA = "0x1872FEC70")]
	[IteratorStateMachine(typeof(DDDKGDBFNHB))]
	private IEnumerator<HGHICIBNEGP> LIEJENBIFFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x72FE9B0", Offset = "0x72FD5B0", VA = "0x1872FE9B0")]
	private void ILHJFCLEKOJ([CanBeNull] ReflectionProbe OGCOAOFNOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x72FEC40", Offset = "0x72FD840", VA = "0x1872FEC40")]
	private void JICCIHDOKAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x72FE960", Offset = "0x72FD560", VA = "0x1872FE960")]
	private void IAFBILKDPNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x72FF4C0", Offset = "0x72FE0C0", VA = "0x1872FF4C0", Slot = "5")]
	public void NPJJLDNPIGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x72FEF90", Offset = "0x72FDB90", VA = "0x1872FEF90")]
	[CompilerGenerated]
	private void NOEEGKEPAGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DOCMJCLGJCF
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int? MMJHHPJDPNB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool PACKMINPBHM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MCNHPFLLBFF();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class NNOBHIFEFNA : DOCMJCLGJCF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly string LCKNNHLODNF;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly string OFLAJMEDHAP;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly string HAJLAOBHNEK;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static readonly string JMIEKBNOBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private OAJBCHCNOFD EAOCCDDPGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int? LMOLJMKAEAA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int? MMJHHPJDPNB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool PACKMINPBHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x88C770", Offset = "0x88B370", VA = "0x18088C770", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x88C5E0", Offset = "0x88B1E0", VA = "0x18088C5E0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x889010", Offset = "0x887C10", VA = "0x180889010")]
	[UnityEngine.Scripting.Preserve]
	public NNOBHIFEFNA([NotNull][JGAMIMHCGFI(null)] OAJBCHCNOFD CEDBELBCGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x72FFD40", Offset = "0x72FE940", VA = "0x1872FFD40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x72FFE40", Offset = "0x72FEA40", VA = "0x1872FFE40")]
	[BOLBLOCFHKO.MMCPHMPAJDJ.PLMBBLHFMHB]
	[UsedImplicitly]
	public static void HNCDPMIAIIM(EAEKKMJPCLA EBEEBGHJNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7300020", Offset = "0x72FEC20", VA = "0x187300020", Slot = "5")]
	public void MCNHPFLLBFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x72FF780", Offset = "0x72FE380", VA = "0x1872FF780")]
	private void DJADFCGAPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x72FFF40", Offset = "0x72FEB40", VA = "0x1872FFF40")]
	private bool JAKEJDAMBCK(string DDCOKLDCGCM, [Out] LJGMMAECGKC BCKDIEICAMH)
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
