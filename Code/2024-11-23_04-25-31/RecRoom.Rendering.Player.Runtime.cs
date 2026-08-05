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
	public class LogRegistrationIndex : IGBHOMLLHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x74A3E10", Offset = "0x74A2810", VA = "0x1874A3E10", Slot = "4")]
		public override void KFMGLABNFNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
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
			[Cpp2IlInjected.Address(RVA = "0x8AD950", Offset = "0x8AC350", VA = "0x1808AD950", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x197E170", Offset = "0x197CB70", VA = "0x18197E170", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x74A3EE0", Offset = "0x74A28E0", VA = "0x1874A3EE0")]
		private void ACOMFCOBJKA(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x74A4300", Offset = "0x74A2D00", VA = "0x1874A4300", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x74A4130", Offset = "0x74A2B30", VA = "0x1874A4130", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x74A4360", Offset = "0x74A2D60", VA = "0x1874A4360")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(IGDHCAPGGJJ), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
public class IGDHCAPGGJJ : IIBEELHAOEN, CGBLBMCHGNL
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class JFDCLEACFIJ : IEnumerator<BGFOJNANPKN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private BGFOJNANPKN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public IGDHCAPGGJJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private BGFOJNANPKN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
		[DebuggerHidden]
		public JFDCLEACFIJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x74A3090", Offset = "0x74A1A90", VA = "0x1874A3090", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x74A32B0", Offset = "0x74A1CB0", VA = "0x1874A32B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private LKPPJKHAMBP LLLCAGDFAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private OIJGODLJCJF PLBAIBGFDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private IDisposable PBPJPAMKMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private IDisposable JIBHBJMGKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HashSet<ReflectionProbe> NNPOFJKDBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool JIPFFIACCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private bool PHPAONAKABN;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x74A3000", Offset = "0x74A1A00", VA = "0x1874A3000")]
	[UnityEngine.Scripting.Preserve]
	public IGDHCAPGGJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x74A2E00", Offset = "0x74A1800", VA = "0x1874A2E00", Slot = "4")]
	public void OLJENCLOJEC(POGCJGLPEEP KGNEDNNDCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x74A2390", Offset = "0x74A0D90", VA = "0x1874A2390")]
	private void CNHCOFPGANH(Scene GMJKAJPJMEJ, LoadSceneMode FMCCBEHDIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x74A21E0", Offset = "0x74A0BE0", VA = "0x1874A21E0")]
	private void BAGJJGCFHJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x74A2710", Offset = "0x74A1110", VA = "0x1874A2710")]
	private void IEDMFDNMCII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x74A2500", Offset = "0x74A0F00", VA = "0x1874A2500")]
	private (ReflectionProbe, int) HAFLBCOLHKM()
	{
		return default((ReflectionProbe, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x74A23A0", Offset = "0x74A0DA0", VA = "0x1874A23A0")]
	[IteratorStateMachine(typeof(JFDCLEACFIJ))]
	private IEnumerator<BGFOJNANPKN> DOHBELCCKNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x74A27F0", Offset = "0x74A11F0", VA = "0x1874A27F0")]
	private void KGBBMBOPIGD([CanBeNull] ReflectionProbe NLNDPKLEBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x74A21B0", Offset = "0x74A0BB0", VA = "0x1874A21B0")]
	private void BACPBNLBOMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x74A26C0", Offset = "0x74A10C0", VA = "0x1874A26C0")]
	private void HDOGJNOGALN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x74A2420", Offset = "0x74A0E20", VA = "0x1874A2420", Slot = "5")]
	public void ENOAJELNKJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x74A28D0", Offset = "0x74A12D0", VA = "0x1874A28D0")]
	[CompilerGenerated]
	private void KPLHGJOLGLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LKPPJKHAMBP
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int? HKIMKGPKOLF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool GDHLAMNDFEM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFFMPAHJLAB();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class KFJPGHEKOHH : LKPPJKHAMBP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly string IPLHEFEAPMD;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly string JHOFNEBHHLC;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly string ICKEGKIAHNP;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static readonly string JPFFLHBLPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NBJKPJCPFJP OKNOLHGNDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int? GJAAFDIIPBP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int? HKIMKGPKOLF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool GDHLAMNDFEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8B0220", Offset = "0x8AEC20", VA = "0x1808B0220", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8B0150", Offset = "0x8AEB50", VA = "0x1808B0150")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
	[UnityEngine.Scripting.Preserve]
	public KFJPGHEKOHH([NotNull][CCLEDEMDDDH(null)] NBJKPJCPFJP HLMIPNCJNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x74A3400", Offset = "0x74A1E00", VA = "0x1874A3400", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x74A35E0", Offset = "0x74A1FE0", VA = "0x1874A35E0")]
	[EPFHFFCDLIN.PIOGMKDDBAI.EFFOPIDOPOD]
	[UsedImplicitly]
	public static void IIDNIHHKMFF(KNPHAFHLPCE DNJEODDCEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x74A3300", Offset = "0x74A1D00", VA = "0x1874A3300", Slot = "5")]
	public void DFFMPAHJLAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x74A36E0", Offset = "0x74A20E0", VA = "0x1874A36E0")]
	private void PECNPMDGFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x74A3500", Offset = "0x74A1F00", VA = "0x1874A3500")]
	private bool HGNKHPBOFBI(string FNPLKLAKENK, [Out] DNJALJBLNHN OONINNBHIDJ)
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
