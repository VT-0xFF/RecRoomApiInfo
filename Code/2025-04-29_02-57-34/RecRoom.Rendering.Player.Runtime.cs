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
	public class LogRegistrationIndex : EEFEEDICGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8285E30", Offset = "0x8285230", VA = "0x188285E30", Slot = "4")]
		public override void KECNLMAOALC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C91B0", Offset = "0x9C85B0", VA = "0x1809C91B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1FE38C0", Offset = "0x1FE2CC0", VA = "0x181FE38C0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8286CB0", Offset = "0x82860B0", VA = "0x188286CB0")]
		private void NJKHJLGIPFD(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x82870D0", Offset = "0x82864D0", VA = "0x1882870D0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8286F00", Offset = "0x8286300", VA = "0x188286F00", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8287130", Offset = "0x8286530", VA = "0x188287130")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(GBEOKDAMECF), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
public class GBEOKDAMECF : DBKIICEIIAJ, BAEPLJFAONJ
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class NKFAHPKLLKL : IEnumerator<LCENDOCODMB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private LCENDOCODMB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public GBEOKDAMECF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private LCENDOCODMB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
		[DebuggerHidden]
		public NKFAHPKLLKL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8285F00", Offset = "0x8285300", VA = "0x188285F00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8286120", Offset = "0x8285520", VA = "0x188286120", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private PIIBHKCMAIM FPFFKMEPPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private JCLFAFBONEJ ECOOMGNDJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private IDisposable DPJNJOMGGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private IDisposable EICAFOLAFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HashSet<ReflectionProbe> AJMKDMDPGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool CIEFGMHONAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private bool KOJOICGGFGB;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8285DA0", Offset = "0x82851A0", VA = "0x188285DA0")]
	[UnityEngine.Scripting.Preserve]
	public GBEOKDAMECF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8285120", Offset = "0x8284520", VA = "0x188285120", Slot = "4")]
	public void EDGPMBLAOPL(KKNBMHIKNAE GDLAIBAPFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8285690", Offset = "0x8284A90", VA = "0x188285690")]
	private void NGIDDIKNNGL(Scene BBIMGEBBLLE, LoadSceneMode ENNGHBAFJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x82854E0", Offset = "0x82848E0", VA = "0x1882854E0")]
	private void LEFAKPBLAEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8285040", Offset = "0x8284440", VA = "0x188285040")]
	private void CDJFPOLDKIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8285320", Offset = "0x8284720", VA = "0x188285320")]
	private (ReflectionProbe, int) LBNIGDIBEHI()
	{
		return default((ReflectionProbe, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8285C90", Offset = "0x8285090", VA = "0x188285C90")]
	[IteratorStateMachine(typeof(NKFAHPKLLKL))]
	private IEnumerator<LCENDOCODMB> PHMHEFDNEKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8285BB0", Offset = "0x8284FB0", VA = "0x188285BB0")]
	private void PEGMLHMMKOE([CanBeNull] ReflectionProbe NHLEHAEPCMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x82852A0", Offset = "0x82846A0", VA = "0x1882852A0")]
	private void HEGLKNAPADD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x82852D0", Offset = "0x82846D0", VA = "0x1882852D0")]
	private void KMCGCCGCJNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8284F60", Offset = "0x8284360", VA = "0x188284F60", Slot = "5")]
	public void AECAJPPNPKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x82856A0", Offset = "0x8284AA0", VA = "0x1882856A0")]
	[CompilerGenerated]
	private void OBJNIBGEGJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PIIBHKCMAIM
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int? PPPJPGCIBMH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool PAMPFLMPOGH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OEDKJBBAIKG();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class NLMGBGDJJIN : PIIBHKCMAIM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly string IEHDCGKHLOD;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly string PICAPFOCFAD;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly string KPJDDEIMGKA;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static readonly string JHJCICKJNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private MGDFFFNAIOO CBNCLFJJAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int? FGDAOBPLEDM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int? PPPJPGCIBMH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool PAMPFLMPOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9C91C0", Offset = "0x9C85C0", VA = "0x1809C91C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9C9250", Offset = "0x9C8650", VA = "0x1809C9250")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9D4E40", Offset = "0x9D4240", VA = "0x1809D4E40")]
	[UnityEngine.Scripting.Preserve]
	public NLMGBGDJJIN([NotNull][MGCCDFKFGBG(null)] MGDFFFNAIOO LHEFKPIDAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8286740", Offset = "0x8285B40", VA = "0x188286740", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8286840", Offset = "0x8285C40", VA = "0x188286840")]
	[ACPGCKDGGJH.EECHBLLBGJE.IPGDONABLJD]
	[UsedImplicitly]
	public static void JPNPCPJENDO(NPCGGDCACLM INELJPKBMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8286A20", Offset = "0x8285E20", VA = "0x188286A20", Slot = "5")]
	public void OEDKJBBAIKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8286170", Offset = "0x8285570", VA = "0x188286170")]
	private void AAOBKALHDFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8286940", Offset = "0x8285D40", VA = "0x188286940")]
	private bool MAGBMBKMJHH(string KOBKOCPEOBL, [Out] IMJGCKAKFKN BGMONDCPEJM)
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
