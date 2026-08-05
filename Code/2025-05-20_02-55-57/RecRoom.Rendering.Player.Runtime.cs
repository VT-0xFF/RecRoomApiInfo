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
	public class LogRegistrationIndex : IHAELNMODEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8453940", Offset = "0x8452B40", VA = "0x188453940", Slot = "4")]
		public override void OOCHIMKFMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2085180", Offset = "0x2084380", VA = "0x182085180", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x84548F0", Offset = "0x8453AF0", VA = "0x1884548F0")]
		private void NDIKJDPGAHM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8454D10", Offset = "0x8453F10", VA = "0x188454D10", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8454B40", Offset = "0x8453D40", VA = "0x188454B40", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8454D70", Offset = "0x8453F70", VA = "0x188454D70")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(POFKOKCJGKB), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
public class POFKOKCJGKB : FDPAHGLNLAC, AOOLNAMPIBN
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class FPEDIMFDFLG : IEnumerator<EAALCCOKLJL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private EAALCCOKLJL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public POFKOKCJGKB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private EAALCCOKLJL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
		[DebuggerHidden]
		public FPEDIMFDFLG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8452BC0", Offset = "0x8451DC0", VA = "0x188452BC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8452DE0", Offset = "0x8451FE0", VA = "0x188452DE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private ADHAPKMCNDG ONOBAMJLPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private PPGJNHFCBMP FPCJBNPEMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private IDisposable LKEFLBPDGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private IDisposable GPIGGALFBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HashSet<ReflectionProbe> OHDPAHBOKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool DHPDLCEIIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private bool JGJMJDHOFFA;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8454860", Offset = "0x8453A60", VA = "0x188454860")]
	[UnityEngine.Scripting.Preserve]
	public POFKOKCJGKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8453E00", Offset = "0x8453000", VA = "0x188453E00", Slot = "4")]
	public void GNFFNDKIPII(PJPDGGELCKG JIHODFEAJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x84547D0", Offset = "0x84539D0", VA = "0x1884547D0")]
	private void PDHHOMOAHNJ(Scene OPGEJIIHNLJ, LoadSceneMode HPBCICBDLGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8453C50", Offset = "0x8452E50", VA = "0x188453C50")]
	private void GAJCIBBFOGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8453A10", Offset = "0x8452C10", VA = "0x188453A10")]
	private void ECHAHHBBBPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x84545E0", Offset = "0x84537E0", VA = "0x1884545E0")]
	private (ReflectionProbe, int) NPCJOCLEGGI()
	{
		return default((ReflectionProbe, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8453BD0", Offset = "0x8452DD0", VA = "0x188453BD0")]
	[IteratorStateMachine(typeof(FPEDIMFDFLG))]
	private IEnumerator<EAALCCOKLJL> EHBFLNAGBKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8453F80", Offset = "0x8453180", VA = "0x188453F80")]
	private void IEJMHBKEKEO([CanBeNull] ReflectionProbe HILHNOHBCHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x84547A0", Offset = "0x84539A0", VA = "0x1884547A0")]
	private void PCECIELOJGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8454060", Offset = "0x8453260", VA = "0x188454060")]
	private void INOJFHPCFBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8453AF0", Offset = "0x8452CF0", VA = "0x188453AF0", Slot = "5")]
	public void EFOAOCGHIJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x84540B0", Offset = "0x84532B0", VA = "0x1884540B0")]
	[CompilerGenerated]
	private void MFMIDFCOMMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface ADHAPKMCNDG
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int? HJMBLPOHEDL
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool DKDJPGKJPPI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OMJKBMHMGHG();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class GHIEANHNBLD : ADHAPKMCNDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly string OJGIAKEDGKI;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly string DJBEOGEFLCB;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly string OBIPEIFFKLN;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static readonly string BHDKOMJIMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private HCDMAMCBAKB DLAABCONJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int? JMNELBNDCFG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int? HJMBLPOHEDL
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool DKDJPGKJPPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9F2490", Offset = "0x9F1690", VA = "0x1809F2490", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9F24F0", Offset = "0x9F16F0", VA = "0x1809F24F0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	[UnityEngine.Scripting.Preserve]
	public GHIEANHNBLD([NotNull][ALHAHLCGLLK(null)] HCDMAMCBAKB GEFFKAEDCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8452E30", Offset = "0x8452030", VA = "0x188452E30", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8452F30", Offset = "0x8452130", VA = "0x188452F30")]
	[DBIDCJGLKKO.GKLMLMNDHKE.BABOHFKFEPH]
	[UsedImplicitly]
	public static void FIHHPBEAEMH(HILJAABEPDC NPCDKJJJIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x84536D0", Offset = "0x84528D0", VA = "0x1884536D0", Slot = "5")]
	public void OMJKBMHMGHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8453030", Offset = "0x8452230", VA = "0x188453030")]
	private void GNBMDJBBCAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x84535F0", Offset = "0x84527F0", VA = "0x1884535F0")]
	private bool MNBBKNBLMLI(string ELFGENOOMEE, [Out] IDOKGLLPGKM PJFNFCOOMDP)
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
