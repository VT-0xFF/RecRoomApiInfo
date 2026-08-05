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
	public class LogRegistrationIndex : CCAGPMFGEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x807BFA0", Offset = "0x807A9A0", VA = "0x18807BFA0", Slot = "4")]
		public override void BLLBFFICICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
			[Cpp2IlInjected.Address(RVA = "0x9AED50", Offset = "0x9AD750", VA = "0x1809AED50", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1F7EA40", Offset = "0x1F7D440", VA = "0x181F7EA40", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x807C2E0", Offset = "0x807ACE0", VA = "0x18807C2E0")]
		private void IPCGMJBOKKK(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x807C6F0", Offset = "0x807B0F0", VA = "0x18807C6F0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x807C520", Offset = "0x807AF20", VA = "0x18807C520", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x807C750", Offset = "0x807B150", VA = "0x18807C750")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(AMPMMGLAIIK), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
public class AMPMMGLAIIK : PNIPCMGBJDE, BLJGGMGKPKC
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class OOBDIMIANKP : IEnumerator<HKMFJDMPEMN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private HKMFJDMPEMN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AMPMMGLAIIK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private HKMFJDMPEMN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
		[DebuggerHidden]
		public OOBDIMIANKP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x807C070", Offset = "0x807AA70", VA = "0x18807C070", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x807C290", Offset = "0x807AC90", VA = "0x18807C290", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private LDEKCFMNBBC JCJOINHBBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private MDHDCHJFICD LEOFCIFCAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private IDisposable GCCPICAOEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private IDisposable DFKIMFAFLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HashSet<ReflectionProbe> MHFAMANGEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool GEFIMMDJEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private bool GDCKHGMODEH;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x807B410", Offset = "0x8079E10", VA = "0x18807B410")]
	[UnityEngine.Scripting.Preserve]
	public AMPMMGLAIIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x807A5D0", Offset = "0x8078FD0", VA = "0x18807A5D0", Slot = "4")]
	public void ACILAGDNKKA(LBHNIGEPODB GNJMKKKJHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x807B2A0", Offset = "0x8079CA0", VA = "0x18807B2A0")]
	private void PDIPINLMMOH(Scene IJEICMOFAIA, LoadSceneMode EDIDCEGEMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x807A7A0", Offset = "0x80791A0", VA = "0x18807A7A0")]
	private void DHJAOCAAJOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x807AF50", Offset = "0x8079950", VA = "0x18807AF50")]
	private void FKFPGFAJEAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x807B0B0", Offset = "0x8079AB0", VA = "0x18807B0B0")]
	private (ReflectionProbe, int) HHKIJEHHLGM()
	{
		return default((ReflectionProbe, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x807B030", Offset = "0x8079A30", VA = "0x18807B030")]
	[IteratorStateMachine(typeof(OOBDIMIANKP))]
	private IEnumerator<HKMFJDMPEMN> GKFCKFOHDGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x807B2B0", Offset = "0x8079CB0", VA = "0x18807B2B0")]
	private void PKDEPKEHHMP([CanBeNull] ReflectionProbe EIEJGCPJAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x807B270", Offset = "0x8079C70", VA = "0x18807B270")]
	private void NHPKAPEPOOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x807A750", Offset = "0x8079150", VA = "0x18807A750")]
	private void BPEOMGJFGFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x807A950", Offset = "0x8079350", VA = "0x18807A950", Slot = "5")]
	public void FCBNDJLJLIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x807AA30", Offset = "0x8079430", VA = "0x18807AA30")]
	[CompilerGenerated]
	private void FJBNELMCDDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LDEKCFMNBBC
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int? KPJBKNFEHHC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool FMEMCNHAJBM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LLKKEEMLBGD();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class CJNCJDJPBGJ : LDEKCFMNBBC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly string PCBBNBCPBDD;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly string IPOGIJNOAGD;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly string MNNCEJBIAOJ;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static readonly string NOCFGHFAPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private OLFIBAGDMNG PBIENMJFEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int? OKDKPDIGFGM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int? KPJBKNFEHHC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool FMEMCNHAJBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9AED90", Offset = "0x9AD790", VA = "0x1809AED90", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9AED70", Offset = "0x9AD770", VA = "0x1809AED70")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9B0720", Offset = "0x9AF120", VA = "0x1809B0720")]
	[UnityEngine.Scripting.Preserve]
	public CJNCJDJPBGJ([NotNull][GJJKIKPKKBJ(null)] OLFIBAGDMNG AHGNNPDGDGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x807B590", Offset = "0x8079F90", VA = "0x18807B590", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x807B4A0", Offset = "0x8079EA0", VA = "0x18807B4A0")]
	[EFEOGKEOEKD.NFFKHFKJNGH.EEKBBBNAJHI]
	[UsedImplicitly]
	public static void ABOGAGGIHLM(LKOLOODKMPF MCJDMILNGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x807B770", Offset = "0x807A170", VA = "0x18807B770", Slot = "5")]
	public void LLKKEEMLBGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x807B870", Offset = "0x807A270", VA = "0x18807B870")]
	private void NECAGGCOIDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x807B690", Offset = "0x807A090", VA = "0x18807B690")]
	private bool IFPOAONFAPJ(string OODFLBJAOLN, [Out] BNNHEHHFIKA ANGIOFIPNCL)
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
